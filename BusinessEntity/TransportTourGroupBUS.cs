using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class TransportTourGroupBUS
    {
        TourManagerEntities _context = new TourManagerEntities();

        public IEnumerable<GetAllTransportTourGroup_Result> getAllTransportTourGroup()
        {
            return _context.GetAllTransportTourGroup();
        }

        public void addTransportTourGroup(int transport_id, int tourgroup_id)
        {
            _context.addTransportTourGroup(transport_id, tourgroup_id);
        }

        public void deleteTransportTourGroup(int transport_id, int tourgroup_id)
        {
            _context.deleteTransportTourGroup(transport_id, tourgroup_id);
        }
    }
}
