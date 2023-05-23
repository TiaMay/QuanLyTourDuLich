using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity.SearchEngine
{
    class EmployeeSearchEngine : ISearchAble<DTO.Employee>
    {
        private IEnumerable<DTO.Employee> _entry;
        private EmployeeBUS _bus;

        public EmployeeSearchEngine()
        {
            _bus = new EmployeeBUS();
            _entry = _bus.getEntries();
        }

        public IEnumerable<DTO.Employee> Search(string keyword)
        {
            List<DTO.Employee> rt = new List<DTO.Employee>();
            rt.AddRange(searchByName(keyword));
            rt.AddRange(searchByRole(keyword));
            rt = new List<DTO.Employee>(rt.Distinct()); // khử các phần tử trùng
            return rt;
        }

        private IEnumerable<DTO.Employee> searchByRole(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(emp => regex.IsMatch(emp.EmployeeRole.name));
        }

        private IEnumerable<DTO.Employee> searchByName(string keyword)
        {
            var regex = RegexProxy.getInstance().getRegex(keyword);
            return _entry.Where(emp => regex.IsMatch(emp.name));
        }


    }
}
