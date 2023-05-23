using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Views
{
    interface ICustomerSearchView
    {
        void updateSearchResultView(IEnumerable<DTO.Customer> searchResult);


        void deleteError(DTO.Customer customer);
    }
}
