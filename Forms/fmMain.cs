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
        public fmMain()
        {
            InitializeComponent();
        }

        private void btnfmDangNhap_Click(object sender, EventArgs e)
        {
            fmLogin fm = new fmLogin();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btnQuanLyHeThong_Click(object sender, EventArgs e)
        {
            fmSystemManager fm = new fmSystemManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            fmSearch fm = new fmSearch();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btnKetNoiCSDL_Click(object sender, EventArgs e)
        {
            fmConnectDatabase fm = new fmConnectDatabase();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        //
        //Button: Quản lý đoàn / btnTouristsGroupManager
        //
        private void btnTouristsGroupManager_Click(object sender, EventArgs e)
        {
            fmTouristsGroupManager fm = new fmTouristsGroupManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btnLocationManager_Click(object sender, EventArgs e)
        {
            fmLocationManager fm = new fmLocationManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void btnTourManager_Click(object sender, EventArgs e)
        {
            fmTourManager fm = new fmTourManager();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }
    }
}
