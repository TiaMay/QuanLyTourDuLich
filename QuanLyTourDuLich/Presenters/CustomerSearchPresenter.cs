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
    class CustomerSearchPresenter : ICustomerSearchPresenter
    {
        private ICustomerSearchView _view;

        private CustomerBUS _bus;

        private SearchEngine<Customer> _customerSearch;
        private IEnumerable<Customer> _searchResult;


        public CustomerSearchPresenter(ICustomerSearchView view)
        {
            _view = view;
            _bus = new CustomerBUS();
            _customerSearch = new SearchEngine<Customer>();
        }

        public void performClickSearch(string keyword)
        {
            _customerSearch = new SearchEngine<Customer>();
            _searchResult = _customerSearch.Search(keyword);
            this.searchResult(_searchResult);
        }

        public void performClickSearch(string keyword, int tourId)
        {
            _searchResult = _customerSearch.Search(keyword);
            //_searchResult = _searchResult.Where(c => c.TourGroups.Any(t => t.id == tourId));
            this.searchResult(_searchResult);
        }

        public void searchResult(IEnumerable<Customer> result)
        {
            _view.updateSearchResultView(result);
        }

        public void sortIdColumn()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Customer>((c1, c2) => c1.id - c2.id);
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            this.searchResult(query);
        }

        public void sortNameColumn()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Customer>((c1, c2) => c1.name.CompareTo(c2.name));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            this.searchResult(query);
        }

        public void sortAddressColumn()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Customer>((c1, c2) => c1.address.CompareTo(c2.address));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            this.searchResult(query);
        }

        public void sortPhoneColumn()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Customer>((c1, c2) => c1.phone.CompareTo(c2.phone));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            this.searchResult(query);
        }

        public void sortGenderColumn()
        {
            if (_searchResult == null || _searchResult.Count() == 0)
                return;
            var comparasion = new Comparison<Customer>((c1, c2) => c1.gender.CompareTo(c2.gender));
            var query = _searchResult.ToList();
            query.Sort(comparasion);
            this.searchResult(query);
        }

        public void toggleCustomerTourGroupStatus( Customer  customer, TourGroup tourGroup)
        {
            var dummyCustomer = _bus.getCustomerById(customer.id);
            var dummyTourGroup = _bus.getTourGroupById(tourGroup.id);
            if (dummyCustomer.TourGroups.Contains(dummyTourGroup))
            {
                dummyCustomer.TourGroups.Remove(dummyTourGroup);
            }
            else
            {
                dummyCustomer.TourGroups.Add(dummyTourGroup);
            }
            _bus.update(dummyCustomer);
        }

        public void addPassengerToTourGroup(Customer customer, TourGroup tourGroup)
        {
            var dummyCustomer = _bus.getCustomerById(customer.id);
            var dummyTourGroup = _bus.getTourGroupById(tourGroup.id);
            if (dummyCustomer.TourGroups.Contains(dummyTourGroup) == false)
            {
                dummyCustomer.TourGroups.Add(dummyTourGroup);
            }
            _bus.update(dummyCustomer);
        }

        public void addPassengerToTourGroup(IEnumerable<Customer> customers, TourGroup tourGroup)
        {
            var group = _bus.getTourGroupById(tourGroup.id);

            foreach (var c in customers)
            {
                var cus = _bus.getCustomerById(c.id);
                if (group.Customers.Contains(cus) == false)
                {
                    group.Customers.Add(cus);
                }
            }
            //var cus = _bus.getCustomerById(customer.id);
            //var tourgroup = _bus.getTourGroupById(tourGroup.id);
            //if (cus.TourGroups.Contains(tourgroup) == false)
            //{
            //    cus.TourGroups.Add(tourgroup);
            //}
            _bus.update(group);
        }

        public void removePassengerFromTourGroup(Customer customer, TourGroup tourGroup)
        {
            var dummyCustomer = _bus.getCustomerById(customer.id);
            var dummyTourGroup = _bus.getTourGroupById(tourGroup.id);
            if (dummyCustomer.TourGroups.Contains(dummyTourGroup))
            {
                dummyCustomer.TourGroups.Remove(dummyTourGroup);
            }
            _bus.update(dummyCustomer);
        }

        public TourGroup getTourGroupById(int tourGroupId)
        {
            return _bus.getTourGroupById(tourGroupId);
        }

        public void insertCustomer(Customer customer)
        {
            _bus.add(customer);
        }

        public void deleteCustomer(Customer customer)
        {
            if (customer.TourGroups != null && customer.TourGroups.Count != 0)
                _view.deleteError(customer);
            else
            {
                _bus.deletaById(customer.id);
                loadAllCustomer();
            }
        }

        public void loadAllCustomer()
        {
            _searchResult = _bus.getEntries();
            _view.updateSearchResultView(_searchResult);
        }

        public void updateAll(IEnumerable<Customer> destinations)
        {
            foreach (var item in destinations)
            {
                _bus.update(item);
            }
            this.loadAllCustomer();
        }

        public void refresh()
        {
            _bus.refresh();
        }
    }

    class TourGroupComparer : IEqualityComparer<TourGroup>
    {

        public bool Equals(TourGroup x, TourGroup y)
        {
            return x.id == y.id;
        }

        public int GetHashCode(TourGroup obj)
        {
            return obj.id.GetHashCode();
        }
    }
}
