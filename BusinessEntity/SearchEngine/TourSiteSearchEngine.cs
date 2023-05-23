using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity.SearchEngine
{
    class TourSiteSearchEngine : ISearchAble<DTO.TourSite>
    {
        private IEnumerable<DTO.TourSite> _entry;
        private TourSiteBUS _bus;

        public TourSiteSearchEngine()
        {
            _bus = new TourSiteBUS();
            _entry = _bus.getEntries();
        }

        public IEnumerable<DTO.TourSite> Search(string keyword)
        {
            List<DTO.TourSite> rt = new List<DTO.TourSite>();
            rt.AddRange(searchByName(keyword));

            rt = new List<DTO.TourSite>(rt.Distinct()); // khử các phần tử trùng
            return rt;
        }

        private IEnumerable<DTO.TourSite> searchByName(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(toursite => regex.IsMatch(toursite.name));
        }

        public void refresh()
        {
            _bus = new TourSiteBUS();
        }

    }
}
