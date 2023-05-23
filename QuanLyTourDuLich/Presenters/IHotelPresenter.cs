using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    interface IHotelPresenter
    {
        void loadHotelByDestinationId(int destinationid);

        void addHotel(DTO.Hotel hotel);

        void deleteHotel(DTO.Hotel toursite);

        void updateAllHotels(IEnumerable<DTO.Hotel> toursites);

        void refresh();

        void search(string keyword, int p);
    }
}
