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

    public partial class fmSearch : Form, ICustomerSearchView, ITourSearchView, ITourGroupSearchView
    {

        ICustomerSearchPresenter _customerSearchpresenter;
        ITourSearchPresenter _tourSearchpresenter;

        TourCategoryBUS _bus;
        IEnumerable<TourCategory> _entry;

        DestinationBUS _destinationBus;
        IEnumerable<Destination> _detinations;

        TourPriceBUS _tourPriceBus;
        IEnumerable<TourPrice> _tourPrices;

        TransportBUS _transportBUS;
        IEnumerable<Transport> _transports;

        float _minPrice;
        float _maxPrice;

        ITourGroupSearchPresenter _tourGroupSearchPresenter;
        TourGroupBUS _tourGroupBus;

        SearchEngine<TourGroup> tourGroupSearchEngine;
        DateTime _minDepartDate;
        DateTime _maxReturnDate;

        public fmSearch()
        {
            InitializeComponent();
            postInit();
            _customerSearchpresenter = new CustomerSearchPresenter(this);
            _tourSearchpresenter = new TourSearchPresenter(this);
            _tourGroupSearchPresenter = new TourGroupSearchPresenter(this);

            _bus = new TourCategoryBUS();
            _entry = _bus.getEntries();

            _destinationBus = new DestinationBUS();
            _detinations = _destinationBus.getEntries();

            _tourPriceBus = new TourPriceBUS();
            _tourPrices = _tourPriceBus.getEntries();
            _minPrice = _tourPriceBus.getMinPrice();
            _maxPrice = _tourPriceBus.getMaxPrice();

            _transportBUS = new TransportBUS();
            _transports = _transportBUS.getEntries();

            _tourGroupBus = new TourGroupBUS();
            _minDepartDate = _tourGroupBus.getMinDepartDate();
            _maxReturnDate = _tourGroupBus.getMaxReturnDate();

            tourGroupSearchEngine = new SearchEngine<TourGroup>();

        }

        private void postInit()
        {
            _tourCategoryClb.DataSource = _tourCategoryBs;
            _destinationClb.DataSource = _destinationBs;
            _transportClb.DataSource = _transportBs;
        }

        private void fmSearch_Load(object sender, EventArgs e)
        {
            _tourCategoryBs.DataSource = _entry;
            _tourCategoryClb.DisplayMember = "name";

            _destinationBs.DataSource = _detinations;
            _destinationClb.DisplayMember = "city";

            _minPriceUD.Value = (decimal)_minPrice;
            _maxPriceUD.Value = (decimal)_maxPrice + 1;

            _transportBs.DataSource = _transports;
            _transportClb.DisplayMember = "name";

            _startDtp.Value = _minDepartDate;
            _endDtp.Value = _maxReturnDate;
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
            if (e.ColumnIndex == 5)
            {
                if (e.Value != null)
                    e.Value = ((Gender)e.Value).name;
            }
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
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
            if (_resultGv.Rows.Count == 0)
                return;
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

        private void _startDtp_ValueChanged(object sender, EventArgs e)
        {
            var dtpicker = (sender as DateTimePicker);
            if (dtpicker == null)
                return;
            _minDepartDate = dtpicker.Value;
            _tourGroupSearchPresenter.filterDate(new DateTime[] { _minDepartDate, _maxReturnDate });
        }

        private void _endDtp_ValueChanged(object sender, EventArgs e)
        {
            var dtpicker = (sender as DateTimePicker);
            if (dtpicker == null)
                return;
            _maxReturnDate = dtpicker.Value;
            _tourGroupSearchPresenter.filterDate(new DateTime[] { _minDepartDate, _maxReturnDate });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //_tourGroupBs.DataSource = tourGroupSearchEngine.Search(_tourGroupKeywordTb.Text);
            var keyword = _tourGroupKeywordTb.Text.Trim();
            this.handleSearchTourGroupClick(keyword);
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
                e.Value = (e.Value as IEnumerable<Passenger>).Count().ToString();
            }
        }

        private void _tourGroupGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void _tourGroupKeywordTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.handleSearchTourGroupClick(_tourGroupKeywordTb.Text);
        }

        public void handleSearchTourGroupClick(string keyword)
        {
            _tourGroupSearchPresenter.handleSearchClick(keyword);
        }

        public void updateSearchResult(IEnumerable<TourGroup> searchResult)
        {
            _tourGroupBs.DataSource = searchResult;
        }

        private void _transportClb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = _transportClb.CheckedItems.Cast<Transport>();
            _tourGroupSearchPresenter.filterTransport(selected);
        }

        private void _keywordTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            _customerSearchpresenter.performClickSearch(_keywordTb.Text.Trim());
        }


    }
}
