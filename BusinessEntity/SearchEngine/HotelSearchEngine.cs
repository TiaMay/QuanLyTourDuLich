using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity.SearchEngine
{
    class HotelSearchEngine : ISearchAble<Hotel>
    {
        private IEnumerable<DTO.Hotel> _entry;
        private HotelBUS _bus;

        public HotelSearchEngine()
        {
            _bus = new HotelBUS();
            _entry = _bus.getEntries();
        }

        public IEnumerable<Hotel> Search(string keyword)
        {
            List<DTO.Hotel> rt = new List<DTO.Hotel>();
            rt.AddRange(searchByName(keyword));
            rt.AddRange(searchByAddress(keyword));
            rt.AddRange(searchByPhone(keyword));
            rt = new List<DTO.Hotel>(rt.Distinct()); // khử các phần tử trùng
            return rt;
        }

        private IEnumerable<Hotel> searchByName(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(hotel => regex.IsMatch(hotel.name));
        }

        private IEnumerable<Hotel> searchByPhone(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(hotel => regex.IsMatch(hotel.phone));
        }

        private IEnumerable<Hotel> searchByAddress(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(hotel => regex.IsMatch(hotel.address));
        }

        public void refresh()
        {
            _bus = new HotelBUS();
        }

    }
}
