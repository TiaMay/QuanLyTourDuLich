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
    class HotelPresenter : IHotelPresenter
    {
        HotelBUS _bus;
        IHotelView _view;
        IEnumerable<Hotel> _hotels;

        SearchEngine<Hotel> _searchEngine;

        public HotelPresenter(IHotelView view)
        {
            _view = view;
            _bus = new HotelBUS();
            _searchEngine = new SearchEngine<Hotel>();
        }

        public void loadHotelByDestinationId(int destinationid)
        {
            _hotels = _bus.getByDestination(destinationid);
            _view.updateHotelView(_hotels);
        }

        public void addHotel(DTO.Hotel hotel)
        {
            _bus.add(hotel);
            loadHotelByDestinationId(hotel.destination_id);
        }

        public void deleteHotel(DTO.Hotel hotel)
        {
            _bus.deletaById(hotel.id);
        }

        public void updateAllHotels(IEnumerable<DTO.Hotel> toursites)
        {
            foreach (var item in toursites)
            {
                _bus.update(item);
            }
        }

        public void refresh()
        {
            _bus.refresh();
        }

        public void search(string keyword, int destinationId)
        {
            var searchRs = _searchEngine.Search(keyword);
            var query = searchRs.Where(hotel => hotel.destination_id == destinationId);
            _view.updateHotelView(query);
        }

    }
}
