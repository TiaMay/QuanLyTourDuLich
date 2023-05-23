using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity.SearchEngine
{
    class TourSearchEngine : ISearchAble<Tour>
    {
        private IEnumerable<Tour> _entry;
        private TourBUS _bus;

        public TourSearchEngine()
        {
            _bus = new TourBUS();
            _entry = _bus.getEntries();
        }

        public IEnumerable<Tour> Search(string keyword)
        {
            List<Tour> rt = new List<Tour>();
            rt.AddRange(searchByName(keyword));
            rt = new List<Tour>(rt.Distinct());
            return rt;
        }

        private IEnumerable<Tour> searchByName(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(tour => regex.IsMatch(tour.name));
        }

        public void refresh()
        {
            _bus = new TourBUS();
        }
    }
}
