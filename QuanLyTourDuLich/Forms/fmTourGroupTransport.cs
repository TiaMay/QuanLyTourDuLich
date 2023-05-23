using BusinessEntity;
using DTO;
using QuanLyTourDuLich.Presenters;
using QuanLyTourDuLich.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTourDuLich
{
    public partial class fmTourGroupTransport : Form, ITransportView
    {
        int _tourgroupId;

        ITransportPresenter _presenter;

        TourGroup _tourGroup;

        private static float _transportInterestRate;

        public fmTourGroupTransport(int tourgroupid)
        {
            InitializeComponent();
            _tourgroupId = tourgroupid;
            _presenter = new TransportPresenter(this);
           // _transportInterestRate = new ConstantBUS().getFloat("transport_interest_rate");

        }

        private void fmTourGroupTransport_Load(object sender, EventArgs e)
        {
            _tourGroup = _presenter.loadTourGroupById(_tourgroupId);

            _tourGroupNameLb.DataBindings.Add("Text", _tourGroup, "name");
            _tourNameLb.DataBindings.Add("Text", _tourGroup.Tour, "name");
            _departDateLb.DataBindings.Add("Text", _tourGroup, "depart_date");
            _returnDateLb.DataBindings.Add("Text", _tourGroup, "return_date");

            this.search();

        }

        private void search()
        {
            _presenter.search(_searchTb.Text.Trim());
        }

        public void upateTransportsView(IEnumerable<Transport> transports)
        {
            var isChecked = (_showStateCb as CheckBox).Checked;
            if (isChecked == true)
            {
                transports = transports.Where(t =>
                    t.TransportsTourGroups.Any(group => group.tour_group_id == _tourGroup.id));
            }
            //if (isChecked == true)
            //    transports = transports.Where(trans => trans.TourGroups.Any(t => t.id == _tourGroup.id));
            _transportBindingSource.DataSource = transports;
            _countLb.Text = transports.Count().ToString();
            //if (_totalFeeTb.Enabled == false)
            //    _totalFeeTb.Text = _presenter.getTotalTransportFee(_tourGroup.id).ToString();
            _resultGv.ClearSelection();
            _totalFeeTb.Text = _presenter.loadTotalTransportFee(_tourGroup.id).ToString();

        }

        private void _resultGv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (_resultGv.Columns[e.ColumnIndex].HeaderText == "STT")
            {
                e.Value = e.RowIndex + 1;

            }
            if (_resultGv.Columns[e.ColumnIndex].HeaderText == "Chi phí tạm tính (nghìn đồng)")
            {

                //var value = Math.Round((double)e.Value * (1 + _transportInterestRate));
                var transports = _transportBindingSource.DataSource as IEnumerable<Transport>;
                if (transports.Count() <= e.RowIndex)
                    return;   // i dont know why. just fix some fucking crash
                var trans = transports.ElementAt(e.RowIndex);
                var fee = Math.Round(_presenter.getTransportTourGroupFee(_tourGroup.id, trans.id));
                if (fee == 0.0)
                {
                    _resultGv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    _resultGv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(51, 255, 102);
                }
                e.Value = fee;

            }
            if (e.Value == null)
                return;
            if (_resultGv.Columns[e.ColumnIndex].HeaderText == "Ghi chú")
            {
                if (e.Value != null)
                    e.Value = (e.Value as Status).name;
            }

        }

        private void _resultGv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var transport = (_transportBindingSource.DataSource as IEnumerable<Transport>).ElementAt(e.RowIndex);
            _presenter.toggleTransportTourGroupStatus(transport, _tourGroup);
            this.search();
        }

        private void addAllBtn_Click(object sender, EventArgs e)
        {
            var selectedtransports = _resultGv.SelectedRows;
            int selectedIndex;
            Transport transport = null;
            foreach (var row in selectedtransports)
            {
                selectedIndex = (row as DataGridViewBand).Index;
                transport = (_transportBindingSource.DataSource as IEnumerable<Transport>).ElementAt(selectedIndex);
                _presenter.addTransportToTourGroup(transport, _tourGroup);
            }
            this.search();
        }

        private void removeAllBtn_Click(object sender, EventArgs e)
        {
            var selectedTransport = _resultGv.SelectedRows;

            int selectedIndex;
            Transport transport = null;
            foreach (var row in selectedTransport)
            {
                selectedIndex = (row as DataGridViewBand).Index;
                transport = (_transportBindingSource.DataSource as IEnumerable<Transport>).ElementAt(selectedIndex);
                _presenter.removeTransportFromTourGroup(transport, _tourGroup);
            }
            this.search();
        }

        private void _showStateCb_CheckedChanged(object sender, EventArgs e)
        {
            this.search();
        }

        private void _searchBtn_Click(object sender, EventArgs e)
        {
            this.search();
        }

        private void _searchTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.search();
        }

        private void _totalFeeTb_Leave(object sender, EventArgs e)
        {
            float fee = float.Parse(_totalFeeTb.Text.Trim());
            float basicFee = (float) Math.Round(_presenter.getTotalTransportFee(_tourGroup.id),2);
            if (fee <  basicFee)
            {
                MessageBox.Show("Tổng phí nhập vào không thể nhỏ hơn tổng phí dự tính: " + basicFee.ToString());
                _totalFeeTb.Text = Math.Round(basicFee, 2).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _totalFeeTb.Enabled = true;
            _editBtn.Enabled = false;
        }

        private void fmTourGroupTransport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_tourGroup.TourGroupFee == null)
            {

                //_tourGroup.TourGroupFee = new TourGroupFee();
                //_tourGroup.TourGroupFee.hotel_fee = 0.0;
                //_tourGroup.TourGroupFee.transport_fee = getTransportFee();
                //_tourGroup.TourGroupFee.tourgroup_id = _tourGroup.id;
                //_presenter.updateTourGroup(_tourGroup);
            }
        }

        private float getTransportFee()
        {
            return (float)Math.Round(float.Parse(_totalFeeTb.Text.Trim()), 2);
        }

    }
    public class TransportComparer : IEqualityComparer<Transport>
    {

        public bool Equals(Transport x, Transport y)
        {
            return x.id == y.id;
        }

        public int GetHashCode(Transport obj)
        {
            return obj.id;
        }
    }
    public class TRANSPORTTourGroupComparer : IEqualityComparer<TransportsTourGroup>
    {

        public bool Equals(TransportsTourGroup x, TransportsTourGroup y)
        {
            return (x.transport_id == y.transport_id);
        }

        public int GetHashCode(TransportsTourGroup obj)
        {
            return obj.transport_id.GetHashCode();
        }
    }
}
