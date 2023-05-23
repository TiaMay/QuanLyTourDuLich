using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity.SearchEngine
{
    class TransportSearchEngine : ISearchAble<Transport>
    {
        private IEnumerable<DTO.Transport> _entry;
        private TransportBUS _bus;

        public TransportSearchEngine()
        {
            _bus = new TransportBUS();
            _entry = _bus.getEntries();
        }

        public IEnumerable<Transport> Search(string keyword)
        {
            List<DTO.Transport> rt = new List<DTO.Transport>();
            rt.AddRange(searchByName(keyword));
            rt = new List<DTO.Transport>(rt.Distinct()); // khử các phần tử trùng
            return rt;
        }

        private IEnumerable<Transport> searchByName(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(transport => regex.IsMatch(transport.name));
        }
    }
}
