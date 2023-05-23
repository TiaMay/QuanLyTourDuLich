using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BusinessEntity
{
    ///
    /// Một lớp bus cơ bản thì có 5 hàm là GetById, GetAll, add, delete, update.
    /// Nếu cần loại xử lý nào thêm thì viết thêm hàm cho nó.
    ///

    public class CustomerBUS
    {
        UnitOfWork _unitOfWork = new DAO.UnitOfWork();

        public Customer getCustomerById(int id)
        {
            return _unitOfWork.CustomerRepository.GetByID(id);
        }

        public IEnumerable<Customer> getEntries()
        {
            return _unitOfWork.CustomerRepository.GetAll();
        }

        public void add(Customer customer)
        {
            _unitOfWork.CustomerRepository.Insert(customer);
            _unitOfWork.Save();
        }

        public void deletaById(int id)
        {
            _unitOfWork.CustomerRepository.Delete(id);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.CustomerRepository.Exists(key);
        }
        
        public void update(Customer customer)
        {
            _unitOfWork.CustomerRepository.Update(customer);
            _unitOfWork.Save();
        }

        public void GetSomeThingSpecial()
        {
            //_unitOfWork.CustomerRepository.GetFirst(c => c.name == "Tung");
            //_unitOfWork.CustomerRepository.GetMany(c => c.id > 11);
        }

        public TourGroup getTourGroupById(int tourGroupId)
        {
            return _unitOfWork.TourGroupRepository.GetByID(tourGroupId);
        }

        public void update(TourGroup group)
        {
            _unitOfWork.TourGroupRepository.Update(group);
        }

        public void refresh()
        {
            _unitOfWork.CustomerRepository.Refresh();
        }
    }
}
