using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    interface ICustomerSearchPresenter
    {
        void performClickSearch(string keyword);

        void performClickSearch(string keyword, int tourId);

        void searchResult(IEnumerable<Customer> result);

        void sortIdColumn();

        void sortNameColumn();

        void sortAddressColumn();

        void sortPhoneColumn();

        void sortGenderColumn();

        void toggleCustomerTourGroupStatus(Customer customer, TourGroup tourGroupId);

        TourGroup getTourGroupById(int p);

        void addPassengerToTourGroup(Customer customer, TourGroup _tourGroup);
        void addPassengerToTourGroup(IEnumerable<Customer> customers, TourGroup tourGroup);

        void removePassengerFromTourGroup(Customer customer, TourGroup _tourGroup);

        void insertCustomer(Customer customer);

        void deleteCustomer(Customer customer);

        void loadAllCustomer();

        void updateAll(IEnumerable<Customer> destinations);

        void refresh();
    }
}
