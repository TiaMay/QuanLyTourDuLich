using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class EmployeeTourGroupBUS
    {
        TourManagerEntities _context = new TourManagerEntities();

        public IEnumerable<GetAllEmployeeTourGroup_Result> getAllEmployeeTourGroup()
        {
            return _context.GetAllEmployeeTourGroup();
        }

        public void addEmployeeTourGroup(int employee_id, int tourgroup_id)
        {
            _context.addEmployeeTourGroup(employee_id, tourgroup_id);
        }

        public void deleteEmployeeTourGroup(int employee_id, int tourgroup_id)
        {
            _context.deleteEmployeeTransport(employee_id, tourgroup_id);
        }
    }
}
