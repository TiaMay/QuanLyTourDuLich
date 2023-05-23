using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class TourPriceBUS
    {
        UnitOfWork _unitOfWork = new DAO.UnitOfWork();
        private static DateTime MinDate = new DateTime(2000, 1, 1);
        private static DateTime MaxDate = new DateTime(2100, 1, 1);

        public TourPrice getCustomerById(int id)
        {
            return _unitOfWork.TourPriceRepository.GetByID(id);
        }

        public IEnumerable<TourPrice> getEntries()
        {
            return _unitOfWork.TourPriceRepository.GetAll();
        }

        public void add(TourPrice tourprice)
        {
            _unitOfWork.TourPriceRepository.Insert(tourprice);
            _unitOfWork.Save();
        }
        
        public int addWithoutId(TourPrice tourprice)
        {
            _unitOfWork.TourPriceRepository.Insert(tourprice);
            _unitOfWork.Save();
            return tourprice.id;
        }

        public void deletaById(int id)
        {
            _unitOfWork.TourPriceRepository.Delete(id);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.TourPriceRepository.Exists(key);
        }

        public void update(TourPrice price)
        {
            _unitOfWork.TourPriceRepository.Update(price);
            _unitOfWork.Save();
        }

        public float getMinPrice()
        {
            return (int) _unitOfWork.TourPriceRepository.GetAll().Min(p => p.price);
        }

        public float getMaxPrice()
        {
            return (int)_unitOfWork.TourPriceRepository.GetAll().Max(p => p.price);
        }

        public DateTime getMinStartDate()
        {
            var entries = _unitOfWork.TourPriceRepository.GetAll();
            if (entries.Count() == 0)
                return MinDate;
            return entries.Min(tourPrice => tourPrice.start_date);
        }

        public DateTime getMaxStartDate()
        {
            var entries = _unitOfWork.TourPriceRepository.GetAll();
            if (entries.Count() == 0)
                return MaxDate;
            return entries.Max(tourPrice => tourPrice.start_date);
        }

    }
}
