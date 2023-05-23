using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    interface ITourSitePresenter
    {

        void loadAllTourSites();

        void addTourSite(TourSite toursite);

        void loadTourSiteByDesinationId(int destinationId);

        //void updateViewStatus(string stt);

       // void loadTourSiteFree();

        void updateAllTourSites(IEnumerable<TourSite> toursites);

        void refresh();

        void deleteTourSite(TourSite toursite);

        void deleteTourSites(IEnumerable<TourSite> toursites);

        void search(string keyword);

        void search(string keyword, int destinationId);
    }
}
