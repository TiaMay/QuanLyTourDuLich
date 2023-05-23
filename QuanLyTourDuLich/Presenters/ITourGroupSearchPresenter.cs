using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    interface ITourGroupSearchPresenter
    {
        void handleSearchClick(string keyword);
        void updateViewSearchResult(IEnumerable<TourGroup> _searchResult);
        void filterTransport(IEnumerable<Transport> _transports);
        void filterDate(DateTime[] _times);

        void sortByTourGrouId();
        void sortByTourGroupName();
        void sortByTourName();
        void sortByDepartDate();
        void sortByReturnDate();
        void sortByEmployees();


        void loadMinDepartDate();

        void loadMaxReturnDate();
    }
}
