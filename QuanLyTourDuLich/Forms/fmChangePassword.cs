using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BusinessEntity;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace QuanLyTourDuLich.Forms
{
    public partial class fmChangePassword : Form
    {
        AccountBUS _accountBus;
        IEnumerable<Account> _accountEntries;

        public fmChangePassword()
        {
            InitializeComponent();

            _accountBus = new AccountBUS();
            _accountEntries = _accountBus.getEntries();

            labPassword.Hide();
            labRePassword.Hide();
        }

        /// <summary>
        /// Sự kiện load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmChangePassword_Load(object sender, EventArgs e)
        {
            labUsername.Text = fmMain._username;
        }

        /// <summary>
        /// Button back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Sự kiện TextChanged của textbox Mật khẩu mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (txbNewPassword.Text == String.Empty)
            {
                labPassword.Text = "Mật khẩu không được để trống";
                labPassword.ForeColor = Color.Red;
                labPassword.Show();
            }
            else if (txbNewPassword.Text.Length < 5)
            {
                labPassword.Text = "Mật khẩu phải có ít nhất 5 ký tự";
                labPassword.ForeColor = Color.Red;
                labPassword.Show();
            }
            else if (txbNewPassword.Text.Length > 50)
            {
                labPassword.Text = "Mật khẩu không quá 50 ký tự";
                labPassword.ForeColor = Color.Red;
                labPassword.Show();
            }
            else if (isInvalid(txbNewPassword.Text) == false)
            {
                labPassword.Text = "Mật khẩu không được chứa ký tự đặc biệt";
                labPassword.ForeColor = Color.Red;
                labPassword.Show();
            }
            else
            {
                labPassword.Text = "Mật khẩu hợp lệ";
                labPassword.ForeColor = Color.Green;
                labPassword.Show();
            }
        }

        /// <summary>
        /// Sự kiện TextChanged của textbox Nhậ lại mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbRePassword_TextChanged(object sender, EventArgs e)
        {
            if (txbRePassword.Text == String.Empty)
            {
                labRePassword.Text = "Vui lòng nhập lại mật khẩu";
                labRePassword.ForeColor = Color.Red;
                labRePassword.Show();
            }
            else if (txbRePassword.Text != txbNewPassword.Text)
            {
                labRePassword.Text = "Mật khẩu chưa trùng khớp";
                labRePassword.ForeColor = Color.Red;
                labRePassword.Show();
            }
            else
            {
                labRePassword.Text = "Mật khẩu trùng khớp";
                labRePassword.ForeColor = Color.Green;
                labRePassword.Show();
            }
        }


        /// <summary>
        /// Sự kiện Click của button OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Account _acc = new Account();

                if(_accountBus.isExistUsername(labUsername.Text) == true)
                {
                    _acc = _accountBus.getAccountByUsername(labUsername.Text); //Lấy thông tin của tài khoản hiện tại

                    //Kiểm tra mật khẩu cũ đã nhập đúng chưa
                    if(_acc.password == getMD5(txbOldPassword.Text))
                    {
                        //Kiểm tra mật khẩu mới và nhập lại mật khẩu đúng chưa
                        if (labPassword.ForeColor == Color.Green && labRePassword.ForeColor == Color.Green)
                        {
                            _acc.password = getMD5(txbNewPassword.Text);
                            try
                            {
                                _accountBus.update(_acc);
                                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Đổi mật khẩu không thành công\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ chưa đúng!\nVui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Đổi mật khẩu không thành công\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Kiểm tra ký tự hợp lệ
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool isInvalid(string str)
        {
            Regex _regex = new Regex(@"^[a-zA-Z0-9@_]{5,50}$");
            return _regex.IsMatch(str);

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

        private void txbOldPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
