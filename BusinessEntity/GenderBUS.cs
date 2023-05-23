using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BusinessEntity
{
    public class GenderBUS
    {
        UnitOfWork _unitOfWork = new DAO.UnitOfWork();

        public Gender getGenderById(int id)
        {
            return _unitOfWork.GenderRepository.GetByID(id);
        }

        public string getGenderStrById(int id)
        {
            return _unitOfWork.GenderRepository.GetByID(id).ToString();
        }
    }
}
