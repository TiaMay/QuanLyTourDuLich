using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    interface IDestinationPresenter
    {
        void loadAllDestinations();
        void addDestination(Destination destination);
        void updateAll(IEnumerable<Destination> destination);
        void refresh();
        void deleteDestination(Destination destination);
        void searchDestination(string keyword);

        void reLoadAll();

        void sortByName();

        void sortByCity();

        void sortByTourSites();

        void sortByHotels();

        void sortByTours();
    }
}
