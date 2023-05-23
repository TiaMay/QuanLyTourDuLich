using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BusinessEntity
{
    public class TourGroupFeeBUS
    {
        UnitOfWork _unitOfWork = new UnitOfWork();

        public TourGroupFee getTourGroupFeeById(int id)
        {
            return _unitOfWork.TourGroupFeeRepository.GetByID(id);
        }

        public TourGroupFee getTourGroupFeeByTG(TourGroup tg)
        {
            return _unitOfWork.TourGroupFeeRepository.Get(f => f.tourgroup_id == tg.id);
        }

        public IEnumerable<TourGroupFee> getEntries()
        {
            return _unitOfWork.TourGroupFeeRepository.GetAll();
        }

        public void add(TourGroupFee tourGroupFee)
        {
            _unitOfWork.TourGroupFeeRepository.Insert(tourGroupFee);
            _unitOfWork.Save();
        }

        public void deleteById(int id)
        {
            _unitOfWork.TourGroupFeeRepository.Delete(id);
            _unitOfWork.Save();
        }

        public void update(TourGroupFee tourGroupFee)
        {
            _unitOfWork.TourGroupFeeRepository.Update(tourGroupFee);
            _unitOfWork.Save();
        }

        public bool isExist(int id)
        {
            return _unitOfWork.TourGroupFeeRepository.Exists(id);
        }

    }
}
