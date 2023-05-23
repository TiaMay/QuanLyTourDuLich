using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class ConstantBUS
    {
        static UnitOfWork _unitOfWork = new UnitOfWork();

        public static string getString(string key, string def = "")
        {
            var tempValue = _unitOfWork.ConstantRepository.GetFirst(constant => constant.key == key);
            if (tempValue != null)
            {
                return tempValue.value;
            }
            else
            {
                return def;
            }
        }

        public static float getFloat(string key, float def = 0.0f)
        {
            var tempValue = _unitOfWork.ConstantRepository.GetFirst(constant => constant.key == key);
            if (tempValue != null)
            {
                if( float.TryParse(tempValue.value,out def))
                {
                    return float.Parse(tempValue.value);
                }
                return def;
            }
            else
            {
                return def;
            }
        }

        private ConstantBUS()
        {

        }
    }
}
