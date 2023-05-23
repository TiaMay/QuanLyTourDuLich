using BusinessEntity;
using BusinessEntity.SearchEngine;
using DTO;
using QuanLyTourDuLich.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTourDuLich.Presenters
{
    class DestinationPresenter : IDestinationPresenter
    {
        IDestinationView _view;
        DestinationBUS _bus;
        SearchEngine<Destination> _searchEngine;

        IEnumerable<Destination> _destinations;


        public DestinationPresenter(IDestinationView view)
        {
            _view = view;
            _bus = new DestinationBUS();
            _searchEngine = new SearchEngine<Destination>();
        }

        public void loadAllDestinations()
        {
            _destinations = _bus.getEntries();
            _view.updateDestinationView(_destinations);
        }


        public void addDestination(Destination destination)
        {
            _bus.add(destination);
            this.loadAllDestinations();
        }

        public void updateAll(IEnumerable<Destination> destinations)
        {
            if (destinations == null)
                return;
            foreach (var item in destinations)
            {
                try
                {
                    _bus.update(item);
                }
                catch (DbEntityValidationException e)
                {
                    _view.updateDestinationError();
                    this.refresh();
                    break;
                }
            }
            this.loadAllDestinations();

        }

        public void refresh()
        {
            _bus.refresh();
           // this.loadAllDestinations();
        }
        public void reLoadAll()
        {
            _bus = new DestinationBUS();
            this.loadAllDestinations();
        }

        public void deleteDestination(Destination destination)
        {
            if (destination.Tours != null && destination.Tours.Count != 0)
            {
                _view.showDialog("Không thể xoá khi điểm đến đã được sử dụng.");
                return;
            }
            _bus.delete(destination);
            //this.refresh();
            this.loadAllDestinations();         
        }

        public void searchDestination(string keyword)
        {
            _destinations = _searchEngine.Search(keyword);
            _view.updateDestinationView(_destinations);
        }

        public void sortByName()
        {
            if (_destinations == null || _destinations.Count() == 0)
                return;
            var comparasion = new Comparison<Destination>((d1, d2) => d1.name.CompareTo(d2.name));
            var query = _destinations.ToList();
            query.Sort(comparasion);
            _view.updateDestinationView(query);
        }

        public void sortByCity()
        {
            if (_destinations == null || _destinations.Count() == 0)
                return;
            var comparasion = new Comparison<Destination>((d1, d2) => d1.city.CompareTo(d2.city));
            var query = _destinations.ToList();
            query.Sort(comparasion);
            _view.updateDestinationView(query);
        }

        public void sortByTourSites()
        {
            if (_destinations == null || _destinations.Count() == 0)
                return;
            var comparasion = new Comparison<Destination>((d1, d2) => d2.TourSites.Count - d1.TourSites.Count);
            var query = _destinations.ToList();
            query.Sort(comparasion);
            _view.updateDestinationView(query);
        }

        public void sortByHotels()
        {
            if (_destinations == null || _destinations.Count() == 0)
                return;
            var comparasion = new Comparison<Destination>((d1, d2) => d2.Hotels.Count - d1.Hotels.Count);
            var query = _destinations.ToList();
            query.Sort(comparasion);
            _view.updateDestinationView(query);
        }

        public void sortByTours()
        {
            if (_destinations == null || _destinations.Count() == 0)
                return;
            var comparasion = new Comparison<Destination>((d1, d2) => d2.Tours.Count - d1.Tours.Count);
            var query = _destinations.ToList();
            query.Sort(comparasion);
            _view.updateDestinationView(query);
        }
    }
}
