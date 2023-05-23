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
    class TourSearchPresenter : ITourSearchPresenter
    {
        private ITourSearchView _view;

        private SearchEngine<Tour> _tourSearch;
        private IEnumerable<Tour> _searchResult;

        private IEnumerable<TourCategory> _tourcategoriesFilter;
        private IEnumerable<Destination> _tourCityFilter;
        private int _tourPriceMin = 0;
        private int _tourPriceMax = 0;  

        public TourSearchPresenter(ITourSearchView view)
        {
            _view = view;
            _tourSearch = new SearchEngine<Tour>();
        }

        public void handleSearchClick(string keyword)
        {
            _searchResult = _tourSearch.Search(keyword);
            updateFilter();
            //this.updateViewSearchResult(_searchResult);
        }

        public void updateViewSearchResult(IEnumerable<Tour> _searchResult)
        {
            _view.updateSearchResult(_searchResult);
        }

        #region Filter

        public void filterTourCategoryChange(IEnumerable<TourCategory> tourcategories)
        {
            _tourcategoriesFilter = tourcategories;
            if (_searchResult != null && _searchResult.Count() != 0)
                updateFilter();
        }

        public void filterTourPriceChange(int[] tourPrice)
        {
            _tourPriceMin = tourPrice[0];
            _tourPriceMax = tourPrice[1];
            if (_searchResult != null && _searchResult.Count() != 0)
                updateFilter();
        }

        public void filterTourCityChange(IEnumerable<Destination> city)
        {
            _tourCityFilter = city;
            if (_searchResult != null && _searchResult.Count() != 0)
                updateFilter();
        }

        private void updateFilter(IEnumerable<Tour> source = null)
        {
            var rs1 = filterByTourCategory(_tourcategoriesFilter, source);
            var rs2 = filterByPrice(_tourPriceMin, _tourPriceMax, source);
            var rs3 = filterByCity(_tourCityFilter, source);
            var comparasion = new TourEqualityComparer();
            var rs = rs1.Intersect(rs2).Intersect(rs3);
            this.updateViewSearchResult(rs);
        }

        private IEnumerable<Tour> filterByTourCategory(IEnumerable<TourCategory> tourCategories, IEnumerable<Tour> source = null)
        {
            if (source == null)
                source = _searchResult;
            if (tourCategories == null || tourCategories.Count() == 0)
                return source;
            var tourCategoriesId = tourCategories.Select(tourc => tourc.id);
            return source.Where(tour => tourCategoriesId.Contains(tour.category_id)).ToList();
        }

        private IEnumerable<Tour> filterByPrice(int minPrice, int maxPrice, IEnumerable<Tour> source = null)
        {
            if (source == null)
                source = _searchResult;
            if (minPrice == 0 && maxPrice == 0)
                return source;
            return source.Where(tour => tour.TourPrice.price >= minPrice && tour.TourPrice.price < maxPrice).ToList();
        }

        private IEnumerable<Tour> filterByCity(IEnumerable<Destination> cities, IEnumerable<Tour> source = null)
        {
            if (source == null)
                source = _searchResult;
            if (cities == null || cities.Count() == 0)
                return source;
            var destinationIds = cities.Select(city => city.id);

            return source.Where(tour => destinationIds.Contains(tour.destination_id)).ToList();
        }

        #endregion //! Filter

        #region Sort

        public void sortByTourId()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Tour>((t1, t2) => t1.id - t2.id);
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            updateFilter(query);
        }

        public void sortByTourName()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Tour>((t1, t2) => t1.name.CompareTo(t2.name));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            updateFilter(query);
        }

        public void sortByTourCategory()
        {
             if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Tour>((t1, t2) => t1.TourCategory.name.CompareTo(t2.TourCategory.name));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            updateFilter(query);
        }

        public void sortByPrice()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Tour>((t1, t2) =>(int)( t1.TourPrice.price - t2.TourPrice.price));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            updateFilter(query);
        }

        public void sortByDestination()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Tour>((t1, t2) => t1.Destination.name.CompareTo(t1.Destination.name));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            updateFilter(query);
        }

        public void sortByCity()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Tour>((t1, t2) => t1.Destination.city.CompareTo(t2.Destination.city));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            updateFilter(query);
        }

        #endregion // !Sort

        class TourEqualityComparer : IEqualityComparer<Tour>
        {
            public bool Equals(Tour b1, Tour b2)
            {
                if (b2 == null && b1 == null)
                    return true;
                else if (b1 == null | b2 == null)
                    return false;
                else
                    return b1.id == b2.id;
            }

            public int GetHashCode(Tour t)
            {
                return t.id.GetHashCode();
            }
        }
    }
}
