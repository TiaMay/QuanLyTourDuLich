using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Views
{
    interface IHotelView
    {
        void updateHotelView(IEnumerable<Hotel> hotels);
    }
}
