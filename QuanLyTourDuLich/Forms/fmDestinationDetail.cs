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
    public partial class fmDestinationDetail : Form, ITourSiteView
    {
        Destination _destination;
        ITourSitePresenter _presenter;

        public fmDestinationDetail(Destination destination)
        {
            InitializeComponent();
            _destination = destination;
            this.Text = _destination.name;
            _presenter = new TourSitePresenter(this);
        }


        private void panel2_Layout(object sender, LayoutEventArgs e)
        {
            checkEnableAddBtn();
        }

        private void _tourSiteName_TextChanged(object sender, EventArgs e)
        {
            checkEnableAddBtn();
        }

        private void checkEnableAddBtn()
        {
            bool isEmpty = String.IsNullOrEmpty(_tourSiteName.Text.Trim());
            _addBtn.Enabled = !isEmpty;
        }

        private void _addBtn_Click(object sender, EventArgs e)
        {
            addTourSite();
            clearInfo();
        }
        
        private void _tourSiteName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                addTourSite();
                clearInfo();
            }
        }

        private void addTourSite()
        {
            TourSite toursite = new TourSite();
            toursite.name = _tourSiteName.Text.Trim();
            toursite.destination_id = _destination.id;
            _presenter.addTourSite(toursite);
        }

        private void clearInfo()
        {
            _tourSiteName.Clear();
        }

        private void fmDestinationDetail_Load(object sender, EventArgs e)
        {
            Utils.cursorWait();
            _presenter.loadTourSiteByDesinationId(_destination.id);
            this.setEnabledSaveBtn(false);
            Utils.cursorDefault();
        }

        public void updateTourSiteView(IEnumerable<TourSite> tourSites)
        {
            _tourSiteBindingSource.DataSource = tourSites;

        }

        private void _deleteBtn_Click(object sender, EventArgs e)
        {
            if (_currentTourSiteGv.SelectedRows.Count == 0)
                return;
            int selectedindex = _currentTourSiteGv.SelectedRows[0].Index;
            var toursite = (_tourSiteBindingSource.DataSource as IEnumerable<TourSite>).ElementAt(selectedindex);
            _presenter.deleteTourSite(toursite);
            _presenter.loadTourSiteByDesinationId(_destination.id);
        }

        private void _saveBtn_Click(object sender, EventArgs e)
        {
            Utils.cursorWait();
            var toursites = _tourSiteBindingSource.DataSource as IEnumerable<TourSite>;
            _presenter.updateAllTourSites(toursites);
            setEnabledSaveBtn(false);
            Utils.cursorDefault();
        }

        private void _revertBtn_Click(object sender, EventArgs e)
        {
            Utils.cursorWait();

            _presenter.refresh();
            _presenter.loadTourSiteByDesinationId(_destination.id);
            setEnabledSaveBtn(false);
            Cursor.Current = Cursors.Default;
            Utils.cursorDefault();

        }

        private void _currentTourSiteGv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            setEnabledSaveBtn(true);
        }

        private void setEnabledSaveBtn(bool isEnabled)
        {
            _saveBtn.Enabled = isEnabled;
            _revertBtn.Enabled = isEnabled;
        }

        private void _currentTourSiteGv_SelectionChanged(object sender, EventArgs e)
        {
            var selectedCount = (sender as DataGridView).SelectedRows.Count;
            _deleteBtn.Enabled = (selectedCount != 0);
        }

        private void searchBoxTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyword = _searchBoxTb.Text.Trim();
            _presenter.search(keyword, _destination.id);
        }

        private void _currentTourSiteGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

  
    }
}
