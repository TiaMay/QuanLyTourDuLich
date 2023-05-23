using BusinessEntity;
using BusinessEntity.SearchEngine;
using DTO;
using QuanLyTourDuLich.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    class TransportPresenter : ITransportPresenter
    {
        TransportBUS _bus;

        ITransportView _view;

        IEnumerable<Transport> _transports;

        SearchEngine<Transport> _searchEngine;

        public TransportPresenter(ITransportView view)
        {
            _view = view;
            _bus = new TransportBUS();
        }

        public void loadAllTransports()
        {
            _transports = _bus.getEntries();
            _view.upateTransportsView(_transports);
        }

        public void loadAllActiveTransports()
        {
            _transports = _bus.getTransportTourGroup();
            _view.upateTransportsView(_transports);
        }

        public DTO.TourGroup loadTourGroupById(int tourgroupId)
        {
            return _bus.loadTourGroupId(tourgroupId);
        }

        public void search(string keyword)
        {
            _searchEngine = new SearchEngine<Transport>();
            var result = _searchEngine.Search(keyword);
            _view.upateTransportsView(result);
        }

        public void toggleTransportTourGroupStatus(DTO.Transport transport, DTO.TourGroup tourGroup)
        {
            //var dummyTransport = _bus.getCustomerById(transport.id);
            //var dummyTourGroup = _bus.loadTourGroupId(tourGroup.id);
            if (_bus.isExistsTransportFee(tourGroup.id, transport.id))
            {
                _bus.removeTransportFee(tourGroup.id, transport.id);
            }
            else
            {
                _bus.insertTransportFee(tourGroup.id, transport.id);
            }
            //_bus.update(dummyTransport);
        }

        public void addTransportToTourGroup(DTO.Transport transport, DTO.TourGroup tourGroup)
        {
            if (_bus.isExistsTransportFee(tourGroup.id, transport.id) == false)
            {
                _bus.insertTransportFee(tourGroup.id, transport.id);
            }
            //var dummyCustomer = _bus.getCustomerById(transport.id);
            //var dummyTourGroup = _bus.loadTourGroupId(tourGroup.id);
            //if (dummyCustomer.TourGroups.Contains(dummyTourGroup) == false)
            //{
            //    dummyCustomer.TourGroups.Add(dummyTourGroup);
            //}
            //_bus.update(dummyCustomer);
        }

        public void removeTransportFromTourGroup(DTO.Transport transport, DTO.TourGroup tourGroup)
        {
            if (_bus.isExistsTransportFee(tourGroup.id, transport.id))
            {
                _bus.removeTransportFee(tourGroup.id, transport.id);
            }
            //var dummyTransport = _bus.getCustomerById(transport.id);
            //var dummyTourGroup = _bus.loadTourGroupId(tourGroup.id);
            //if (dummyTransport.TourGroups.Contains(dummyTourGroup))
            //{
            //    dummyTransport.TourGroups.Remove(dummyTourGroup);
            //}
            //_bus.update(dummyTransport);
        }
        public double getTotalTransportFee(int tourgroupid)
        {
            return _bus.getTotaltTransportFee(tourgroupid);
        }

        public void updateTourGroup(DTO.TourGroup _tourGroup)
        {
            
            _bus.update(_tourGroup);
        }

        public void addTourGroupFee(DTO.TourGroupFee tourGroupFee)
        {
            _bus.add(tourGroupFee);
        }

        public bool isExistsTransportFee(int tourGroupId, int transportId)
        {
            return _bus.isExistsTransportFee(tourGroupId, transportId);
        }

        public double getTransportTourGroupFee(int tourGroupId, int transportId)
        {
            var transportTourGroup = _bus.getTransportTourGroupFee(tourGroupId, transportId);
            if (transportTourGroup == null)
                return 0.0;
            return transportTourGroup.fee;
        }

        public float loadTotalTransportFee(int tourGroupid)
        {
            return (float)_bus.loadTotalTransportFee(tourGroupid);
        }

    }
}
