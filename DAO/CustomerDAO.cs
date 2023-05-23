using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    class CustomerDAO : BaseConnection
    {
        public DTO.Customer getCustomer(int id)
        {
            var customerRow = _dataSet.Customer.FindByid(id.ToString());
            return new DTO.Customer
            {
                id = customerRow.id
            };
        }
    }
}
