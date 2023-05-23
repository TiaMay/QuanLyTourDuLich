using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class PassengerBUS
    {
        TourManagerEntities _context = new TourManagerEntities();

        public IEnumerable<GetAllPassengers_Result> getCustomersByTourGroupId(int id)
        {
            return _context.GetCustomersByTourGroupId(id);
        }

        public IEnumerable<GetAllPassengers_Result> getEntries()
        {
            return _context.GetAllPassengers();
        }

        public void addPassenger(int customer_id, int tourgroup_id)
        {
            _context.addPassenger(customer_id, tourgroup_id);
        }

        public void deletePassenger(int customer_id, int tourgroup_id)
        {
            _context.deletePassenger(customer_id, tourgroup_id);
        }
    }
}
