namespace QuanLyTourDuLich
{
    partial class fmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labUserAccount = new System.Windows.Forms.Label();
            this.btnSingout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pnUserAccount = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.forgotPassBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.employeeBtn = new System.Windows.Forms.Button();
            this.btnSystemManager = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTouristsGroupManager = new System.Windows.Forms.Button();
            this.btnLocationManager = new System.Windows.Forms.Button();
            this.btnTourManager = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnUserAccount.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(159, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ TOUR DU LỊCH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 90);
            this.panel1.TabIndex = 9;
            // 
            // labUserAccount
            // 
            this.labUserAccount.AutoSize = true;
            this.labUserAccount.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold);
            this.labUserAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labUserAccount.Location = new System.Drawing.Point(3, 24);
            this.labUserAccount.Name = "labUserAccount";
            this.labUserAccount.Size = new System.Drawing.Size(121, 22);
            this.labUserAccount.TabIndex = 10;
            this.labUserAccount.Text = "UserAccount";
            // 
            // btnSingout
            // 
            this.btnSingout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSingout.FlatAppearance.BorderSize = 0;
            this.btnSingout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSingout.Location = new System.Drawing.Point(8, 61);
            this.btnSingout.Name = "btnSingout";
            this.btnSingout.Size = new System.Drawing.Size(130, 46);
            this.btnSingout.TabIndex = 20;
            this.btnSingout.Text = "Đăng xuất";
            this.btnSingout.UseVisualStyleBackColor = false;
            this.btnSingout.Click += new System.EventHandler(this.btnSingout_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangePassword.Location = new System.Drawing.Point(144, 61);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(136, 46);
            this.btnChangePassword.TabIndex = 20;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // pnUserAccount
            // 
            this.pnUserAccount.Controls.Add(this.labUserAccount);
            this.pnUserAccount.Controls.Add(this.btnSingout);
            this.pnUserAccount.Controls.Add(this.btnChangePassword);
            this.pnUserAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUserAccount.Location = new System.Drawing.Point(16, 140);
            this.pnUserAccount.Name = "pnUserAccount";
            this.pnUserAccount.Size = new System.Drawing.Size(305, 140);
            this.pnUserAccount.TabIndex = 21;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.forgotPassBtn);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginPanel.Location = new System.Drawing.Point(16, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(305, 140);
            this.loginPanel.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bắt đầu làm việc";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginBtn.Location = new System.Drawing.Point(8, 61);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(130, 46);
            this.loginBtn.TabIndex = 20;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // forgotPassBtn
            // 
            this.forgotPassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.forgotPassBtn.FlatAppearance.BorderSize = 0;
            this.forgotPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPassBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.forgotPassBtn.Location = new System.Drawing.Point(144, 61);
            this.forgotPassBtn.Name = "forgotPassBtn";
            this.forgotPassBtn.Size = new System.Drawing.Size(136, 46);
            this.forgotPassBtn.TabIndex = 20;
            this.forgotPassBtn.Text = "Quên mật khẩu";
            this.forgotPassBtn.UseVisualStyleBackColor = false;
            this.forgotPassBtn.Click += new System.EventHandler(this.forgotPassBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.employeeBtn);
            this.panel2.Controls.Add(this.pnUserAccount);
            this.panel2.Controls.Add(this.loginPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.panel2.Size = new System.Drawing.Size(337, 491);
            this.panel2.TabIndex = 23;
            // 
            // employeeBtn
            // 
            this.employeeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.employeeBtn.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.office_worker_outline;
            this.employeeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.employeeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.employeeBtn.FlatAppearance.BorderSize = 8;
            this.employeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeBtn.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.employeeBtn.Location = new System.Drawing.Point(15, 336);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(320, 140);
            this.employeeBtn.TabIndex = 24;
            this.employeeBtn.Text = "Quản lý NV";
            this.employeeBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.employeeBtn.UseVisualStyleBackColor = false;
            this.employeeBtn.Click += new System.EventHandler(this.employeeBtn_Click);
            // 
            // btnSystemManager
            // 
            this.btnSystemManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSystemManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnSystemManager.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.settings;
            this.btnSystemManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSystemManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnSystemManager.FlatAppearance.BorderSize = 8;
            this.btnSystemManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemManager.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSystemManager.Location = new System.Drawing.Point(684, 426);
            this.btnSystemManager.Name = "btnSystemManager";
            this.btnSystemManager.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSystemManager.Size = new System.Drawing.Size(320, 140);
            this.btnSystemManager.TabIndex = 7;
            this.btnSystemManager.Text = "System";
            this.btnSystemManager.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSystemManager.UseVisualStyleBackColor = false;
            this.btnSystemManager.Click += new System.EventHandler(this.btnSystemManager_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnReport.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.bar_chart;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnReport.FlatAppearance.BorderSize = 8;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Location = new System.Drawing.Point(349, 426);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(320, 140);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Thống kê";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSearch.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSearch.FlatAppearance.BorderSize = 8;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(684, 274);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(320, 140);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnTouristsGroupManager
            // 
            this.btnTouristsGroupManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTouristsGroupManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnTouristsGroupManager.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.tourist;
            this.btnTouristsGroupManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTouristsGroupManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnTouristsGroupManager.FlatAppearance.BorderSize = 8;
            this.btnTouristsGroupManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTouristsGroupManager.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTouristsGroupManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTouristsGroupManager.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTouristsGroupManager.Location = new System.Drawing.Point(684, 118);
            this.btnTouristsGroupManager.Name = "btnTouristsGroupManager";
            this.btnTouristsGroupManager.Size = new System.Drawing.Size(320, 140);
            this.btnTouristsGroupManager.TabIndex = 3;
            this.btnTouristsGroupManager.Text = "Quản lý đoàn";
            this.btnTouristsGroupManager.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTouristsGroupManager.UseVisualStyleBackColor = false;
            this.btnTouristsGroupManager.Click += new System.EventHandler(this.btnTouristsGroupManager_Click);
            // 
            // btnLocationManager
            // 
            this.btnLocationManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocationManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnLocationManager.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.navigation_trajectory;
            this.btnLocationManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocationManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.btnLocationManager.FlatAppearance.BorderSize = 8;
            this.btnLocationManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocationManager.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocationManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLocationManager.Location = new System.Drawing.Point(349, 274);
            this.btnLocationManager.Name = "btnLocationManager";
            this.btnLocationManager.Size = new System.Drawing.Size(320, 140);
            this.btnLocationManager.TabIndex = 2;
            this.btnLocationManager.Text = "Quản lý địa điểm";
            this.btnLocationManager.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLocationManager.UseVisualStyleBackColor = false;
            this.btnLocationManager.Click += new System.EventHandler(this.btnLocationManager_Click);
            // 
            // btnTourManager
            // 
            this.btnTourManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTourManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.btnTourManager.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.earth_pictures;
            this.btnTourManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTourManager.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.btnTourManager.FlatAppearance.BorderSize = 8;
            this.btnTourManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTourManager.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTourManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTourManager.Location = new System.Drawing.Point(349, 118);
            this.btnTourManager.Name = "btnTourManager";
            this.btnTourManager.Size = new System.Drawing.Size(320, 140);
            this.btnTourManager.TabIndex = 1;
            this.btnTourManager.Text = "Quản lý tour";
            this.btnTourManager.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTourManager.UseVisualStyleBackColor = false;
            this.btnTourManager.Click += new System.EventHandler(this.btnTourManager_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1016, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSystemManager);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnTouristsGroupManager);
            this.Controls.Add(this.btnLocationManager);
            this.Controls.Add(this.btnTourManager);
            this.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1032, 620);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tour Du Lịch";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnUserAccount.ResumeLayout(false);
            this.pnUserAccount.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTourManager;
        private System.Windows.Forms.Button btnLocationManager;
        private System.Windows.Forms.Button btnTouristsGroupManager;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSystemManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labUserAccount;
        private System.Windows.Forms.Button btnSingout;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel pnUserAccount;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button forgotPassBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button employeeBtn;
    }
}

