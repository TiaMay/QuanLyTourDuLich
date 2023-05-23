using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    interface ITransportPresenter
    {
        void loadAllTransports();
        
        // load transport has tourgroup
        void loadAllActiveTransports();

        DTO.TourGroup loadTourGroupById(int _tourgroupId);

        void search(string keyword);

        void toggleTransportTourGroupStatus(DTO.Transport transport, DTO.TourGroup _tourGroup);

        void addTransportToTourGroup(DTO.Transport transport, DTO.TourGroup _tourGroup);

        void removeTransportFromTourGroup(DTO.Transport transport, DTO.TourGroup _tourGroup);

        double getTotalTransportFee(int tourgroupid);

        void updateTourGroup(DTO.TourGroup _tourGroup);

        void addTourGroupFee(DTO.TourGroupFee tourGroupFee);

        bool isExistsTransportFee(int tourGroupId, int transportId);

        double getTransportTourGroupFee(int tourGroupId, int transportId);

        float loadTotalTransportFee(int tourGroupId);
    }
}
