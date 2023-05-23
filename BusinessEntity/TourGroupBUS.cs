using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class TourGroupBUS
    {
        UnitOfWork _unitOfWork = new UnitOfWork();
        IEnumerable<Customer> _passengers;

        private static DateTime MinDate = new DateTime(2000, 1, 1);
        private static DateTime MaxDate = new DateTime(2100, 1, 1);


        public TourGroup getCustomerById(int id)
        {
            return _unitOfWork.TourGroupRepository.GetByID(id);
        }

        public IEnumerable<Customer> getAllCustomers()
        {
            return _unitOfWork.CustomerRepository.GetAll();
        }

        public IEnumerable<Customer> getCustomerInTourGroup(int tourGroupid)
        {
            return _unitOfWork.CustomerRepository.GetMany(c => c.TourGroups.Any(group => group.id == tourGroupid));
        }

        public IEnumerable<TourGroup> getEntries()
        {
            return _unitOfWork.TourGroupRepository.GetAll();
        }

        public void add(TourGroup tourGroup)
        {
            _unitOfWork.TourGroupRepository.Insert(tourGroup);
            _unitOfWork.Save();
        }

        public void deletaById(int id)
        {
            _unitOfWork.TourGroupRepository.Delete(id);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.TourGroupRepository.Exists(key);
        }

        public void update(TourGroup tourGroup)
        {
            _unitOfWork.TourGroupRepository.Update(tourGroup);
            _unitOfWork.Save();
        }

        public DateTime getMinDepartDate()
        {
            var entries = _unitOfWork.TourGroupRepository.GetAll();
            if (entries.Count() == 0)
                return TourGroupBUS.MinDate;
            return entries.Min(group => group.depart_date);
        }

        public DateTime getMaxReturnDate()
        {
            var entries = _unitOfWork.TourGroupRepository.GetAll();
            if (entries.Count() == 0)
                return TourGroupBUS.MaxDate;
            return entries.Max(group => group.return_date);
        }

        public IEnumerable<TourGroup> getTourGroupByTour(Tour tour)
        {
            return _unitOfWork.TourGroupRepository.GetMany(tourgroup => tourgroup.tour_id == tour.id);
        }

        public IEnumerable<TourGroup> getAllTourGroupByName(string name)
        {
            return _unitOfWork.TourGroupRepository.GetMany(tourgroup => tourgroup.name == name);
        }

        public DateTime getMaxDepartDate()
        {
            var entries = _unitOfWork.TourGroupRepository.GetAll();
            if (entries.Count() == 0)
                return TourGroupBUS.MaxDate;
            return entries.Max(group => group.depart_date);
        }

        public TourGroup getTourGroupById(int tourGroupId)
        {
            return _unitOfWork.TourGroupRepository.GetByID(tourGroupId);
        }

        public IEnumerable<Employee> getEmployeeInTourGroup(int tourGroupId)
        {
            return _unitOfWork.EmplyeeRepository.GetMany(c => c.TourGroups.Any(group => group.id == tourGroupId));
        }

        public IEnumerable<Transport> getTransportInTourGroup(int tourGroupId)
        {
            return _unitOfWork.TransportRepository.GetMany(c => c.TransportsTourGroups.Any(group => group.tour_group_id == tourGroupId));
        }

        public void removeTourGroupPassenger(int tourGroupId, int passengerId)
        {
            //_unitOfWork.TourGroupRepository.
        }

        public void removeTransportInTourGroup(int tourGroupId, int transportId)
        {
            _unitOfWork.TransportTourGroupRepository.Delete(t => t.tour_group_id == tourGroupId && t.transport_id == transportId);
            _unitOfWork.Save();
        }
    }
}
