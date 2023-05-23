using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BusinessEntity
{
    public class AccountTypeBUS
    {
        UnitOfWork _unitOfWork = new UnitOfWork();

        /// <summary>
        /// Trả về các account type theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AccountType getAccountTypeById(int id)
        {
            return _unitOfWork.AccountTypeRepository.GetByID(id);
        }

        /// <summary>
        /// Trả về tất cả account type
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AccountType> getEntries()
        {
            return _unitOfWork.AccountTypeRepository.GetAll();
        }

        /// <summary>
        /// Thêm 1 account type
        /// </summary>
        /// <param name="account"></param>
        public void add(AccountType accountType)
        {
            _unitOfWork.AccountTypeRepository.Insert(accountType);
            _unitOfWork.Save();
        }

        /// <summary>
        /// Xóa account type theo id : Warning
        /// </summary>
        /// <param name="id"></param>
        public void deleteById(int id)
        {
            _unitOfWork.AccountTypeRepository.Delete(id);
            _unitOfWork.Save();
        }

        /// <summary>
        /// Update account type
        /// </summary>
        /// <param name="account"></param>
        public void update(AccountType accountType)
        {
            _unitOfWork.AccountTypeRepository.Update(accountType);
            _unitOfWork.Save();
        }

        /// <summary>
        /// Kiẻm tra tồn tại theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool isExist(int id)
        {
            return _unitOfWork.AccountTypeRepository.Exists(id);
        }
    }
}
