using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Views
{
    interface IEmployeeView
    {

        void updateEmployeeView(IEnumerable<DTO.Employee> employees);
    }
}
