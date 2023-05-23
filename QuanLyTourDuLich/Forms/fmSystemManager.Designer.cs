namespace QuanLyTourDuLich.GUI
{
    partial class fmSystemManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSystemManager));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.dgvAccountList = new System.Windows.Forms.DataGridView();
            this.noColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsAccountList = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labAccountType = new System.Windows.Forms.Label();
            this.labRePassword = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.labUsername = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txbRePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbAccountType = new System.Windows.Forms.ComboBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbSaveFilePath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSaveFilePath = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbSaveRestoreFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txbRestoreFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTroLai2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAccountList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 673);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1254, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý tài khoản";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1248, 537);
            this.panel4.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteAccount);
            this.groupBox1.Controls.Add(this.dgvAccountList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(561, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 537);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteAccount.Location = new System.Drawing.Point(554, 486);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(130, 45);
            this.btnDeleteAccount.TabIndex = 8;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // dgvAccountList
            // 
            this.dgvAccountList.AllowUserToAddRows = false;
            this.dgvAccountList.AutoGenerateColumns = false;
            this.dgvAccountList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noColumn,
            this.usernameColumn,
            this.accountTypeColumn});
            this.dgvAccountList.DataSource = this.bdsAccountList;
            this.dgvAccountList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAccountList.Location = new System.Drawing.Point(3, 26);
            this.dgvAccountList.MultiSelect = false;
            this.dgvAccountList.Name = "dgvAccountList";
            this.dgvAccountList.ReadOnly = true;
            this.dgvAccountList.RowHeadersVisible = false;
            this.dgvAccountList.RowTemplate.Height = 24;
            this.dgvAccountList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountList.ShowEditingIcon = false;
            this.dgvAccountList.Size = new System.Drawing.Size(681, 454);
            this.dgvAccountList.TabIndex = 0;
            this.dgvAccountList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountList_CellClick);
            this.dgvAccountList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAccountList_CellFormatting);
            // 
            // noColumn
            // 
            this.noColumn.FillWeight = 30F;
            this.noColumn.HeaderText = "STT";
            this.noColumn.Name = "noColumn";
            this.noColumn.ReadOnly = true;
            this.noColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.noColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // usernameColumn
            // 
            this.usernameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameColumn.DataPropertyName = "username";
            this.usernameColumn.FillWeight = 152.2843F;
            this.usernameColumn.HeaderText = "Tên tài khoản";
            this.usernameColumn.Name = "usernameColumn";
            this.usernameColumn.ReadOnly = true;
            this.usernameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // accountTypeColumn
            // 
            this.accountTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountTypeColumn.DataPropertyName = "AccountType";
            this.accountTypeColumn.FillWeight = 93.42376F;
            this.accountTypeColumn.HeaderText = "Loại tài khoản";
            this.accountTypeColumn.Name = "accountTypeColumn";
            this.accountTypeColumn.ReadOnly = true;
            this.accountTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labAccountType);
            this.groupBox2.Controls.Add(this.labRePassword);
            this.groupBox2.Controls.Add(this.labPassword);
            this.groupBox2.Controls.Add(this.labUsername);
            this.groupBox2.Controls.Add(this.btnAddAccount);
            this.groupBox2.Controls.Add(this.txbRePassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbbAccountType);
            this.groupBox2.Controls.Add(this.txbPassword);
            this.groupBox2.Controls.Add(this.txbUsername);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 537);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tạo tài khoản";
            // 
            // labAccountType
            // 
            this.labAccountType.AutoSize = true;
            this.labAccountType.Font = new System.Drawing.Font("Constantia", 10F);
            this.labAccountType.Location = new System.Drawing.Point(215, 280);
            this.labAccountType.Name = "labAccountType";
            this.labAccountType.Size = new System.Drawing.Size(196, 21);
            this.labAccountType.TabIndex = 23;
            this.labAccountType.Text = "accounttype_notification";
            // 
            // labRePassword
            // 
            this.labRePassword.AutoSize = true;
            this.labRePassword.Font = new System.Drawing.Font("Constantia", 10F);
            this.labRePassword.Location = new System.Drawing.Point(215, 220);
            this.labRePassword.Name = "labRePassword";
            this.labRePassword.Size = new System.Drawing.Size(190, 21);
            this.labRePassword.TabIndex = 22;
            this.labRePassword.Text = "repassword_notification";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Constantia", 10F);
            this.labPassword.Location = new System.Drawing.Point(215, 161);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(175, 21);
            this.labPassword.TabIndex = 21;
            this.labPassword.Text = "password_notification";
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Font = new System.Drawing.Font("Constantia", 10F);
            this.labUsername.Location = new System.Drawing.Point(215, 102);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(178, 21);
            this.labUsername.TabIndex = 20;
            this.labUsername.Text = "username_notification";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddAccount.Location = new System.Drawing.Point(425, 309);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(130, 45);
            this.btnAddAccount.TabIndex = 7;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txbRePassword
            // 
            this.txbRePassword.Location = new System.Drawing.Point(219, 187);
            this.txbRePassword.Name = "txbRePassword";
            this.txbRePassword.Size = new System.Drawing.Size(336, 30);
            this.txbRePassword.TabIndex = 5;
            this.txbRePassword.UseSystemPasswordChar = true;
            this.txbRePassword.TextChanged += new System.EventHandler(this.txbRePassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // cbbAccountType
            // 
            this.cbbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbAccountType.FormattingEnabled = true;
            this.cbbAccountType.Items.AddRange(new object[] {
            "Nhân viên kế toán",
            "Admin",
            "Nhân viên quản lý",
            "Giám đốc"
            });
            this.cbbAccountType.Location = new System.Drawing.Point(219, 246);
            this.cbbAccountType.Name = "cbbAccountType";
            this.cbbAccountType.Size = new System.Drawing.Size(336, 31);
            this.cbbAccountType.TabIndex = 6;
            this.cbbAccountType.SelectedIndexChanged += new System.EventHandler(this.cbbAccountType_SelectedIndexChanged);
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(219, 128);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(336, 30);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.UseSystemPasswordChar = true;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(219, 69);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(336, 30);
            this.txbUsername.TabIndex = 3;
            this.txbUsername.TextChanged += new System.EventHandler(this.txbUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnBack1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 84);
            this.panel1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(422, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(523, 55);
            this.label5.TabIndex = 18;
            this.label5.Text = "QUẢN LÝ TÀI KHOẢN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack1
            // 
            this.btnBack1.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.back_left_arrow_circular_button_outline;
            this.btnBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack1.Location = new System.Drawing.Point(3, 10);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(64, 64);
            this.btnBack1.TabIndex = 0;
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnTroLai1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.ImageIndex = 2;
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1254, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sao lưu & phục hồi";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.panel3.Location = new System.Drawing.Point(3, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1248, 537);
            this.panel3.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Controls.Add(this.groupBox4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1248, 537);
            this.panel5.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbSaveFilePath);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnSaveFilePath);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1248, 250);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sao lưu dữ liệu";
            // 
            // txbSaveFilePath
            // 
            this.txbSaveFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txbSaveFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSaveFilePath.Location = new System.Drawing.Point(377, 106);
            this.txbSaveFilePath.Name = "txbSaveFilePath";
            this.txbSaveFilePath.ReadOnly = true;
            this.txbSaveFilePath.Size = new System.Drawing.Size(400, 30);
            this.txbSaveFilePath.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Đường dẫn sao lưu";
            // 
            // btnSaveFilePath
            // 
            this.btnSaveFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSaveFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFilePath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveFilePath.Location = new System.Drawing.Point(845, 100);
            this.btnSaveFilePath.Name = "btnSaveFilePath";
            this.btnSaveFilePath.Size = new System.Drawing.Size(130, 40);
            this.btnSaveFilePath.TabIndex = 27;
            this.btnSaveFilePath.Text = "Chọn...";
            this.btnSaveFilePath.UseVisualStyleBackColor = false;
            this.btnSaveFilePath.Click += new System.EventHandler(this.btnSaveFilePath_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txbSaveRestoreFile);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnRestore);
            this.groupBox4.Controls.Add(this.txbRestoreFilePath);
            this.groupBox4.Controls.Add(this.btnOpenFile);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(0, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1248, 250);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phục hồi dữ liệu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Đường dẫn nơi lưu file phục hồi";
            // 
            // txbSaveRestoreFile
            // 
            this.txbSaveRestoreFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txbSaveRestoreFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSaveRestoreFile.Location = new System.Drawing.Point(377, 155);
            this.txbSaveRestoreFile.Name = "txbSaveRestoreFile";
            this.txbSaveRestoreFile.ReadOnly = true;
            this.txbSaveRestoreFile.Size = new System.Drawing.Size(400, 30);
            this.txbSaveRestoreFile.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "Đường dẫn chọn file (*.bak)";
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRestore.Location = new System.Drawing.Point(845, 149);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(130, 40);
            this.btnRestore.TabIndex = 25;
            this.btnRestore.Text = "Chọn...";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txbRestoreFilePath
            // 
            this.txbRestoreFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txbRestoreFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbRestoreFilePath.Location = new System.Drawing.Point(377, 72);
            this.txbRestoreFilePath.Name = "txbRestoreFilePath";
            this.txbRestoreFilePath.ReadOnly = true;
            this.txbRestoreFilePath.Size = new System.Drawing.Size(400, 30);
            this.txbRestoreFilePath.TabIndex = 24;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenFile.Location = new System.Drawing.Point(845, 66);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(130, 40);
            this.btnOpenFile.TabIndex = 23;
            this.btnOpenFile.Text = "Chọn...";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1118, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 23;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnTroLai2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 84);
            this.panel2.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(395, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(579, 55);
            this.label6.TabIndex = 19;
            this.label6.Text = "SAO LƯU VÀ PHỤC HỒI";
            // 
            // btnTroLai2
            // 
            this.btnTroLai2.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.back_left_arrow_circular_button_outline;
            this.btnTroLai2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTroLai2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroLai2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTroLai2.Location = new System.Drawing.Point(3, 8);
            this.btnTroLai2.Name = "btnTroLai2";
            this.btnTroLai2.Size = new System.Drawing.Size(64, 64);
            this.btnTroLai2.TabIndex = 1;
            this.btnTroLai2.UseVisualStyleBackColor = true;
            this.btnTroLai2.Click += new System.EventHandler(this.btnTroLai2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "account (1).png");
            this.imageList1.Images.SetKeyName(1, "account.png");
            this.imageList1.Images.SetKeyName(2, "database (1).png");
            // 
            // fmSystemManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "fmSystemManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmSystemManager";
            this.Load += new System.EventHandler(this.fmSystemManager_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAccountList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTroLai2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAccountList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbAccountType;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbRePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label labAccountType;
        private System.Windows.Forms.Label labRePassword;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.BindingSource bdsAccountList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbSaveFilePath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSaveFilePath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbSaveRestoreFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txbRestoreFilePath;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn noColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeColumn;
    }
}