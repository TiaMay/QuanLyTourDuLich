using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTourDuLich.CustomControl
{
    public partial class AddButton : UserControl
    {
        public Color HoveredColor { get; set; }
        private Color NormalColor { get; set; }
        public ImageList ImageListButton { get;set; }
        public AddButton()
        {
            InitializeComponent();
            //this.SuspendLayout();

            //setEnabledImage();
            NormalColor = this.BackColor;
            if (BackgroundImage != null)
            {
                btn.BackgroundImage = BackgroundImage;
            }
            //this.ResumeLayout(false);
        }

        private void AddButton_EnabledChanged(object sender, EventArgs e)
        {
            setEnabledImage();
        }
        private void setEnabledImage()
        {
            if (ImageListButton == null || ImageListButton.Images.Count == 0)
                return;
            if (this.Enabled)
                btn.BackgroundImage = ImageListButton.Images[0];
            else
                btn.BackgroundImage = ImageListButton.Images[1];
        }

        private void AddButton_MouseHover(object sender, EventArgs e)
        {
            if (this.Enabled == false)
                return;
            this.BackColor = HoveredColor;
            this.btn.BackColor = HoveredColor;
            this.btn.ForeColor = HoveredColor;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = NormalColor;
            this.btn.BackColor = NormalColor;
            this.btn.ForeColor = NormalColor;
        }

        private void btn_Layout(object sender, LayoutEventArgs e)
        {
            setEnabledImage();
        }
    }
}
