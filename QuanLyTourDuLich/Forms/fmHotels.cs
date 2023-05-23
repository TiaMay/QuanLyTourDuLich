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

namespace QuanLyTourDuLich.Forms
{
    public partial class fmHotels : Form, IHotelView
    {
        Destination _destination;
        IHotelPresenter _presenter;

        public fmHotels(Destination destination)
        {
            InitializeComponent();
            _destination = destination;
            _destination = destination;
            this.Text = _destination.name;
            _presenter = new HotelPresenter(this);
        }

        private void fmHotels_Load(object sender, EventArgs e)
        {
            Utils.cursorWait();
            _presenter.loadHotelByDestinationId(_destination.id);
            this.setEnabledSaveBtn(false);
            Utils.cursorDefault();
        }


        private void panel2_Layout(object sender, LayoutEventArgs e)
        {
            checkEnableAddBtn();
        }

        private void hotelInfo_TextChanged(object sender, EventArgs e)
        {
            checkEnableAddBtn();
        }

        private void checkEnableAddBtn()
        {
            if (String.IsNullOrEmpty(_hotelNameTb.Text.Trim()))
            {
                _addBtn.Enabled = false;
                return;
            }
            if (String.IsNullOrEmpty(_addressNameTb.Text.Trim()))
            {
                _addBtn.Enabled = false;
                return;
            }
            if (String.IsNullOrEmpty(_phoneTb.Text.Trim()))
            {
                _addBtn.Enabled = false;
                return;
            }
            //if (String.IsNullOrEmpty(_statusTb.Text.Trim()))
            //{
            //    _addBtn.Enabled = false;
            //    return;
            //}
            _addBtn.Enabled = true;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addTourSite();
            clearInfo();
        }

        private void addTourSite()
        {
            // save new hotel
            Hotel hotel = new Hotel();
            hotel.name = _hotelNameTb.Text.Trim();
            hotel.address = _addressNameTb.Text.Trim();
            hotel.phone = _phoneTb.Text.Trim();
            hotel.status = "";
            hotel.destination_id = _destination.id;
            hotel.price = (double)numericUpDown1.Value;
            //hotel.TourGroupHotels = new List<TourGroupHotel>();
            _presenter.addHotel(hotel);
        }

        private void clearInfo()
        {
            // clear all textblock info
            _hotelNameTb.Clear();
            _addressNameTb.Clear();
            _phoneTb.Clear();
            _statusTb.Clear();
        }

        public void updateHotelView(IEnumerable<Hotel> hotels)
        {
            _hotelBindingSource.DataSource = hotels;
        }


        private void setEnabledSaveBtn(bool isEnabled)
        {
            _saveBtn.Enabled = isEnabled;
            _revertBtn.Enabled = isEnabled;
        }

        private void _saveBtn_Click(object sender, EventArgs e)
        {
            Utils.cursorWait();
            var toursites = _hotelBindingSource.DataSource as IEnumerable<Hotel >;
            _presenter.updateAllHotels(toursites);
            setEnabledSaveBtn(false);
            Utils.cursorDefault();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (_currentHotelsGv.SelectedRows.Count == 0)
                return;
            int selectedindex = _currentHotelsGv.SelectedRows[0].Index;
            var toursite = (_hotelBindingSource.DataSource as IEnumerable<Hotel>).ElementAt(selectedindex);
            _presenter.deleteHotel(toursite);
            _presenter.loadHotelByDestinationId(_destination.id);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Utils.cursorWait();
            var toursites = _hotelBindingSource.DataSource as IEnumerable<Hotel>;
            _presenter.updateAllHotels(toursites);
            setEnabledSaveBtn(false);
            Utils.cursorDefault();
        }

        private void revertBtn_Click(object sender, EventArgs e)
        {
            Utils.cursorWait();
            _presenter.refresh();
            _presenter.loadHotelByDestinationId(_destination.id);
            setEnabledSaveBtn(false);
            Cursor.Current = Cursors.Default;
            Utils.cursorDefault();

        }

        private void currentHotelsGv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            setEnabledSaveBtn(true);
        }

        private void currentTourSiteGv_SelectionChanged(object sender, EventArgs e)
        {
            var selectedCount = (sender as DataGridView).SelectedRows.Count;
            _deleteBtn.Enabled = (selectedCount != 0);
        }

        private void searchBoxTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyword = _searchBoxTb.Text.Trim();
            _presenter.search(keyword, _destination.id);
        }

        private void _addBtn_Load(object sender, EventArgs e)
        {

        }
    }
}
