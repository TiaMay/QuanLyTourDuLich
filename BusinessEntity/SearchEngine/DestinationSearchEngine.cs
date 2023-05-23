using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity.SearchEngine
{
    class DestinationSearchEngine : ISearchAble<Destination>
    {
        private IEnumerable<Destination> _entry;
        private DestinationBUS _bus;


        public DestinationSearchEngine()
        {
            _bus = new DestinationBUS();
            _entry = _bus.getEntries();
        }

        public IEnumerable<Destination> Search(string keyword)
        {
            List<Destination> rt = new List<Destination>();
            rt.AddRange(searchByDestinationName(keyword));
            rt.AddRange(searchByCity(keyword));
            return rt.Distinct();
        }

        private IEnumerable<Destination> searchByCity(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(destination => regex.IsMatch(destination.name));
        }

        private IEnumerable<Destination> searchByDestinationName(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(destination => regex.IsMatch(destination.city));
        }
        public void refresh()
        {
            _bus = new DestinationBUS();
        }


    }
}
