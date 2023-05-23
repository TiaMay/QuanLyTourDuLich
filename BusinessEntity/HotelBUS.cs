using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class HotelBUS
    {
        UnitOfWork _unitOfWork = new DAO.UnitOfWork();

        public Hotel getHotelById(int id)
        {
            return _unitOfWork.HotelRepository.GetByID(id);
        }

        public Hotel getHotelByDesId(Destination des)
        {
            return _unitOfWork.HotelRepository.Get(ht => ht.destination_id == des.id);
        }

        public IEnumerable<Hotel> getEntries()
        {
            return _unitOfWork.HotelRepository.GetAll();
        }

        public void add(Hotel hotel)
        {
            _unitOfWork.HotelRepository.Insert(hotel);
            _unitOfWork.Save();
        }

        public void deletaById(int id)
        {
            _unitOfWork.HotelRepository.Delete(id);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.HotelRepository.Exists(key);
        }

        public void update(Hotel hotel)
        {
            _unitOfWork.HotelRepository.Update(hotel);
            _unitOfWork.Save();
        }

        public IEnumerable<Hotel> getByDestination(int destinationId)
        {
            return _unitOfWork.HotelRepository.GetMany(toursite => toursite.destination_id == destinationId);
        }

        public void refresh()
        {
            _unitOfWork.TourSiteRepository.Refresh();
        }
    }
}
