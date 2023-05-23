using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity.SearchEngine
{
    class TourGroupSearchEngine : ISearchAble<TourGroup>
    {
        private IEnumerable<TourGroup> _entry;
        private TourGroupBUS _bus;


        public TourGroupSearchEngine()
        {
            _bus = new TourGroupBUS();
            _entry = _bus.getEntries();
        }

        public IEnumerable<TourGroup> Search(string keyword)
        {
            List<TourGroup> rt = new List<TourGroup>();
            rt.AddRange(searchByTourName(keyword));
            rt.AddRange(searchByName(keyword));
            return rt.Distinct();
        }

        private IEnumerable<TourGroup> searchByTourName(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(tourGroup => regex.IsMatch(tourGroup.Tour.name));
        }

        private IEnumerable<TourGroup> searchByName(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(tour => regex.IsMatch(tour.name));
        }

        public void refresh()
        {
            _bus = new TourGroupBUS();
        }
    }
}
