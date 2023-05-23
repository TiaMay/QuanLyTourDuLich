using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Views
{
    interface ITourGroupSearchView
    {
        void handleSearchTourGroupClick(string keyword);
        void updateSearchResult(IEnumerable<TourGroup> searchResult);

        void updateMinDepartDate(DateTime mindate);

        void udpateMaxReturnDate(DateTime maxdate);
    }
}
