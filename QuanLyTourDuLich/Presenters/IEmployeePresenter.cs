using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    interface IEmployeePresenter
    {

        DTO.TourGroup loadTourGroupById(int _touGroupId);

        void search(string keyword);

        void addPassengerToTourGroup(DTO.Employee employee, DTO.TourGroup _tourGroup);

        void toggleCustomerTourGroupStatus(DTO.Employee employee, DTO.TourGroup _tourGroup);

        void removePassengerFromTourGroup(DTO.Employee emp, DTO.TourGroup _tourGroup);
    }
}
