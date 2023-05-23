using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity.SearchEngine
{
    class CustomerSearchEngine : ISearchAble<DTO.Customer>
    {
        private IEnumerable<DTO.Customer> _entry;
        private CustomerBUS _bus;

        public CustomerSearchEngine()
        {
            init();
        }

        public IEnumerable<DTO.Customer> Search(string keyword)
        {
            List<DTO.Customer> rt = new List<DTO.Customer>();
            rt.AddRange(searchByName(keyword));
            rt.AddRange(searchByAddress(keyword));
            rt.AddRange(searchByPhone(keyword));
            rt.AddRange(searchByIdentifyNumber(keyword));
            rt.AddRange(searchByNationality(keyword));
            rt = new List<DTO.Customer>(rt.Distinct()); // khử các phần tử trùng
            return rt;
        }

        private IEnumerable<DTO.Customer> searchByNationality(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(customer => regex.IsMatch(customer.nationality));
        }

        private IEnumerable<DTO.Customer> searchByIdentifyNumber(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(customer => regex.IsMatch(customer.identifiedcard_id));
        }

        private IEnumerable<DTO.Customer> searchByName(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(customer => regex.IsMatch(customer.name));
        }

        private IEnumerable<DTO.Customer>  searchByAddress(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(customer => regex.IsMatch(customer.address));
        }

        private IEnumerable<DTO.Customer> searchByPhone(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(customer => regex.IsMatch(customer.phone));
        }

        public void refresh()
        {
            init();
        }

        private void init()
        {
            _bus = new CustomerBUS();
            _entry = _bus.getEntries();
        }
    }

}
