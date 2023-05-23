using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class TransportBUS
    {
        UnitOfWork _unitOfWork = new DAO.UnitOfWork();
        public Transport getCustomerById(int id)
        {
            return _unitOfWork.TransportRepository.GetByID(id);
        }

        public IEnumerable<Transport> getEntries()
        {
            return _unitOfWork.TransportRepository.GetAll();
        }

        public void add(Transport transport)
        {
            _unitOfWork.TransportRepository.Insert(transport);
            _unitOfWork.Save();
        }

        public void deletaById(int id)
        {
            _unitOfWork.TransportRepository.Delete(id);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.TransportRepository.Exists(key);
        }

        public void update(Transport transport)
        {
            _unitOfWork.TransportRepository.Update(transport);
            _unitOfWork.Save();
        }


        public IEnumerable<Transport> getTransportTourGroup()
        {
            return _unitOfWork
                .TransportRepository
                .GetMany(transport => (transport.TransportsTourGroups != null && transport.TransportsTourGroups.Count != 0));
            //return _unitOfWork
            //    .TransportRepository
            //    .GetMany(transport => (transport.TourGroups != null && transport.TourGroups.Count != 0));
        }

        public TourGroup loadTourGroupId(int tourgroupId)
        {
            return _unitOfWork.TourGroupRepository.GetByID(tourgroupId);
        }

        public double getTotaltTransportFee(int tourgroupid)
        {
            return 0.0;
            //var transport = _unitOfWork.TourGroupRepository.GetByID(tourgroupid);
            //var tempSum = transport.Transports.Sum(t => t.price);
            //return Math.Round((double)tempSum);
        }

        public void update(TourGroup _tourGroup)
        {
            _unitOfWork.TourGroupRepository.Update(_tourGroup);
            _unitOfWork.Save();
        }

        public void update(TourGroupFee tourGroupFee)
        {
            _unitOfWork.TourGroupFeeRepository.Update(tourGroupFee);
            _unitOfWork.Save();
        }

        public void add(TourGroupFee tourGroupFee)
        {
            _unitOfWork.TourGroupFeeRepository.Insert(tourGroupFee);
            _unitOfWork.Save();
        }

        public bool isExistsTransportFee(int tourGroupId, int transportId)
        {
            return _unitOfWork.TransportTourGroupRepository.Get(
                trans => trans.tour_group_id == tourGroupId && trans.transport_id == transportId)!=null;
        }

        public TransportsTourGroup getTransportTourGroupFee(int tourGroupId, int transportId)
        {
            return _unitOfWork.TransportTourGroupRepository.Get(
                trans => trans.tour_group_id == tourGroupId && trans.transport_id == transportId);
        }

        public double loadTotalTransportFee(int tourGroupid)
        {
            return _unitOfWork.TransportTourGroupRepository.GetAll().Where(
                t => t.tour_group_id == tourGroupid).Sum(transport => transport.fee);
        }

        public void removeTransportFee(int tourGroupId, int transportId)
        {
            _unitOfWork.TransportTourGroupRepository.Delete(
                t => t.tour_group_id == tourGroupId && t.transport_id == transportId);
            _unitOfWork.Save();
        }

        public void insertTransportFee(int tourGroupId, int transportId)
        {
            var newItem = new TransportsTourGroup();
            newItem.transport_id = transportId;
            newItem.tour_group_id = tourGroupId;

            var originPrice = _unitOfWork.TransportRepository.GetByID(transportId).price.Value;
            newItem.fee = (originPrice += originPrice *
                ConstantBUS.getFloat("transport_interest_rate"));
            _unitOfWork.TransportTourGroupRepository.Insert(newItem);
            _unitOfWork.Save();
        }
    }
}
