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

namespace QuanLyTourDuLich.Forms
{
    public partial class fmLocationManager : Form, IDestinationView
    {
        //ITourSitePresenter _tourSitePresenter;
        IDestinationPresenter _destinationPresenter;

        public fmLocationManager()
        {
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
           // _tourSitePresenter = new TourSitePresenter(this);
            _destinationPresenter = new DestinationPresenter(this);
            var allCities = BusinessEntity.VietNamCities.getAllCities();
            _citiesBindingSource.DataSource = allCities;

            _cityDestinationColumn.DisplayMember = "name";
            _citiesCbb.DisplayMember = "name";
        }

        private void fmLocationManager_Load(object sender, EventArgs e)
        {
           // _tourSitePresenter.loadAllTourSites();
            _destinationPresenter.loadAllDestinations();
            this.setEnableSaveBtn(false);
            Cursor.Current = Cursors.Default;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public void updateTourSiteView(IEnumerable<DTO.TourSite> tourSites)
        //{
        //    _tourSiteBindingSource.DataSource = tourSites;

        //    // vì một lí do gì đó cài dòng mắc dịch này phải để sau cái dòng trên nó mới hiểu.
        //    // làm xấu code của ông
        //   // _tourSitesClb.DisplayMember = "name";

        //}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkEnableTourSiteAddBtn();
        }


        private void _tourSiteAddBtn_Click(object sender, EventArgs e)
        {
            listViewAddNewItem();
        }

        private void listViewAddNewItem()
        {
            var txt = _tourSiteNewItemTb.Text.Trim();
            _tourSitesTempLv.Items.Add(txt);
            _tourSiteNewItemTb.Clear();
        }

        private void _tourSiteNewItemTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                listViewAddNewItem();
            }
        }

        private void _tourSiteRemoveBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in _tourSitesTempLv.SelectedItems)
            {
                _tourSitesTempLv.Items.Remove(eachItem);
            }
        }

        private void _hotelInfoTb_TextChanged(object sender, EventArgs e)
        {
            _hotelAddTb.Enabled = checkEnableAddBtn();
        }

        private bool checkEnableAddBtn()
        {
            if (String.IsNullOrEmpty(_hotelNameTb.Text.Trim()))
                return false;
            if (String.IsNullOrEmpty(_hotelAddressTb.Text.Trim()))
                return false;
            if (String.IsNullOrEmpty(_hotelPhoneTb.Text.Trim()))
                return false;
            return true;
        }

        private void _hotelAddTb_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            hotel.name = _hotelNameTb.Text.Trim();
            hotel.address = _hotelAddressTb.Text.Trim();
            hotel.phone = _hotelPhoneTb.Text.Trim();
            hotel.status = _hotelStatusTb.Text.Trim();
            _hotelBindingSource.Add(hotel);
            clearHotelInfoTb();
        }

        private void clearHotelInfoTb()
        {
            _hotelNameTb.Clear();
            _hotelAddressTb.Clear();
            _hotelPhoneTb.Clear();
            _hotelStatusTb.Clear();
        }

        private void splitContainer1_Panel1_Layout(object sender, LayoutEventArgs e)
        {
            _hotelAddTb.Enabled = checkEnableAddBtn();
            var selected = _hotelGv.SelectedRows.Count;
            _hotelRemoveTb.Enabled = selected != 0;
        }

        private void _hotelGv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;
            if (e.ColumnIndex == 0)
                e.Value = e.RowIndex + 1;
        }

        private void _destinationTb_TextChanged(object sender, EventArgs e)
        {
            checkEnableSecondaryPanel();
            checkEnableAcceptBtn();
        }

        void checkEnableSecondaryPanel()
        {
            var isEnable = String.IsNullOrEmpty(_destinationTb.Text.Trim());
            _tourSitePanel.Enabled = !isEnable;
            _secondSpliter.Panel1.Enabled = !isEnable;
        }

        private void _mainContainer_Layout(object sender, LayoutEventArgs e)
        {
            checkEnableSecondaryPanel();
        }

        private void _tourSitesTempLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lv = (sender as ListView);
            _tourSiteRemoveBtn.Enabled = lv.SelectedItems.Count != 0;
        }

        private void _hotelGv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void _tourSitePanel_Layout(object sender, LayoutEventArgs e)
        {
            checkEnableTourSiteAddBtn();
            checkEnableTourSiteRemoveBtn();
        }

        private void checkEnableTourSiteRemoveBtn()
        {
            _tourSiteRemoveBtn.Enabled = _tourSitesTempLv.Items.Count != 0;
        }

        private void checkEnableTourSiteAddBtn()
        {
            var enabled = !String.IsNullOrEmpty(_tourSiteNewItemTb.Text.Trim());
            _tourSiteAddBtn.Enabled = enabled; 
        }

        private void _hotelGv_SelectionChanged(object sender, EventArgs e)
        {
            var selected = _hotelGv.SelectedRows.Count;
            _hotelRemoveTb.Enabled = selected != 0;
        }

        private void _hotelRemoveTb_Click(object sender, EventArgs e)
        {
            var selected = _hotelGv.SelectedRows;
            foreach (DataGridViewCell oneCell in _hotelGv.SelectedCells)
            {
                if (oneCell.Selected)
                    _hotelGv.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void _mainContainer_Panel1_Layout(object sender, LayoutEventArgs e)
        {
            checkEnableAcceptBtn();
        }

        private void checkEnableAcceptBtn()
        {
            bool isEmpty = String.IsNullOrEmpty(_destinationTb.Text.Trim());
            _acceptBtn.Enabled = !isEmpty;
            _cancelBtn.Enabled = !isEmpty;
        }

        private void _acceptBtn_Click(object sender, EventArgs e)
        {
            Destination destination = new Destination();
            destination.name = _destinationTb.Text.Trim();
            destination.city = (_citiesCbb.SelectedItem as BusinessEntity.VietNamCities.City).name;

            for (int i = 0; i < _tourSitesTempLv.Items.Count; i++)
			{
                TourSite toursite = new TourSite();
			    toursite.name =  _tourSitesTempLv.Items[i].Text;
                toursite.Destination = destination;
                destination.TourSites.Add(toursite);
			}

            for (int i = 0; i < _hotelBindingSource.Count; i++)
			{
			    var hotel = _hotelBindingSource.List[i] as Hotel;
                hotel.Destination = destination;
                destination.Hotels.Add(hotel);

			}

            _destinationPresenter.addDestination(destination);
            clearAllTb();
        }

        public void updateDestinationView(IEnumerable<Destination> destinations)
        {
            _destinationBindingSource.DataSource = destinations;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;

            }
            if (e.ColumnIndex == 2)
            {
//                e.Value = 
            }
            if (e.ColumnIndex == 3)
            {
                if ((e.Value as IEnumerable<TourSite>) == null)
                    e.Value = 0;
                else
                    e.Value = (e.Value as IEnumerable<TourSite>).Count().ToString();

            }
            if (e.ColumnIndex == 4)
            {
                if ((e.Value as IEnumerable<Hotel>) == null)
                    e.Value = 0;
                else
                    e.Value = (e.Value as IEnumerable<Hotel>).Count().ToString();

            }
            if (e.ColumnIndex == 5)
            {
                if ((e.Value as IEnumerable<Tour>) == null)
                    e.Value = 0;
                else
                    e.Value = (e.Value as IEnumerable<Tour>).Count().ToString();
            }
        }

        private void _saveBtnPanel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _destinationPresenter.updateAll(_destinationBindingSource.DataSource as IEnumerable<Destination>);
            Cursor.Current = Cursors.Default;
            setEnableSaveBtn(false);
        }

        private void _discardBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _destinationPresenter.refresh();
            _destinationPresenter.loadAllDestinations();
            Cursor.Current = Cursors.Default;
            this.setEnableSaveBtn(false);
        }

        private void _deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedindex = _destinationGv.SelectedRows[0].Index;
            var destination = (_destinationBindingSource.DataSource as IEnumerable<Destination>).ElementAt(selectedindex);
            _destinationPresenter.deleteDestination(destination);
        }

        public void showDialog(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _searchTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            var keyword = _searchTb.Text.Trim();
            _destinationPresenter.searchDestination(keyword);
        }

        private void _cancelBtn_Click(object sender, EventArgs e)
        {
            clearAllTb();
        }

        private void clearAllTb()
        {
            _destinationTb.Clear();
            _citiesCbb.SelectedIndex = 0;
            _tourSiteNewItemTb.Clear();
            _tourSitesTempLv.Clear();
            _hotelNameTb.Clear();
            _hotelAddressTb.Clear();
            _hotelPhoneTb.Clear();
            _hotelStatusTb.Clear();
            _hotelBindingSource.DataSource = null;
            _hotelGv.Rows.Clear();
        }

        private void _destinationGv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            _destinationGv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "...";
        }

        private void _destinationGv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (e.ColumnIndex == 3)
            {
                var dest = (_destinationBindingSource.DataSource as IEnumerable<Destination>).ElementAt(e.RowIndex);
                new fmDestinationDetail(dest).ShowDialog();
                _destinationPresenter.reLoadAll();
            }
            if (e.ColumnIndex == 4)
            {
                var dest = (_destinationBindingSource.DataSource as IEnumerable<Destination>).ElementAt(e.RowIndex);
                new fmHotels(dest).ShowDialog();
                _destinationPresenter.reLoadAll();
            }

        }

        private void setEnableSaveBtn(bool isEnabled)
        {
            _saveBtn.Enabled = isEnabled;
            _discardBtn.Enabled = isEnabled;
        }

        private void _destinationGv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            setEnableSaveBtn(true);
        }

        public void updateDestinationError()
        {
            MessageBox.Show("Một hoặc nhiều dữ liệu không chính xác. Dữ liệu đã chỉnh sửa sẽ được khôi phục",
                "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _destinationGv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                _destinationPresenter.sortByName();
            }
            else if (e.ColumnIndex == 2)
            {
                _destinationPresenter.sortByCity();
            }
            else if (e.ColumnIndex == 3)
            {
                _destinationPresenter.sortByTourSites();
            }
            else if (e.ColumnIndex == 4)
            {
                _destinationPresenter.sortByHotels();
            }
            else if (e.ColumnIndex == 5)
            {
                _destinationPresenter.sortByTours();
            }
        }
    }
}
