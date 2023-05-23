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
    class EmployeePresenter : IEmployeePresenter
    {
        IEmployeeView _view;

        EmployeeBUS _bus;

        SearchEngine<Employee> _searchEngine;

        public EmployeePresenter(IEmployeeView view)
        {
            _view = view;
            _bus = new EmployeeBUS();
            //_searchEngine = new SearchEngine<Employee>();
        }

        public DTO.TourGroup loadTourGroupById(int tourGroupId)
        {
            return _bus.getTourGroupById(tourGroupId);
        }

        public void search(string keyword)
        {
            _searchEngine = new SearchEngine<Employee>();
            var employees = _searchEngine.Search(keyword);
            _view.updateEmployeeView(employees);
        }

        public void addPassengerToTourGroup(DTO.Employee employee, DTO.TourGroup tourGroup)
        {
            var dummyEmpl = _bus.getEmployeeById(employee.id);
            var dummyTourGr = _bus.getTourGroupById(tourGroup.id);

            if (dummyEmpl.TourGroups.Contains(dummyTourGr) == false)
            {
                dummyEmpl.TourGroups.Add(dummyTourGr);
            }
            _bus.update(dummyEmpl);
        }

        public void toggleCustomerTourGroupStatus(DTO.Employee employee, DTO.TourGroup tourGroup)
        {
            var dummyEmpl = _bus.getEmployeeById(employee.id);
            var dummyTourGr = _bus.getTourGroupById(tourGroup.id);

            if (dummyEmpl.TourGroups.Contains(dummyTourGr))
            {
                dummyEmpl.TourGroups.Remove(dummyTourGr);
            }
            else
            {
                dummyEmpl.TourGroups.Add(dummyTourGr);
            }
            _bus.update(dummyEmpl);
        }

        public void removePassengerFromTourGroup(DTO.Employee emp, DTO.TourGroup tourGroup)
        {
            var dummyEmpl = _bus.getEmployeeById(emp.id);
            var dummyTourGr = _bus.getTourGroupById(tourGroup.id);
            if (dummyEmpl.TourGroups.Contains(dummyTourGr))
            {
                dummyEmpl.TourGroups.Remove(dummyTourGr);
            }
            _bus.update(dummyEmpl);
        }
    }
}
