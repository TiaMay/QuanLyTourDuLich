using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Views
{
    interface IDestinationView
    {
        void updateDestinationView(IEnumerable<Destination> destinations);

        void showDialog(string msg);

        void updateDestinationError();
    }
}
