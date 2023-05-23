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
    class TourSitePresenter : ITourSitePresenter
    {
        private ITourSiteView _view;

        private TourSiteBUS _bus;
        private IEnumerable<TourSite> _tourSites;

        private SearchEngine<TourSite> _searchEngine;

        public TourSitePresenter(ITourSiteView view)
        {
            _view = view;
            _bus = new TourSiteBUS();
            _searchEngine = new SearchEngine<TourSite>();
        }

        public void loadAllTourSites()
        {
            _tourSites = _bus.getEntries();
            _view.updateTourSiteView(_tourSites);
        }

        public void loadTourSiteByDesinationId(int destinationId)
        {
            _tourSites = _bus.getByDestination(destinationId);
            _view.updateTourSiteView(_tourSites);
        }

        public void addTourSite(TourSite toursite)
        {
            _bus.add(toursite);
            this.loadTourSiteByDesinationId(toursite.destination_id);
        }

        //public void loadTourSiteFree()
        //{
        //    _tourSites = _bus.getWeakTourSite();
            
        //}
        public void updateAllTourSites(IEnumerable<TourSite> toursites)
        {
            foreach (var item in toursites)
            {
                _bus.update(item);
            }
        }

        public void refresh()
        {
            _bus.refresh();
        }

        public void deleteTourSite(TourSite toursite)
        {
            _bus.deletaById(toursite.id);
        }



        public void deleteTourSites(IEnumerable<TourSite> toursites)
        {
            foreach (var site in toursites)
            {
                this.deleteTourSite(site);
            }
        }

        public void search(string keyword)
        {
            _tourSites = _searchEngine.Search(keyword);
            _view.updateTourSiteView(_tourSites);
        }

        public void search(string keyword, int destinationId)
        {
            var result = _searchEngine.Search(keyword);
            var query = result.Where(site => site.destination_id == destinationId);
            _view.updateTourSiteView(query);
        }
    }
}
