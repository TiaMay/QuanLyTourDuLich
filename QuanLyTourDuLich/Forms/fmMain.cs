using QuanLyTourDuLich.Forms;
using QuanLyTourDuLich.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyTourDuLich
{
    public partial class fmMain : Form
    {
        /// <summary>
        /// Dùng để lấy loại account
        /// </summary>
        public static int _accountType = 0;

        /// <summary>
        /// Lấy tên tài khoản đã đăng nhập thành công
        /// </summary>
        public static string _username = null;

        public fmMain()
        {
            InitializeComponent();

            pnUserAccount.Hide();
            loginPanel.Show();
        }

        /// <summary>
        /// Sự kiện Load của Form Main, phân quyền ở đây
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmMain_Load(object sender, EventArgs e)
        {
            #region Phân quyền
            //Tài khoản: Admin
            if (_accountType == 2)
            {
                //Được dùng
                btnSystemManager.Enabled = true;

                //Ko đc dùng
                btnTourManager.Enabled = false;
                btnTouristsGroupManager.Enabled = false;
                btnLocationManager.Enabled = false;
                btnReport.Enabled = false;
                btnSearch.Enabled = false;
                employeeBtn.Enabled = false;

            }
            //Tài khoản: Giám đốc
            else if (_accountType == 4)
            {
                //Được dùng
                btnSearch.Enabled = true;
                employeeBtn.Enabled = true;

                //Ko đc dùng
                btnTourManager.Enabled = false;
                btnTouristsGroupManager.Enabled = false;
                btnLocationManager.Enabled = false;
                btnReport.Enabled = false;
                btnSystemManager.Enabled = false;
            }
            //Tài khoản: Nhân viên quản lý
            else if (_accountType == 3)
            {
                //Được dùng
                btnTourManager.Enabled = true;
                btnTouristsGroupManager.Enabled = true;
                btnLocationManager.Enabled = true;
                btnSearch.Enabled = true;

                //Ko đc dùng
                btnReport.Enabled = false;
                btnSystemManager.Enabled = false;
                employeeBtn.Enabled = false;
            }
            //Tài khoản: Nhân viên kế toán
            else if (_accountType == 1)
            {
                //Được dùng
                btnReport.Enabled = true;

                //Ko đc dùng
                btnTourManager.Enabled = false;
                btnTouristsGroupManager.Enabled = false;
                btnLocationManager.Enabled = false;
                btnSearch.Enabled = false;
                btnSystemManager.Enabled = false;
                employeeBtn.Enabled = false;
            }
            else if (_accountType == 5)
            {
                btnTourManager.Enabled = true;
                btnTouristsGroupManager.Enabled = true;
                btnLocationManager.Enabled = true;
                btnSearch.Enabled = true;
                btnSystemManager.Enabled = true;
                btnReport.Enabled = true;
                employeeBtn.Enabled = true;
            }
            //Chưa đăng nhập
            else
            {
                btnTourManager.Enabled = false;
                btnTouristsGroupManager.Enabled = false;
                btnLocationManager.Enabled = false;
                btnSearch.Enabled = false;
                btnSystemManager.Enabled = false;
                btnReport.Enabled = false;
                employeeBtn.Enabled = false;
                //defaultValue();
            }
            #endregion

            //Hiển thị panel UserAccount sau khi đăng nhập thành công
            if(_username != null)
            {
                labUserAccount.Text = "Xin chào, " + _username + "!";
                pnUserAccount.Show();
                loginPanel.Hide();
            }
            else
            {
                //Đăng xuất thành công
                defaultValue();
            }

            //Cheat tài khoản master để test chương trình
            if(_username != null && _username == "master")
            {
                btnTourManager.Enabled = true;
                btnTouristsGroupManager.Enabled = true;
                btnLocationManager.Enabled = true;
                btnSearch.Enabled = true;
                btnReport.Enabled = true;
                btnSystemManager.Enabled = true;
            }
        }

        /// <summary>
        /// Form chức năng đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            fmLogin fm = new fmLogin();
            this.Hide();
            this.Cursor = Cursors.Default;
            fm.ShowDialog();
            this.fmMain_Load(sender, e);
            this.Show();
        }

        /// <summary>
        /// Quản lý hệ thống
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSystemManager_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            fmSystemManager fm = new fmSystemManager();
            this.Hide();
            this.Cursor = Cursors.Default;
            fm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Tra cứu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            fmSearch fm = new fmSearch();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }


        //
        //Button: Quản lý đoàn / btnTouristsGroupManager
        //
        private void btnTouristsGroupManager_Click(object sender, EventArgs e)
        {
            frmTourGroupManager fm = new frmTourGroupManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Quản lý địa điểm tham quan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocationManager_Click(object sender, EventArgs e)
        {
            fmLocationManager fm = new fmLocationManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Quản lý tour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTourManager_Click(object sender, EventArgs e)
        {
            fmTourManager fm = new fmTourManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Báo cáo / Thống kê
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                fmReport fm = new fmReport();
                this.Hide();
                this.Cursor = Cursors.Default;
                fm.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary>
        /// Button Đăng xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSingout_Click(object sender, EventArgs e)
        {
            _username = null;
            pnUserAccount.Hide();
            loginPanel.Show();
            this.fmMain_Load(sender, e);
            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Button Đổi mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            fmChangePassword fm = new fmChangePassword();
            this.Hide();
            this.Cursor = Cursors.Default;
            fm.ShowDialog();
            this.Show();
        }


        private void defaultValue()
        {
#if DEBUG
            btnTourManager.Enabled = true;
            btnTouristsGroupManager.Enabled = true;
            btnLocationManager.Enabled = true;
            btnSearch.Enabled = true;
            btnSystemManager.Enabled = true;
            btnReport.Enabled = true;
            employeeBtn.Enabled = true;
#else
            btnTourManager.Enabled = false;
            btnTouristsGroupManager.Enabled = false;
            btnLocationManager.Enabled = false;
            btnSearch.Enabled = false;
            btnSystemManager.Enabled = false;
            btnReport.Enabled = false;
            employeeBtn.Enabled = false;
#endif // DEBUG

        }

        private void forgotPassBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang phát triển", "Stop", MessageBoxButtons.OK);
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var fm = new frmEmployeeManagement();
            this.Hide();
            this.Cursor = Cursors.Default;
            fm.ShowDialog();
            this.fmMain_Load(sender, e);
            this.Show();
        }

        
    }
}
