using BusinessEntity;
using BusinessEntity.SearchEngine;
using DTO;
using QuanLyTourDuLich.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    class TourGroupSearchPresenter : ITourGroupSearchPresenter
    {
        ITourGroupSearchView _view;

        private SearchEngine<TourGroup> _tourGrourSearch;
        private IEnumerable<TourGroup> _searchResult;

        private IEnumerable<Transport> _transportFilter;
        private DateTime _depart_date = DateTime.MinValue;

        private DateTime _return_date = DateTime.MaxValue;

        private TourGroupBUS _bus;
        public TourGroupSearchPresenter(ITourGroupSearchView view)
        {
            _view = view;

            _tourGrourSearch = new SearchEngine<TourGroup>();

            _bus = new TourGroupBUS();
        }
        public void handleSearchClick(string keyword)
        {
            _searchResult = _tourGrourSearch.Search(keyword);
            updateFilter();
            //this.updateViewSearchResult(_searchResult);
        }

        public void updateViewSearchResult(IEnumerable<DTO.TourGroup> searchResult)
        {
            _view.updateSearchResult(searchResult);
        }


        public void filterTransport(IEnumerable<Transport> _transports)
        {
            _transportFilter = _transports;
            if (_searchResult != null && _searchResult.Count() != 0)
                updateFilter();
        }

        public void filterDate(DateTime[] _times)
        {
            _depart_date = _times[0];
            _return_date = _times[1];
            if (_searchResult != null && _searchResult.Count() != 0)
                updateFilter();
        }

        private void updateFilter(IEnumerable<TourGroup> source = null)
        {
            var rs1 = filterByTransport(_transportFilter, source);
            var rs2 = filterByTime(_depart_date, _return_date, source);
            var rs = rs1.Intersect(rs2);
            this.updateViewSearchResult(rs);
        }

        private IEnumerable<TourGroup> filterByTime(DateTime _depart_date, DateTime _return_date, IEnumerable<TourGroup> source = null)
        {
            if (source == null)
                source = _searchResult;
            if (_depart_date == DateTime.MinValue && _return_date == DateTime.MaxValue)
                return source;
            return source.Where(group => group.depart_date >= _depart_date && group.return_date <= _return_date);
        }


        private IEnumerable<TourGroup> filterByTransport(IEnumerable<Transport> transports, IEnumerable<TourGroup> source = null)
        {
            if (source == null)
                source = _searchResult;
            if (transports == null || transports.Count() == 0)
                return source;
           // return source;
            var comparer = new TransportEqualityComparer();
            return source
                .Where(tourG => tourG.TransportsTourGroups.Any(trans => transports.Contains(trans.Transport, comparer)))
                .ToList();
        }

        #region Sort
        public void sortByTourGrouId()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<TourGroup>((t1, t2) => t1.id - t2.id);
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            updateFilter(query);
        }

        public void sortByTourGroupName()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<TourGroup>((t1, t2) => t1.name.CompareTo(t2.name));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            updateFilter(query);
        }

        public void sortByTourName() 
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<TourGroup>((t1, t2) => t1.Tour.name.CompareTo(t2.Tour.name));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            updateFilter(query);
        }

        public void sortByDepartDate() 
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<TourGroup>((t1, t2) => (t1.depart_date - t2.depart_date).Days);
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            updateFilter(query);
        }

        public void sortByReturnDate() 
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<TourGroup>((t1, t2) => (t1.return_date - t2.return_date).Days);
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            updateFilter(query);
        }

        public void sortByEmployees() 
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<TourGroup>((t1, t2) => t1.Customers.Count - t2.Customers.Count);
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            updateFilter(query);
        }

        #endregion //!Sort

        public void loadMinDepartDate()
        {
            var rs = this._bus.getMinDepartDate();
            _view.updateMinDepartDate(rs);
        }

        public void loadMaxReturnDate()
        {
            var rs = this._bus.getMaxReturnDate();
            _view.udpateMaxReturnDate(rs);
        }

        class TransportEqualityComparer : IEqualityComparer<Transport>
        {
            public bool Equals(Transport b1, Transport b2)
            {
                if (b2 == null && b1 == null)
                    return true;
                else if (b1 == null | b2 == null)
                    return false;
                else
                    return b1.id == b2.id;
            }

            public int GetHashCode(Transport t)
            {
                return t.id.GetHashCode();
            }
        }
    }
}
