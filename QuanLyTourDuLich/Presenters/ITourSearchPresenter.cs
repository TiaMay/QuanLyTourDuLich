using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    interface ITourSearchPresenter
    {
        void handleSearchClick(string keyword);

        void updateViewSearchResult(IEnumerable<Tour> _searchResult);

        void filterTourCategoryChange(IEnumerable<TourCategory> tourcategories);

        void filterTourPriceChange(int[] tourPrice);

        void filterTourCityChange(IEnumerable<Destination> city);

        void sortByTourId();

        void sortByTourName();

        void sortByTourCategory();

        void sortByPrice();

        void sortByDestination();

        void sortByCity();

    }
}
