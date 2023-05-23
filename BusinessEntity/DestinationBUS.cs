using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class DestinationBUS
    {
        UnitOfWork _unitOfWork = new DAO.UnitOfWork();


        public Destination getCustomerById(int id)
        {
            return _unitOfWork.DestinationRepository.GetByID(id);
        }

        public IEnumerable<Destination> getEntries()
        {
            return _unitOfWork.DestinationRepository.GetAll();
        }

        public void add(Destination destination)
        {
            _unitOfWork.DestinationRepository.Insert(destination);
            _unitOfWork.Save();
        }

        public void deletaById(int id)
        {
            _unitOfWork.DestinationRepository.Delete(id);
            _unitOfWork.Save();
        }

        public void delete(Destination destination)
        {
            if (destination.Tours != null && destination.Tours.Count != 0)
            {
                
            }
            if (destination.TourSites != null)
            {
                _unitOfWork.TourSiteRepository.Delete(toursite => toursite.destination_id == destination.id);
            }
            if (destination.Hotels != null)
            {
                _unitOfWork.HotelRepository.Delete(hotel => hotel.destination_id == destination.id);
            }
            _unitOfWork.DestinationRepository.Delete(destination.id);
            _unitOfWork.Save();
        }


        public bool isExists(int key)
        {
            return _unitOfWork.DestinationRepository.Exists(key);
        }

        public void update(Destination destination)
        {
            _unitOfWork.DestinationRepository.Update(destination);
            _unitOfWork.Save();
        }

        public void refresh()
        {
            _unitOfWork.DestinationRepository.Refresh();
        }

    }
}
