using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntity;
using BusinessEntity.SearchEngine;
using DTO;
using QuanLyTourDuLich.Views;
using QuanLyTourDuLich.Presenters;

namespace QuanLyTourDuLich.GUI
{

    public partial class fmSearch : Form, ICustomerSearchView, ITourSearchView, ITourGroupSearchView, ITransportView
    {

        ICustomerSearchPresenter _customerSearchpresenter;
        ITourSearchPresenter _tourSearchpresenter;

        TourCategoryBUS _bus;
        IEnumerable<TourCategory> _entry;

        DestinationBUS _destinationBus;
        IEnumerable<Destination> _detinations;

        TourPriceBUS _tourPriceBus;
        IEnumerable<TourPrice> _tourPrices;

        float _minPrice;
        float _maxPrice;

        ITourGroupSearchPresenter _tourGroupSearchPresenter;
        ITransportPresenter _transportPresenter;



        public fmSearch()
        {
            InitializeComponent();
            postInit();
            _customerSearchpresenter = new CustomerSearchPresenter(this);
            _tourSearchpresenter = new TourSearchPresenter(this);
            
            _bus = new TourCategoryBUS();
            _entry = _bus.getEntries();

            _destinationBus = new DestinationBUS();
            _detinations = _destinationBus.getEntries();

            _tourPriceBus = new TourPriceBUS();
            _tourPrices = _tourPriceBus.getEntries();
            _minPrice = _tourPriceBus.getMinPrice();
            _maxPrice = _tourPriceBus.getMaxPrice();

            _transportPresenter = new TransportPresenter(this);
            _tourGroupSearchPresenter = new TourGroupSearchPresenter(this);

        }

        private void postInit()
        {
            _tourCategoryClb.DataSource = _tourCategoryBs;
            _destinationClb.DataSource = _destinationBs;
          //  _transportClb.DataSource = _transportBs;                // todo
        }

        private void fmSearch_Load(object sender, EventArgs e)
        {
            _tourCategoryBs.DataSource = _entry;
            _tourCategoryClb.DisplayMember = "name";

            _destinationBs.DataSource = _detinations;
            _destinationClb.DisplayMember = "city";

            _minPriceUD.Value = (decimal)_minPrice;
            _maxPriceUD.Value = (decimal)_maxPrice + 1;

            _transportPresenter.loadAllActiveTransports();

            _tourGroupSearchPresenter.loadMinDepartDate();
            _tourGroupSearchPresenter.loadMaxReturnDate();

            _countriesBs.DataSource = GlobalCountries.getAllCCountries();
            _countriesCb.DisplayMember = "name";

            _customerSearchpresenter.loadAllCustomer();
            setEnableSaveBtn(false);

            //_startDtp.Value = _minDepartDate;           // todo
            //_endDtp.Value = _maxReturnDate;             // todo
        }

        private void btnTroLai1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTroLai2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Tab Customer
        // Customer
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string keyword = _keywordTb.Text.Trim();
            _customerSearchpresenter.performClickSearch(keyword);
        }

        private void _resultGvCustomer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (_resultGv.Columns[e.ColumnIndex].HeaderText == "STT")
            {
                e.Value = e.RowIndex + 1;
            }
            if (_resultGv.Columns[e.ColumnIndex].HeaderText == "Giới tính")
            {
                if (e.Value != null)
                    e.Value = ((Gender)e.Value).name;
            }
            if (_resultGv.Columns[e.ColumnIndex].HeaderText == "Người nước ngoài")
            {
                if (e.Value == null)
                    e.Value = false;
            }
        }

        /// <summary>
        ///  implement ICustomerSearchView
        /// </summary>
        /// <param name="searchResult"> Kết quả search trả về từ presenter</param>
        public void updateSearchResultView(IEnumerable<Customer> searchResult)
        {
            _searchReultBs.DataSource = searchResult;
        }

        /// <summary>
        /// Sort Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _resultGv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.ColumnIndex == 1)
                _customerSearchpresenter.sortIdColumn();
            else if (e.ColumnIndex == 2)
                _customerSearchpresenter.sortNameColumn();
            else if (e.ColumnIndex == 3)
                _customerSearchpresenter.sortAddressColumn();
            else if (e.ColumnIndex == 4)
                _customerSearchpresenter.sortPhoneColumn();
            else if (e.ColumnIndex == 5)
                _customerSearchpresenter.sortGenderColumn();
        }
        #endregion Tab Customer

        #region Tab Tour Group

        private void _startDtp_ValueChanged(object sender, EventArgs e)
        {
            //var mindate = _startDtp.Value;
            //var maxdate = _endDtp.Value;
           // _tourGroupSearchPresenter.filterDate(new DateTime[] { mindate, maxdate });
        }

        private void _endDtp_ValueChanged(object sender, EventArgs e)
        {
            //var mindate = _startDtp.Value;
            //var maxdate = _endDtp.Value;
            //_tourGroupSearchPresenter.filterDate(new DateTime[] { mindate, maxdate });
        }

        public void updateMinDepartDate(DateTime minValue)
        {
            // _startDtp.Value = minValue;
        }

        public void udpateMaxReturnDate(DateTime minValue)
        {
            //_endDtp.Value = minValue;
        }

        public void upateTransportsView(IEnumerable<Transport> transports)
        {
            _transportBs.DataSource = transports;
           // _transportClb.DisplayMember = "name";       // todo

        }

        private void _transportClb_SelectedIndexChanged(object sender, EventArgs e)
        {
           // var selected = _transportClb.CheckedItems.Cast<Transport>();
         //   _tourGroupSearchPresenter.filterTransport(selected);
        }

        private void _tourGroupKeywordTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this.handleSearchTourGroupClick(_tourGroupKeywordTb.Text);
        }

        private void tourGroupSearchBtn_Click(object sender, EventArgs e)
        {
           // var keyword = _tourGroupKeywordTb.Text.Trim();
           // this.handleSearchTourGroupClick(keyword);
        }

        private void _tourGroupGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var senderGrid = sender as DataGridView;
            if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                if (e.ColumnIndex == 7)
                {
                    // ds nhân viên
                }
                if (e.ColumnIndex == 8)
                {
                    // ds phương tiện
                }
            }
        }

        private void _tourGroupGv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
            if (e.Value == null)
                return;
            if (e.ColumnIndex == 3)
            {
                e.Value = (e.Value as Tour).name;
            }
            if (e.ColumnIndex == 6)
            {
                if (e.Value == null)
                    e.Value = 0;
                else
                    e.Value = (e.Value as IEnumerable<Customer>).Count().ToString();
            }
        }

        private void _tourGroupGv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
                _tourGroupSearchPresenter.sortByTourGrouId();
            else if (e.ColumnIndex == 2)
                _tourGroupSearchPresenter.sortByTourGroupName();
            else if (e.ColumnIndex == 3)
                _tourGroupSearchPresenter.sortByTourName();
            else if (e.ColumnIndex == 4)
                _tourGroupSearchPresenter.sortByDepartDate();
            else if (e.ColumnIndex == 5)
                _tourGroupSearchPresenter.sortByReturnDate();
            else if (e.ColumnIndex == 6)
                _tourGroupSearchPresenter.sortByEmployees();

        }

        public void handleSearchTourGroupClick(string keyword)
        {
            _tourGroupSearchPresenter.handleSearchClick(keyword);
        }

        public void updateSearchResult(IEnumerable<TourGroup> searchResult)
        {
            _tourGroupBs.DataSource = searchResult;
        }
        #endregion

        public void handleSearchTourClick(string keyword)
        {
            _tourSearchpresenter.handleSearchClick(keyword);
        }

        public void updateSearchResult(IEnumerable<Tour> searchResult)
        {
            _tourBs.DataSource = searchResult;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
            else
            {
                if (e.Value == null)
                    return;
            }
            if (e.ColumnIndex == 3)
            {
                e.Value = (e.Value as TourCategory).name;
            }
            if (e.ColumnIndex == 4)
            {
                e.Value = (e.Value as TourPrice).price.ToString().Trim();
            }
            if (e.ColumnIndex == 5)
            {
                e.Value = (e.Value as Destination).name;
            }
            if (e.ColumnIndex == 6)
            {
                e.Value = (e.Value as Destination).city;
            }
        }

        private void tourSearchBtn_Click(object sender, EventArgs e)
        {
            this.handleSearchTourClick(_searchTourTb.Text.Trim());
        }

        private void _tourCategoryClb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = _tourCategoryClb.CheckedItems.Cast<TourCategory>();
            _tourSearchpresenter.filterTourCategoryChange(selected);
        }

        private void _destinationClb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = _destinationClb.CheckedItems.Cast<Destination>();
            _tourSearchpresenter.filterTourCityChange(selected);
        }

        private void _minPriceUD_ValueChanged(object sender, EventArgs e)
        {
            int[] priceRange = new int[2];
            priceRange[0] = (int)_minPriceUD.Value;
            priceRange[1] = (int)_maxPriceUD.Value;
            _tourSearchpresenter.filterTourPriceChange(priceRange);
        }

        private void _maxPriceUD_ValueChanged(object sender, EventArgs e)
        {
            int[] priceRange = new int[2];
            priceRange[0] = (int)_minPriceUD.Value;
            priceRange[1] = (int)_maxPriceUD.Value;
            _tourSearchpresenter.filterTourPriceChange(priceRange);
        }

        private void _searchTourTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.handleSearchTourClick(_searchTourTb.Text.Trim());
        }

        private void _keywordTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            _customerSearchpresenter.performClickSearch(_keywordTb.Text.Trim());
        }

        private void _tourOptionContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
                _tourSearchpresenter.sortByTourId();
            else if (e.ColumnIndex == 2)
                _tourSearchpresenter.sortByTourName();
            else if (e.ColumnIndex == 3)
                _tourSearchpresenter.sortByTourCategory();
            else if (e.ColumnIndex == 4)
                _tourSearchpresenter.sortByPrice();
            else if (e.ColumnIndex == 5)
                _tourSearchpresenter.sortByDestination();
            else if (e.ColumnIndex == 6)
                _tourSearchpresenter.sortByCity();
        }


        #region Insert

        private void flowLayoutPanel1_Layout(object sender, LayoutEventArgs e)
        {
            var isenable = isAcceptBtnEnabled();
            _acceptBtn.Enabled = isenable;
            _cancelBtn.Enabled = isenable;
        }

        private bool isAcceptBtnEnabled()
        {
            if (String.IsNullOrWhiteSpace(_customerNameTb.Text))
                return false;
            if (String.IsNullOrWhiteSpace(_addressTb.Text))
                return false;
            if (String.IsNullOrWhiteSpace(_phoneTb.Text))
                return false;
            if (String.IsNullOrWhiteSpace(_identifiedTb.Text))
                return false;
            if (String.IsNullOrWhiteSpace(_countriesCb.Text))
                return false;
            return true;

        }

        private void _acceptBtn_Click(object sender, EventArgs e)
        {
            var customer = buildCustomer();

            _customerSearchpresenter.insertCustomer(customer);

            _customerSearchpresenter.performClickSearch(_keywordTb.Text.Trim());
            this.clearCustomerInfo();
        }

        private Customer buildCustomer()
        {
            var customer = new Customer();
            customer.name = _customerNameTb.Text.Trim();
            customer.address = _addressTb.Text.Trim();
            customer.phone = _phoneTb.Text.Trim();
            customer.nationality = _countriesCb.Text.Trim();
            customer.identifiedcard_id = _identifiedTb.Text.Trim();
            if (_femaleRb.Checked)
                customer.gender = 1;        // hard code tạm cho nhanh
            else if (_maleRb.Checked)
                customer.gender = 2;
            else
                customer.gender = 3;
            customer.isforeign = _isForeignCb.Checked;
            return customer;
        }

        private void _customerNameTb_TextChanged(object sender, EventArgs e)
        {
            var isenable = isAcceptBtnEnabled();
            _acceptBtn.Enabled = isenable;
            _cancelBtn.Enabled = isenable;
        }

        private void _cancelBtn_Click(object sender, EventArgs e)
        {
            this.clearCustomerInfo();
        }

        private void clearCustomerInfo()
        {
            _customerNameTb.Clear();
            _addressTb.Clear();
            _phoneTb.Clear();
            _identifiedTb.Clear();
            _countriesCb.SelectedIndex = 0;

        }

        #endregion // Insert

        #region Delete

        private void deleteBtn_EnabledChanged(object sender, EventArgs e)
        {
            if ((sender as Button).Enabled == false)
                (sender as Button).ImageIndex = 1;
            else
                (sender as Button).ImageIndex = 0;

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (_resultGv.SelectedRows.Count == 0)
                return;
            int selectedindex = _resultGv.SelectedRows[0].Index;
            var customer = (_searchReultBs.DataSource as IEnumerable<Customer>).ElementAt(selectedindex);

            _customerSearchpresenter.deleteCustomer(customer);

        }

        public void deleteError(Customer customer)
        {
            string msg = "Khách hàng không thể xoá khi đã có tham gia tour.\nTên khách hàng: {0}\n Số đoàn: {1}";
            msg = String.Format(msg, customer.name, customer.TourGroups.Count.ToString());
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Delete


        #region Edit

        private void _resultGv_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void _resultGv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            setEnableSaveBtn(true);
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _customerSearchpresenter.updateAll(_searchReultBs.DataSource as IEnumerable<Customer>);
            Cursor.Current = Cursors.Default;
            setEnableSaveBtn(false);
        }

        private void setEnableSaveBtn(bool isenabled)
        {
            saveBtn.Enabled = isenabled;
            discardBtn.Enabled = isenabled;
        }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _customerSearchpresenter.refresh();
            _customerSearchpresenter.loadAllCustomer();
            Cursor.Current = Cursors.Default;
            this.setEnableSaveBtn(false);
        }


        #endregion // Edit

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
