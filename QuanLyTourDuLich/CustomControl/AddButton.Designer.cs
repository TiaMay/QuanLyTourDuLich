namespace QuanLyTourDuLich.CustomControl
{
    partial class AddButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddButton));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ic_add.png");
            this.imageList1.Images.SetKeyName(1, "ic_add_disabled.png");
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.Enabled = false;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btn.Location = new System.Drawing.Point(2, 2);
            this.btn.Margin = new System.Windows.Forms.Padding(0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(28, 28);
            this.btn.TabIndex = 0;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Layout += new System.Windows.Forms.LayoutEventHandler(this.btn_Layout);
            // 
            // AddButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.btn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddButton";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(32, 32);
            this.EnabledChanged += new System.EventHandler(this.AddButton_EnabledChanged);
            this.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            this.MouseHover += new System.EventHandler(this.AddButton_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn;
    }
}
