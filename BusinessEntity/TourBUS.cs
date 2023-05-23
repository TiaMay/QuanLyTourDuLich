using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class TourBUS
    {
        UnitOfWork _unitOfWork;

        IEnumerable<TourSite> _toursites;
        IEnumerable<Destination> _destination;
        public TourBUS()
        {
            _unitOfWork = new UnitOfWork();
            _toursites = _unitOfWork.TourSiteRepository.GetAll();
            _destination=_unitOfWork.DestinationRepository.GetAll();
        }

        public IEnumerable<TourSite> getAllTourSites()
        {
            return _unitOfWork.TourSiteRepository.GetAll();
        }
        public IEnumerable<Destination> getAllDestination()
        {
            return _unitOfWork.DestinationRepository.GetAll();
        }


        public Tour getCustomerById(int id)
        {
            return _unitOfWork.TourRepository.GetByID(id);
        }

        public IEnumerable<Tour> getEntries()
        {
            return _unitOfWork.TourRepository.GetAll();
        }

        public void add(Tour tour)
        {
            // T-T
            //DAO.GenericRepository.GenericRepository<TourSite> repo 
            //    = _unitOfWork.createTourSiteRepo();
            //foreach (var item in tour.TourSites)
            //{
            //    repo.Update(item);
            //}
            //tour.TourSites = null;
            _unitOfWork.TourRepository.Insert(tour);
            _unitOfWork.Save();

            //_unitOfWork.DestinationRepository.
            //_unitOfWork.TourRepository.Refresh();
        }

        public void deletaById(int id)
        {
            _unitOfWork.TourRepository.Delete(id);
            _unitOfWork.Save();
        }
        public void delete(Tour tour)
        {
            _unitOfWork.TourRepository.Delete(tour);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.TourRepository.Exists(key);
        }

        public void update(Tour tour)
        {
            _unitOfWork.TourRepository.Update(tour);
            _unitOfWork.Save();
        }
        public void refresh()
        {
            _unitOfWork.TourRepository.Refresh();
        }

        public Tour getTourByTourGroup(TourGroup group)
        {
            return _unitOfWork.TourRepository.Get(tour => tour.id == group.tour_id);
        }

        public IEnumerable<Tour> getAllTourByName(string name)
        {
            return _unitOfWork.TourRepository.GetMany(tour => tour.name == name);
        }
    }
}
