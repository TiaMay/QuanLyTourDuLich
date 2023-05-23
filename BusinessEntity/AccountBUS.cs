using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BusinessEntity
{
    public class AccountBUS
    {
        UnitOfWork _unitOfWork = new UnitOfWork();

        /// <summary>
        /// Trả về các account theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Account getAccountById(int id)
        {
            return _unitOfWork.AccountRepository.GetByID(id);
        }

        /// <summary>
        /// Trả về account theo tên tài khoản
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public Account getAccountByUsername(string str)
        {
            return _unitOfWork.AccountRepository.Get(account => account.username == str);
        }

        /// <summary>
        /// Trả về tất cả account
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Account> getEntries()
        {
            return _unitOfWork.AccountRepository.GetAll();
        }

        /// <summary>
        /// Thêm 1 account
        /// </summary>
        /// <param name="account"></param>
        public void add(Account account)
        {
            _unitOfWork.AccountRepository.Insert(account);
            _unitOfWork.Save();
        }

        /// <summary>
        /// Xóa account theo id
        /// </summary>
        /// <param name="id"></param>
        public void deleteById(int id)
        {
            _unitOfWork.AccountRepository.Delete(id);
            _unitOfWork.Save();
        }

        /// <summary>
        /// Xóa account theo thên tài khoản
        /// </summary>
        /// <param name="str"></param>
        public void deleteByObj(string str)
        {
            _unitOfWork.AccountRepository.Delete(account => account.username == str);
            _unitOfWork.Save();
        }

        /// <summary>
        /// Update account
        /// </summary>
        /// <param name="account"></param>
        public void update(Account account)
        {
            _unitOfWork.AccountRepository.Update(account);
            _unitOfWork.Save();
        }

        /// <summary>
        /// Kiẻm tra tồn tại theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool isExist(int id)
        {
            return _unitOfWork.AccountRepository.Exists(id);
        }

        /// <summary>
        /// Kiểm tra tồn tại của tên tài khoản
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool isExistUsername(string str)
        {
            return _unitOfWork.AccountRepository.GetMany(account => account.username == str).Count() != 0;
        }

        /// <summary>
        /// Kiểm tra tồn tại của mật khẩu
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool isExistPassword(string str)
        {
            return _unitOfWork.AccountRepository.GetMany(account => account.password == str).Count() != 0;
        }
    }
}
