using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class TourCategoryBUS
    {
        UnitOfWork _unitOfWork = new UnitOfWork();

        public TourCategory getCustomerById(int id)
        {
            return _unitOfWork.TourCategoryRepository.GetByID(id);
        }

        public IEnumerable<TourCategory> getEntries()
        {
            return _unitOfWork.TourCategoryRepository.GetAll();
        }

        public void add(TourCategory category)
        {
            _unitOfWork.TourCategoryRepository.Insert(category);
            _unitOfWork.Save();
        }

        public void deletaById(int id)
        {
            _unitOfWork.TourCategoryRepository.Delete(id);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.TourCategoryRepository.Exists(key);
        }

        public void update(TourCategory category)
        {
            _unitOfWork.TourCategoryRepository.Update(category);
            _unitOfWork.Save();
        }

    }
}
