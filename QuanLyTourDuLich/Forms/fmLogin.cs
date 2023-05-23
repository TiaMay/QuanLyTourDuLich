using BusinessEntity;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyTourDuLich.GUI
{
    public partial class fmLogin : Form
    {
        AccountBUS _accountBus;
        IEnumerable<Account> _accountEntries;

        AccountTypeBUS _accountTypeBus;
        IEnumerable<AccountType> _accountTypeEntries;

        public fmLogin()
        {
            InitializeComponent();

            _accountBus = new AccountBUS();
            _accountEntries = _accountBus.getEntries();

            _accountTypeBus = new AccountTypeBUS();
            _accountTypeEntries = _accountTypeBus.getEntries();
        }

        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Sự kiện tick của Timer1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            labTimer.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// Sự kiện check changed của checkbox Hiển thị mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbShowPassword.Checked == true)
            {
                txbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Sự kiện Click của nút Đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSingin_Click(object sender, EventArgs e)
        {
            Account _acc = new Account();
            if(txbUsername.Text == String.Empty || txbPassword.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_accountBus.isExistUsername(txbUsername.Text) == true)
            {
                _acc = _accountBus.getAccountByUsername(txbUsername.Text);
                //Đăng nhập thành công
                if (_acc.password == getMD5(txbPassword.Text))
                {
                    txbUsername.Clear();
                    txbPassword.Clear();

                    fmMain._accountType = _acc.AccountType.level; //Truyền account type cho form Main
                    fmMain._username = _acc.username; // Truyền tên tài khoản cho form Main
                    MessageBox.Show("Đăng nhập thành công!\nTài khoản: " + _acc.username.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                //Đăng nhập ko thành công
                else
                {

                    MessageBox.Show("Mật khẩu chưa đúng!\nVui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Đăng nhập ko thành công
                MessageBox.Show("Tên tài khoản chưa đúng!\nVui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện cho nút enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmLogin_Enter(object sender, EventArgs e)
        {
            btnSingin.PerformClick();
        }

        /// <summary>
        /// Mã hóa 1 chuỗi theo chuẩn MD5
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string getMD5(string str)
        {
            MD5 _md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            _md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(str));

            //get hash result after compute it
            byte[] result = _md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

    }
}
