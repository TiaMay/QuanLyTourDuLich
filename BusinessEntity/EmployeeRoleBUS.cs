using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class EmployeeRoleBUS
    {
        UnitOfWork _unitOfWork = new UnitOfWork();

        public IEnumerable<EmployeeRole> getEntries()
        {
            return _unitOfWork.EmployeeRoleRepository.GetAll();
        }

        public EmployeeRole getById(int id)
        {
            return _unitOfWork.EmployeeRoleRepository.GetByID(id);
        }
    }
}
