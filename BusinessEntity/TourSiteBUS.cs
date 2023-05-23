using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class TourSiteBUS
    {
        UnitOfWork _unitOfWork = new DAO.UnitOfWork();

        public TourSite getTourSiteId(int id)
        {
            return _unitOfWork.TourSiteRepository.GetByID(id);
        }

        public IEnumerable<TourSite> getEntries()
        {
            return _unitOfWork.TourSiteRepository.GetAll();
        }

        public void add(TourSite toursite)
        {
            _unitOfWork.TourSiteRepository.Insert(toursite);
            _unitOfWork.Save();
        }

        public void deletaById(int id)
        {
            _unitOfWork.TourSiteRepository.Delete(id);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.TourSiteRepository.Exists(key);
        }

        public void update(TourSite toursite)
        {
            _unitOfWork.TourSiteRepository.Update(toursite);
            _unitOfWork.Save();
        }

        public IEnumerable<TourSite> getByDestination(int destinationId)
        {
            return _unitOfWork.TourSiteRepository.GetMany(toursite => toursite.destination_id == destinationId);
        }

        public void refresh()
        {
            _unitOfWork.TourSiteRepository.Refresh();
        }
    }
}
