using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BusinessEntity;
using System.IO;
using System.Collections;
using System.Drawing.Printing;
using System.Drawing.Text;

namespace QuanLyTourDuLich.Forms
{
    public partial class fmReport : Form
    {
        TourBUS _tourBus;
        IEnumerable<Tour> _tourEntries;

        TourPriceBUS _tourPriceBus;
        IEnumerable<TourPrice> _tourPriceEntries;

        TourGroupBUS _tourGroupBus;
        IEnumerable<TourGroup> _tourGroupEntries;

        static string _tourGroupName;
        static string _tourName;
        static string _tourNameTab3;

        List<float> _revenueTotal; // Tổng doanh thu từ số vé đã bán
        List<float> _costTotal; //Tổng chi phí đã bó ra (chi phí khách sạn + chi phí di chuyển)

        List<float> _tourGroupTotal; //Tổng số đoàn của 1 tour
        List<float> _revenueTourTotal;
        List<float> _costTourTotal;

        List<float> _tourGroupTotalTab3;
        List<float> _revenueTourTotalTab3;
        List<float> _costTourTotalTab3;

        StringFormat _strFormat; // Sử dụng để định dang chuỗi trong các dòng của DataGridView
        ArrayList _columnCoor = new ArrayList(); // Sử dụng để lưu tọa độ của các cột
        ArrayList _columnWidths = new ArrayList(); // Sử dụng để lưu độ rộng của các cột
        int _cellHeight = 0; // Sử dụng thể thiết lập giá trị độ cao của các cell
        int _totalWidth = 0; // Tính tổng độ rộng cần để in
        int _count = 0; // Đếm số row
        int _headerHeight = 0; // Độ cao của header
        bool _firstPage = false;
        bool _newPage = false;

        public fmReport()
        {
            InitializeComponent();

            _tourBus = new TourBUS();
            _tourEntries = _tourBus.getEntries();

            _tourPriceBus = new TourPriceBUS();
            _tourPriceEntries = _tourPriceBus.getEntries();

            _tourGroupBus = new TourGroupBUS();
            _tourGroupEntries = _tourGroupBus.getEntries();

            _revenueTotal = new List<float>();
            _costTotal = new List<float>();

            _tourGroupTotal = new List<float>();
            _revenueTourTotal = new List<float>();
            _costTourTotal = new List<float>();

            _tourGroupTotalTab3 = new List<float>();
            _revenueTourTotalTab3 = new List<float>();
            _costTourTotalTab3 = new List<float>();

            dateTimeCustom();
            dateTimeCustom2();
        }

        private void fmReport_Load(object sender, EventArgs e)
        {
            /*Tab Doanh số của Đoàn*/
            cbbTourGroupList_Load(); //Load danh sách các đoàn hiện có
            btnTourGroupReport.Enabled = false;
            btnTourGroupReportPrint.Enabled = false;

            /*Tab Doanh số của Tour*/
            cbbTourList_Load(); //Load danh sách tour
            btnTourReport.Enabled = false;
            btnTourReportPrint.Enabled = false;

            /*Tab Tình hình hoạt động của các Tour*/
            cbbTourStatusReport_Load();
            btnTourStatusReport.Enabled = false;
            btnTourStatusReportPrint.Enabled = false;
        }

        #region Tab1: Doanh số của đoàn
        /// <summary>
        /// Button back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Load các danh sách đoàn du lịch hiện có
        /// </summary>
        /// <param name="tour"></param>
        private void cbbTourGroupList_Load()
        {
            cbbTourGroupList.Items.Add("--- Chọn tất cả ---");
            foreach (var tourGroup in _tourGroupEntries)
            {
                cbbTourGroupList.Items.Add(tourGroup.name);
            }
        }

        /// <summary>
        /// Sự kiện SelectedIndexChanged của combobox danh sách đoàn du lịch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbTourGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Chọn tất cả đoàn
                if (cbbTourGroupList.SelectedIndex == 0)
                {
                    btnTourGroupReport.Enabled = true;
                }
                else
                {
                    btnTourGroupReport.Enabled = true;
                    _tourGroupName = cbbTourGroupList.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        /// <summary>
        /// Custom DateTimePicker
        /// </summary>
        public void dateTimeCustom()
        {
            try
            {
                /*<--- From month --->*/
                // Tab: Doanh số của đoàn
                dtpFromDate.Format = DateTimePickerFormat.Custom;
                dtpFromDate.CustomFormat = "MM/yyyy";
                dtpFromDate.ShowUpDown = true;
                dtpFromDate.MinDate = new DateTime (_tourGroupBus.getMinDepartDate().Year, _tourGroupBus.getMinDepartDate().Month, 11);
                dtpFromDate.MaxDate = new DateTime(_tourGroupBus.getMaxDepartDate().Year, _tourGroupBus.getMinDepartDate().Month, 11);

                /*<--- To month --->*/
                // Tab: Doanh số của đoàn
                dtpToDate.Format = DateTimePickerFormat.Custom;
                dtpToDate.CustomFormat = "MM/yyyy";
                dtpToDate.ShowUpDown = true;
                dtpToDate.MinDate = dtpFromDate.Value.Date;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện click của button Báo cáo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTourGroupReport_Click(object sender, EventArgs e)
        {
            try
            {
                bdsTourGroupReport.DataSource = null;
                _revenueTotal.Clear();
                _costTotal.Clear();

                dgvTourGroupReport.Rows.Clear();
                dgvTourGroupReport.Refresh();

                if (_tourGroupName == null && cbbTourGroupList.SelectedIndex != 0)
                {
                    MessageBox.Show("Tên đoàn chưa đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnTourGroupReportPrint.Enabled = false;
                }

                //Chọn tất cả đoàn
                if (cbbTourGroupList.SelectedIndex == 0)
                {
                    foreach (var tourGroup in _tourGroupEntries)
                    {
                        if (tourGroup.depart_date.Year >= dtpFromDate.Value.Year && tourGroup.depart_date.Year <= dtpToDate.Value.Year)
                        {
                            if (tourGroup.depart_date.Year == dtpToDate.Value.Year)
                            {
                                if (tourGroup.depart_date.Month >= dtpFromDate.Value.Month && tourGroup.depart_date.Month <= dtpToDate.Value.Month)
                                {
                                    bdsTourGroupReport.Add(tourGroup);

                                    //Tổng danh thu từ tiền vé
                                    _revenueTotal.Add((float)tourGroup.Customers.Count * (float)tourGroup.Tour.TourPrice.price);

                                    //Tổng chi phí (cchi phí khách sạn + chi phí di chuyển)                                
                                    _costTotal.Add((float)tourGroup.Customers.Count * ((float)tourGroup.Tour.Destination.Hotels.Sum(hotel => hotel.price / 1000) + (float)tourGroup.TransportsTourGroups.Sum(t => t.fee / 1000)));

                                }
                            }
                            else
                            {
                                if (tourGroup.depart_date.Month >= dtpFromDate.Value.Month)
                                {
                                    bdsTourGroupReport.Add(tourGroup);

                                    //Tổng danh thu từ tiền vé
                                    _revenueTotal.Add((float)tourGroup.Customers.Count * (float)tourGroup.Tour.TourPrice.price);

                                    //Tổng chi phí (cchi phí khách sạn + chi phí di chuyển)                                
                                    _costTotal.Add((float)tourGroup.Customers.Count * ((float)tourGroup.Tour.Destination.Hotels.Sum(hotel => hotel.price / 1000) + (float)tourGroup.TransportsTourGroups.Sum(t => t.fee / 1000)));
                                }
                            }
                            
                        }
                    }

                }
                else
                {
                    IEnumerable<TourGroup> _temp = _tourGroupBus.getAllTourGroupByName(_tourGroupName);
                    foreach (var tourGroup in _temp)
                    {
                        if (tourGroup.depart_date.Year >= dtpFromDate.Value.Year && tourGroup.depart_date.Year <= dtpToDate.Value.Year)
                        {
                            if (tourGroup.depart_date.Year == dtpToDate.Value.Year)
                            {
                                if (tourGroup.depart_date.Month >= dtpFromDate.Value.Month && tourGroup.depart_date.Month <= dtpToDate.Value.Month)
                                {
                                    bdsTourGroupReport.Add(tourGroup);

                                    //Tổng danh thu từ tiền vé
                                    _revenueTotal.Add((float)tourGroup.Customers.Count * (float)tourGroup.Tour.TourPrice.price);

                                    //Tổng chi phí (cchi phí khách sạn + chi phí di chuyển)                                
                                    _costTotal.Add((float)tourGroup.Customers.Count * ((float)tourGroup.Tour.Destination.Hotels.Sum(hotel => hotel.price / 1000) + (float)tourGroup.TransportsTourGroups.Sum(t => t.fee / 1000)));

                                }
                            }
                            else
                            {
                                if (tourGroup.depart_date.Month >= dtpFromDate.Value.Month)
                                {
                                    bdsTourGroupReport.Add(tourGroup);

                                    //Tổng danh thu từ tiền vé
                                    _revenueTotal.Add((float)tourGroup.Customers.Count * (float)tourGroup.Tour.TourPrice.price);

                                    //Tổng chi phí (cchi phí khách sạn + chi phí di chuyển)                                
                                    _costTotal.Add((float)tourGroup.Customers.Count * ((float)tourGroup.Tour.Destination.Hotels.Sum(hotel => hotel.price / 1000) + (float)tourGroup.TransportsTourGroups.Sum(t => t.fee / 1000)));
                                }
                            }
                        }
                    }
                }
                if (dgvTourGroupReport.RowCount == 0)
                {
                    btnTourGroupReportPrint.Enabled = false;
                }
                else
                {
                    btnTourGroupReportPrint.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dgvTourGroupReport.DataSource != null)
            {
                btnTourGroupReportPrint.Enabled = true;
            }
        }

        /// <summary>
        /// Button in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTourGroupReportPrint_Click(object sender, EventArgs e)
        {
            if (dgvTourGroupReport.Rows.Count > 0)
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printTourGroupReport;
                printDialog.UseEXDialog = true;

                if (DialogResult.OK == printDialog.ShowDialog())
                {
                    printTourGroupReport.DocumentName = "Báo cáo Doanh số của Đoàn";
                    printTourGroupReport.Print();
                    MessageBox.Show("In thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Không có dữ liệu để in", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


        }

        private void printTourGroupReport_BeginPrint(object sender, PrintEventArgs e)
        {
            try
            {
                _strFormat = new StringFormat();
                _strFormat.Alignment = StringAlignment.Near;
                _strFormat.LineAlignment = StringAlignment.Center;
                _strFormat.Trimming = StringTrimming.EllipsisCharacter;

                _columnCoor.Clear();
                _columnWidths.Clear();
                _cellHeight = 0;
                _count = 0;
                _firstPage = true;
                _newPage = true;

                _totalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dgvTourGroupReport.Columns)
                {
                    _totalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printTourGroupReport_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // Đặt lề trái
                int _leftMargin = e.MarginBounds.Left;
                //Đặt lề trên
                int _topMargin = e.MarginBounds.Top;
                // Thiết lập có cần nhiều trang để in hay không
                bool _needMorePagesToPrint = false;
                int _tmpWidth = 0;

                int _footerX = 0;
                int _footerY = 0;
                // Thiết lập độ dộng của các cell và độ cao của header để in trang đầu tiên
                if (_firstPage)
                {
                    foreach (DataGridViewColumn GridCol in dgvTourGroupReport.Columns)
                    {
                        _tmpWidth = (int)(Math.Floor((double)((double)GridCol.Width / (double)_totalWidth * (double)_totalWidth * ((double)e.MarginBounds.Width / (double)_totalWidth))));

                        _headerHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText, new System.Drawing.Font("Constantia", 10), _tmpWidth).Height) + 23;

                        // Lưu độ rộng và độ cao của các header
                        _columnCoor.Add(_leftMargin);
                        _columnWidths.Add(_tmpWidth);
                        _leftMargin += _tmpWidth;
                    }
                }

                // Vòng lặp cho đến tất cả những trang chưa được in
                while (_count <= dgvTourGroupReport.Rows.Count - 1)
                {
                    DataGridViewRow _rows = dgvTourGroupReport.Rows[_count];
                    // Đặt độ cao của cell
                    _cellHeight = _rows.Height + 30;
                    int i = 0;

                    // Kiểm tra thiết lập trang xem còn nhiều dòng để in sang trang mới
                    if (_topMargin + _cellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        _newPage = true;
                        _firstPage = false;
                        _needMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (_newPage)
                        {
                            // Vẽ các header
                            e.Graphics.DrawString("BÁO CÁO DOANH SỐ CỦA ĐOÀN", new Font("Constantia", 20, FontStyle.Bold), Brushes.Black, new Point(200, 50));
                            e.Graphics.DrawString("Đoàn: " + cbbTourGroupList.SelectedItem.ToString(), new Font("Constantia", 12, FontStyle.Bold), Brushes.Black, new Point(100, 150));
                            e.Graphics.DrawString("Từ tháng: " + dtpFromDate.Value.ToString("MM/yyyy"), new Font("Constantia", 12, FontStyle.Bold), Brushes.Black, new Point(400, 150));
                            e.Graphics.DrawString("Đến tháng: " + dtpToDate.Value.ToString("MM/yyyy"), new Font("Constantia", 12, FontStyle.Bold), Brushes.Black, new Point(600, 150));

                            // Vẽ cột              
                            _topMargin = e.MarginBounds.Top + 80;
                            foreach (DataGridViewColumn column in dgvTourGroupReport.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new System.Drawing.Rectangle((int)_columnCoor[i], _topMargin, (int)_columnWidths[i], _headerHeight));

                                e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle((int)_columnCoor[i], _topMargin, (int)_columnWidths[i], _headerHeight));

                                e.Graphics.DrawString(column.HeaderText, new System.Drawing.Font("Constantia", 10), new SolidBrush(column.InheritedStyle.ForeColor), new RectangleF((int)_columnCoor[i], _topMargin,
                                    (int)_columnWidths[i], _headerHeight), _strFormat);
                                i++;
                            }
                            _newPage = false;
                            _topMargin += _headerHeight;
                        }
                        i = 0;
                        // Vẽ nội dung của các cột          
                        foreach (DataGridViewCell cell in _rows.Cells)
                        {
 
                            if (cell.ColumnIndex == 1 || cell.ColumnIndex == 2 || cell.ColumnIndex == 4 || cell.ColumnIndex == 5)
                            {
                                if (cell.Value != null)
                                {

                                    e.Graphics.DrawString(cell.Value.ToString(), new System.Drawing.Font("Constantia", 7), new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((int)_columnCoor[i], (float)_topMargin,
                                            (int)_columnWidths[i], (float)_cellHeight), _strFormat);
                                }
                                
                            }
                            else
                            {
               
                                e.Graphics.DrawString(cell.FormattedValue.ToString(), new System.Drawing.Font("Constantia", 7), new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((int)_columnCoor[i], (float)_topMargin,
                                            (int)_columnWidths[i], (float)_cellHeight), _strFormat);
                            }
                            // Vẽ đường viền 
                            e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle((int)_columnCoor[i],
                                    _topMargin, (int)_columnWidths[i], _cellHeight));

                            _footerX = (int)_columnCoor[i];
                            i++;
                            
                        }
                    }

                    _count++;
                    _topMargin += _cellHeight;

                    _footerY = _topMargin;

                }

                ////Footer
                e.Graphics.DrawString("TP.HCM, " + DateTime.Now.Date.ToString("dd/MM/yyyy"), new Font("Constantia", 10, FontStyle.Bold), Brushes.Black, new Point(_footerX - 70, _topMargin + 20));
                e.Graphics.DrawString("Người lập ", new Font("Constantia", 10, FontStyle.Bold), Brushes.Black, new Point(_footerX - 50, _topMargin + 50));
                e.Graphics.DrawString("(Ký, ghi rõ họ tên)", new Font("Constantia", 10), Brushes.Black, new Point(_footerX - 70, _topMargin + 80));

                // Nếu không đủ để in các dòng trên 1 trang, thì in sang trang khác
                if (_needMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void dgvTourGroupReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    e.Value = e.RowIndex + 1;
                }
                if (e.Value == null)
                {
                    return;
                }
                if (e.ColumnIndex == 3)
                {
                    e.Value = (e.Value as Tour).name;
                }
                if (e.ColumnIndex == 6)
                {
                    e.Value = _revenueTotal[e.RowIndex];
                }
                if (e.ColumnIndex == 7)
                {
                    e.Value = _costTotal[e.RowIndex];
                }
                if (e.ColumnIndex == 8)
                {
                    e.Value = _revenueTotal[e.RowIndex] - _costTotal[e.RowIndex]; //Lợi nhuận
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        #endregion

        #region Tab2: Doanh số của tour

        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Load danh sách tour hiện có
        /// </summary>
        private void cbbTourList_Load()
        {
            cbbTourList.Items.Add("--- Chọn tất cả ----");
            foreach (var tour in _tourEntries)
            {
                cbbTourList.Items.Add(tour.name);
            }
        }

        /// <summary>
        /// Combobox Tour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbTourList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Chọn tất cả tour
                if (cbbTourList.SelectedIndex == 0)
                {
                    btnTourReport.Enabled = true;
                }
                else
                {
                    btnTourReport.Enabled = true;
                    _tourName = cbbTourList.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void dateTimeCustom2()
        {
            try
            {
                dtpFromDate2.Format = DateTimePickerFormat.Custom;
                dtpFromDate2.CustomFormat = "MM/yyyy";
                dtpFromDate2.ShowUpDown = true;
                dtpFromDate2.MinDate = new DateTime(_tourPriceBus.getMinStartDate().Year, _tourPriceBus.getMinStartDate().Month, 11);
                dtpFromDate2.MaxDate = new DateTime(_tourPriceBus.getMaxStartDate().Year, _tourPriceBus.getMaxStartDate().Month, 11);

                dtpToDate2.Format = DateTimePickerFormat.Custom;
                dtpToDate2.CustomFormat = "MM/yyyy";
                dtpToDate2.ShowUpDown = true;
                dtpToDate2.MinDate = dtpFromDate2.Value.Date;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button Báo cáo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTourReport_Click(object sender, EventArgs e)
        {
            try
            {
                bdsTourReport.DataSource = null;
                _tourGroupTotal.Clear();
                _revenueTourTotal.Clear();
                _costTourTotal.Clear();

                dgvTourReport.Rows.Clear();
                dgvTourReport.Refresh();

                if (_tourName == null && cbbTourList.SelectedIndex != 0)
                {
                    MessageBox.Show("Tên Tour chưa đúng! Vui lòng chọn lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Chọn tất cả
                if (cbbTourList.SelectedIndex == 0)
                {
                    foreach (var tour in _tourEntries)
                    {
                        if (tour.TourPrice.start_date.Year >= dtpFromDate2.Value.Year && tour.TourPrice.start_date.Year <= dtpToDate2.Value.Year)
                        {
                            if (tour.TourPrice.start_date.Year == dtpToDate2.Value.Year)
                            {
                                if (tour.TourPrice.start_date.Month >= dtpFromDate2.Value.Month && tour.TourPrice.start_date.Month <= dtpToDate2.Value.Month)
                                {
                                    bdsTourReport.Add(tour);

                                    //Tổng số đoàn của 1 tour
                                    _tourGroupTotal.Add(tour.TourGroups.Count);

                                    //Tổng doanh thu của 1 tour từ tiền vé
                                    _revenueTourTotal.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * (float)tour.TourPrice.price);

                                    //Tổng chi phí
                                    _costTourTotal.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * ((float)tour.Destination.Hotels.Sum(ht => ht.price / 1000) + (float)tour.TourGroups.Sum(tg => tg.TransportsTourGroups.Sum(tp => tp.fee / 1000))));

                                }
                            }
                            else
                            {
                                if (tour.TourPrice.start_date.Month >= dtpFromDate2.Value.Month)
                                {
                                    bdsTourReport.Add(tour);

                                    //Tổng số đoàn của 1 tour
                                    _tourGroupTotal.Add(tour.TourGroups.Count);

                                    //Tổng doanh thu của 1 tour từ tiền vé
                                    _revenueTourTotal.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * (float)tour.TourPrice.price);

                                    //Tổng chi phí
                                    _costTourTotal.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * ((float)tour.Destination.Hotels.Sum(ht => ht.price / 1000) + (float)tour.TourGroups.Sum(tg => tg.TransportsTourGroups.Sum(tp => tp.fee / 1000))));

                                }
                            }
                            
                        }
                    }
                }
                else
                {
                    IEnumerable<Tour> _tourTemp = _tourBus.getAllTourByName(_tourName);
                    foreach (var tour in _tourTemp)
                    {
                        if (tour.TourPrice.start_date.Year >= dtpFromDate2.Value.Year && tour.TourPrice.start_date.Year <= dtpToDate2.Value.Year)
                        {
                            if (tour.TourPrice.start_date.Year == dtpToDate2.Value.Year)
                            {
                                if (tour.TourPrice.start_date.Month >= dtpFromDate2.Value.Month && tour.TourPrice.start_date.Month <= dtpToDate2.Value.Month)
                                {
                                    bdsTourReport.Add(tour);

                                    //Tổng số đoàn của 1 tour
                                    _tourGroupTotal.Add(tour.TourGroups.Count);

                                    //Tổng doanh thu của 1 tour từ tiền vé
                                    _revenueTourTotal.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * (float)tour.TourPrice.price);

                                    //Tổng chi phí
                                    _costTourTotal.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * ((float)tour.Destination.Hotels.Sum(ht => ht.price / 1000) + (float)tour.TourGroups.Sum(tg => tg.TransportsTourGroups.Sum(tp => tp.fee / 1000))));

                                }
                            }
                            else
                            {
                                if (tour.TourPrice.start_date.Month >= dtpFromDate2.Value.Month)
                                {
                                    bdsTourReport.Add(tour);

                                    //Tổng số đoàn của 1 tour
                                    _tourGroupTotal.Add(tour.TourGroups.Count);

                                    //Tổng doanh thu của 1 tour từ tiền vé
                                    _revenueTourTotal.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * (float)tour.TourPrice.price);

                                    //Tổng chi phí
                                    _costTourTotal.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * ((float)tour.Destination.Hotels.Sum(ht => ht.price / 1000) + (float)tour.TourGroups.Sum(tg => tg.TransportsTourGroups.Sum(tp => tp.fee / 1000))));

                                }
                            }
                        }
                    }
                }

                if (dgvTourReport.RowCount == 0)
                {
                    btnTourReportPrint.Enabled = false;
                }
                else
                {
                    btnTourReportPrint.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTourReportPrint_Click(object sender, EventArgs e)
        {
            if (dgvTourReport.Rows.Count > 0)
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printTourReport;
                printDialog.UseEXDialog = true;

                if (DialogResult.OK == printDialog.ShowDialog())
                {
                    printTourReport.DocumentName = "Báo cáo Doanh số của Tour";
                    printTourReport.Print();
                    MessageBox.Show("In thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Không có dữ liệu để in", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void printTourReport_BeginPrint(object sender, PrintEventArgs e)
        {
            try
            {
                _strFormat = new StringFormat();
                _strFormat.Alignment = StringAlignment.Near;
                _strFormat.LineAlignment = StringAlignment.Center;
                _strFormat.Trimming = StringTrimming.EllipsisCharacter;

                _columnCoor.Clear();
                _columnWidths.Clear();
                _cellHeight = 0;
                _count = 0;
                _firstPage = true;
                _newPage = true;

                _totalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dgvTourReport.Columns)
                {
                    _totalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printTourReport_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // Đặt lề trái
                int _leftMargin = e.MarginBounds.Left;
                //Đặt lề trên
                int _topMargin = e.MarginBounds.Top;
                // Thiết lập có cần nhiều trang để in hay không
                bool _needMorePagesToPrint = false;
                int _tmpWidth = 0;

                int _footerX = 0;
                int _footerY = 0;
                // Thiết lập độ dộng của các cell và độ cao của header để in trang đầu tiên
                if (_firstPage)
                {
                    foreach (DataGridViewColumn GridCol in dgvTourReport.Columns)
                    {
                        _tmpWidth = (int)(Math.Floor((double)((double)GridCol.Width / (double)_totalWidth * (double)_totalWidth * ((double)e.MarginBounds.Width / (double)_totalWidth))));

                        _headerHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText, new System.Drawing.Font("Constantia", 10), _tmpWidth).Height) + 23;

                        // Lưu độ rộng và độ cao của các header
                        _columnCoor.Add(_leftMargin);
                        _columnWidths.Add(_tmpWidth);
                        _leftMargin += _tmpWidth;
                    }
                }

                // Vòng lặp cho đến tất cả những trang chưa được in
                while (_count <= dgvTourReport.Rows.Count - 1)
                {
                    DataGridViewRow _rows = dgvTourReport.Rows[_count];
                    // Đặt độ cao của cell
                    _cellHeight = _rows.Height + 30;
                    int i = 0;

                    // Kiểm tra thiết lập trang xem còn nhiều dòng để in sang trang mới
                    if (_topMargin + _cellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        _newPage = true;
                        _firstPage = false;
                        _needMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (_newPage)
                        {
                            // Vẽ các header
                            e.Graphics.DrawString("BÁO CÁO DOANH SỐ CỦA TOUR", new Font("Constantia", 20, FontStyle.Bold), Brushes.Black, new Point(200, 50));
                            e.Graphics.DrawString("Tour: " + cbbTourList.SelectedItem.ToString(), new Font("Constantia", 12, FontStyle.Bold), Brushes.Black, new Point(100, 120));
                            e.Graphics.DrawString("Từ tháng: " + dtpFromDate2.Value.ToString("MM/yyyy"), new Font("Constantia", 12, FontStyle.Bold), Brushes.Black, new Point(100, 150));
                            e.Graphics.DrawString("Đến tháng: " + dtpToDate2.Value.ToString("MM/yyyy"), new Font("Constantia", 12, FontStyle.Bold), Brushes.Black, new Point(500, 150));

                            // Vẽ cột              
                            _topMargin = e.MarginBounds.Top + 80;
                            foreach (DataGridViewColumn column in dgvTourReport.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new System.Drawing.Rectangle((int)_columnCoor[i], _topMargin, (int)_columnWidths[i], _headerHeight));

                                e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle((int)_columnCoor[i], _topMargin, (int)_columnWidths[i], _headerHeight));

                                e.Graphics.DrawString(column.HeaderText, new System.Drawing.Font("Constantia", 10), new SolidBrush(column.InheritedStyle.ForeColor), new RectangleF((int)_columnCoor[i], _topMargin,
                                    (int)_columnWidths[i], _headerHeight), _strFormat);
                                i++;
                            }
                            _newPage = false;
                            _topMargin += _headerHeight;
                        }
                        i = 0;
                        // Vẽ nội dung của các cột          
                        foreach (DataGridViewCell cell in _rows.Cells)
                        {

                            if (cell.ColumnIndex == 1 || cell.ColumnIndex == 2)
                            {
                                if (cell.Value != null)
                                {

                                    e.Graphics.DrawString(cell.Value.ToString(), new System.Drawing.Font("Constantia", 7), new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((int)_columnCoor[i], (float)_topMargin,
                                            (int)_columnWidths[i], (float)_cellHeight), _strFormat);
                                }

                            }
                            else
                            {

                                e.Graphics.DrawString(cell.FormattedValue.ToString(), new System.Drawing.Font("Constantia", 7), new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((int)_columnCoor[i], (float)_topMargin,
                                            (int)_columnWidths[i], (float)_cellHeight), _strFormat);
                            }
                            // Vẽ đường viền 
                            e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle((int)_columnCoor[i],
                                    _topMargin, (int)_columnWidths[i], _cellHeight));

                            _footerX = (int)_columnCoor[i];
                            i++;

                        }
                    }

                    _count++;
                    _topMargin += _cellHeight;

                    _footerY = _topMargin;

                }

                ////Footer
                e.Graphics.DrawString("TP.HCM, " + DateTime.Now.Date.ToString("dd/MM/yyyy"), new Font("Constantia", 10, FontStyle.Bold), Brushes.Black, new Point(_footerX - 70, _topMargin + 20));
                e.Graphics.DrawString("Người lập ", new Font("Constantia", 10, FontStyle.Bold), Brushes.Black, new Point(_footerX - 50, _topMargin + 50));
                e.Graphics.DrawString("(Ký, ghi rõ họ tên)", new Font("Constantia", 10), Brushes.Black, new Point(_footerX - 70, _topMargin + 80));

                // Nếu không đủ để in các dòng trên 1 trang, thì in sang trang khác
                if (_needMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTourReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    e.Value = e.RowIndex + 1;
                }
                if (e.Value == null)
                {
                    return;
                }
                if (e.ColumnIndex == 3)
                {
                    e.Value = (e.Value as TourPrice).start_date.ToShortDateString();
                }
                if (e.ColumnIndex == 4)
                {
                    e.Value = (e.Value as TourPrice).end_date.ToShortDateString();
                }
                if (e.ColumnIndex == 5)
                {
                    e.Value = _tourGroupTotal[e.RowIndex];
                }
                if (e.ColumnIndex == 6)
                {
                    e.Value = _revenueTourTotal[e.RowIndex];
                }
                if (e.ColumnIndex == 7)
                {
                    e.Value = _costTourTotal[e.RowIndex];
                }
                if (e.ColumnIndex == 8)
                {
                    e.Value = _revenueTourTotal[e.RowIndex] - _costTourTotal[e.RowIndex];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Tab 3: Tình hình hoạt động của các Tour
        private void btnBack3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbTourStatusReport_Load()
        {
            cbbTourStatusReport.Items.Add("--- Chọn tất cả ---");
            foreach (var tour in _tourEntries)
            {
                cbbTourStatusReport.Items.Add(tour.name);
            }
        }

        private void cbbTourStatusReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Chọn tất cả tour
                if (cbbTourStatusReport.SelectedIndex == 0)
                {
                    btnTourStatusReport.Enabled = true;

                }
                else
                {
                    btnTourStatusReport.Enabled = true;
                    _tourNameTab3 = cbbTourStatusReport.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button báo cáo của Tab Tình hình hoạt động của các Tour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTourStatusReport_Click(object sender, EventArgs e)
        {
            try
            {
                bdsTourStatusReport.DataSource = null;

                _tourGroupTotalTab3.Clear();
                _revenueTourTotalTab3.Clear();
                _costTourTotalTab3.Clear();

                dgvTourStatusReport.Rows.Clear();
                dgvTourStatusReport.Refresh();

                if (_tourNameTab3 == null && cbbTourStatusReport.SelectedIndex != 0)
                {
                    MessageBox.Show("Tên Tour chưa đúng! Vui lòng chọn lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Chọn tất cả
                if (cbbTourStatusReport.SelectedIndex == 0)
                {
                    foreach (var tour in _tourEntries)
                    {
                        bdsTourStatusReport.Add(tour);

                        _tourGroupTotalTab3.Add(tour.TourGroups.Count);

                        //Tổng doanh thu của 1 tour từ tiền vé
                        _revenueTourTotalTab3.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * (float)tour.TourPrice.price);

                        //Tổng chi phí
                        //_costTourTotalTab3.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * ((float)tour.Destination.Hotels.Sum(ht => ht.price) + (float)tour.TourGroups.Sum(tg => tg.Transports.Sum(tp => tp.price))));
                        _costTourTotalTab3.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count /1000) * ((float)tour.Destination.Hotels.Sum(ht => ht.price) + (float)tour.TourGroups.Sum(tg => tg.TransportsTourGroups.Sum(tp => tp.fee/1000))));

                    }
                }
                else
                {
                    IEnumerable<Tour> _tourStatusTemp = _tourBus.getAllTourByName(_tourNameTab3);

                    foreach (var tour in _tourStatusTemp)
                    {
                        bdsTourStatusReport.Add(tour);

                        _tourGroupTotalTab3.Add(tour.TourGroups.Count);

                        //Tổng doanh thu của 1 tour từ tiền vé
                        _revenueTourTotalTab3.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * (float)tour.TourPrice.price);

                        //Tổng chi phí
                        //_costTourTotalTab3.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * ((float)tour.Destination.Hotels.Sum(ht => ht.price) + (float)tour.TourGroups.Sum(tg => tg.Transports.Sum(tp => tp.price))));
                        _costTourTotalTab3.Add((float)tour.TourGroups.Sum(tg => tg.Customers.Count) * ((float)tour.Destination.Hotels.Sum(ht => ht.price) + (float)tour.TourGroups.Sum(tg => tg.TransportsTourGroups.Sum(tp => tp.fee))));
                    
                    }
                }

                if (dgvTourStatusReport.RowCount == 0)
                {
                    btnTourStatusReportPrint.Enabled = false;
                }
                else
                {
                    btnTourStatusReportPrint.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTourStatusReportPrint_Click(object sender, EventArgs e)
        {
            if (dgvTourStatusReport.Rows.Count > 0)
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printTourStatusReport;
                printDialog.UseEXDialog = true;

                if (DialogResult.OK == printDialog.ShowDialog())
                {
                    printTourStatusReport.DocumentName = "Báo cáo Tình hình hoạt động của Tour";
                    printTourStatusReport.Print();
                    MessageBox.Show("In thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Không có dữ liệu để in", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void printTourStatusReport_BeginPrint(object sender, PrintEventArgs e)
        {
            try
            {
                _strFormat = new StringFormat();
                _strFormat.Alignment = StringAlignment.Near;
                _strFormat.LineAlignment = StringAlignment.Center;
                _strFormat.Trimming = StringTrimming.EllipsisCharacter;

                _columnCoor.Clear();
                _columnWidths.Clear();
                _cellHeight = 0;
                _count = 0;
                _firstPage = true;
                _newPage = true;

                _totalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dgvTourStatusReport.Columns)
                {
                    _totalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printTourStatusReport_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // Đặt lề trái
                int _leftMargin = e.MarginBounds.Left;
                //Đặt lề trên
                int _topMargin = e.MarginBounds.Top;
                // Thiết lập có cần nhiều trang để in hay không
                bool _needMorePagesToPrint = false;
                int _tmpWidth = 0;

                int _footerX = 0;
                int _footerY = 0;
                // Thiết lập độ dộng của các cell và độ cao của header để in trang đầu tiên
                if (_firstPage)
                {
                    foreach (DataGridViewColumn GridCol in dgvTourStatusReport.Columns)
                    {
                        _tmpWidth = (int)(Math.Floor((double)((double)GridCol.Width / (double)_totalWidth * (double)_totalWidth * ((double)e.MarginBounds.Width / (double)_totalWidth))));

                        _headerHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText, new System.Drawing.Font("Constantia", 10), _tmpWidth).Height) + 23;

                        // Lưu độ rộng và độ cao của các header
                        _columnCoor.Add(_leftMargin);
                        _columnWidths.Add(_tmpWidth);
                        _leftMargin += _tmpWidth;
                    }
                }

                // Vòng lặp cho đến tất cả những trang chưa được in
                while (_count <= dgvTourStatusReport.Rows.Count - 1)
                {
                    DataGridViewRow _rows = dgvTourStatusReport.Rows[_count];
                    // Đặt độ cao của cell
                    _cellHeight = _rows.Height + 30;
                    int i = 0;

                    // Kiểm tra thiết lập trang xem còn nhiều dòng để in sang trang mới
                    if (_topMargin + _cellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        _newPage = true;
                        _firstPage = false;
                        _needMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (_newPage)
                        {
                            // Vẽ các header
                            e.Graphics.DrawString("BÁO CÁO TÌNH HÌNH HOẠT ĐỘNG CỦA TOUR", new Font("Constantia", 20, FontStyle.Bold), Brushes.Black, new Point(100, 50));
                            e.Graphics.DrawString("Tour: " + cbbTourStatusReport.SelectedItem.ToString(), new Font("Constantia", 12, FontStyle.Bold), Brushes.Black, new Point(100, 140));
                            
                            // Vẽ cột              
                            _topMargin = e.MarginBounds.Top + 80;
                            foreach (DataGridViewColumn column in dgvTourStatusReport.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), new System.Drawing.Rectangle((int)_columnCoor[i], _topMargin, (int)_columnWidths[i], _headerHeight));

                                e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle((int)_columnCoor[i], _topMargin, (int)_columnWidths[i], _headerHeight));

                                e.Graphics.DrawString(column.HeaderText, new System.Drawing.Font("Constantia", 10), new SolidBrush(column.InheritedStyle.ForeColor), new RectangleF((int)_columnCoor[i], _topMargin,
                                    (int)_columnWidths[i], _headerHeight), _strFormat);
                                i++;
                            }
                            _newPage = false;
                            _topMargin += _headerHeight;
                        }
                        i = 0;
                        // Vẽ nội dung của các cột          
                        foreach (DataGridViewCell cell in _rows.Cells)
                        {

                            if (cell.ColumnIndex == 1 || cell.ColumnIndex == 2)
                            {
                                if (cell.Value != null)
                                {

                                    e.Graphics.DrawString(cell.Value.ToString(), new System.Drawing.Font("Constantia", 7), new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((int)_columnCoor[i], (float)_topMargin,
                                            (int)_columnWidths[i], (float)_cellHeight), _strFormat);
                                }

                            }
                            else
                            {

                                e.Graphics.DrawString(cell.FormattedValue.ToString(), new System.Drawing.Font("Constantia", 7), new SolidBrush(cell.InheritedStyle.ForeColor), new RectangleF((int)_columnCoor[i], (float)_topMargin,
                                            (int)_columnWidths[i], (float)_cellHeight), _strFormat);
                            }
                            // Vẽ đường viền 
                            e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle((int)_columnCoor[i],
                                    _topMargin, (int)_columnWidths[i], _cellHeight));

                            _footerX = (int)_columnCoor[i];
                            i++;

                        }
                    }

                    _count++;
                    _topMargin += _cellHeight;

                    _footerY = _topMargin;

                }

                ////Footer
                e.Graphics.DrawString("TP.HCM, " + DateTime.Now.Date.ToString("dd/MM/yyyy"), new Font("Constantia", 10, FontStyle.Bold), Brushes.Black, new Point(_footerX - 70, _topMargin + 20));
                e.Graphics.DrawString("Người lập ", new Font("Constantia", 10, FontStyle.Bold), Brushes.Black, new Point(_footerX - 50, _topMargin + 50));
                e.Graphics.DrawString("(Ký, ghi rõ họ tên)", new Font("Constantia", 10), Brushes.Black, new Point(_footerX - 70, _topMargin + 80));

                // Nếu không đủ để in các dòng trên 1 trang, thì in sang trang khác
                if (_needMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTourStatusReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    e.Value = e.RowIndex + 1;
                }
                if (e.Value == null)
                {
                    return;
                }
                if (e.ColumnIndex == 3)
                {
                    e.Value = (e.Value as TourCategory).name;
                }
                if (e.ColumnIndex == 4)
                {
                    e.Value = (e.Value as TourPrice).start_date.ToShortDateString();
                }
                if (e.ColumnIndex == 5)
                {
                    e.Value = (e.Value as TourPrice).end_date.ToShortDateString();
                }
                if (e.ColumnIndex == 6)
                {
                    e.Value = _tourGroupTotalTab3[e.RowIndex];
                }
                if (e.ColumnIndex == 7)
                {
                    e.Value = _revenueTourTotalTab3[e.RowIndex] - _costTourTotalTab3[e.RowIndex];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        #endregion

        
    }
}
