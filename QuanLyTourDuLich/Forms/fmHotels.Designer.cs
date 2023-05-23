namespace QuanLyTourDuLich.Forms
{
    partial class fmHotels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmHotels));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this._revertBtn = new QuanLyTourDuLich.CustomControl.AddButton();
            this._revertBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this._saveBtn = new QuanLyTourDuLich.CustomControl.AddButton();
            this._saveBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this._deleteBtn = new QuanLyTourDuLich.CustomControl.AddButton();
            this._deleteBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this._addBtn = new QuanLyTourDuLich.CustomControl.AddButton();
            this.addBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this._searchBoxTb = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this._currentHotelsGv = new System.Windows.Forms.DataGridView();
            this._hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this._mainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._hotelNameTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._statusTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._phoneTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._addressNameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._leftPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._currentHotelsGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._hotelBindingSource)).BeginInit();
            this.panel7.SuspendLayout();
            this._mainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this._leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Các điểm tham quan hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm nhanh";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._revertBtn);
            this.panel3.Controls.Add(this._saveBtn);
            this.panel3.Controls.Add(this._deleteBtn);
            this.panel3.Controls.Add(this._addBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(16, 304);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 42);
            this.panel3.TabIndex = 7;
            // 
            // _revertBtn
            // 
            this._revertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this._revertBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this._revertBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this._revertBtn.HoveredColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this._revertBtn.ImageListButton = this._revertBtnImageList;
            this._revertBtn.Location = new System.Drawing.Point(126, 0);
            this._revertBtn.Margin = new System.Windows.Forms.Padding(0);
            this._revertBtn.Name = "_revertBtn";
            this._revertBtn.Padding = new System.Windows.Forms.Padding(8);
            this._revertBtn.Size = new System.Drawing.Size(42, 42);
            this._revertBtn.TabIndex = 10;
            this._revertBtn.Click += new System.EventHandler(this.revertBtn_Click);
            // 
            // _revertBtnImageList
            // 
            this._revertBtnImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_revertBtnImageList.ImageStream")));
            this._revertBtnImageList.TransparentColor = System.Drawing.Color.Transparent;
            this._revertBtnImageList.Images.SetKeyName(0, "ic_revert.png");
            this._revertBtnImageList.Images.SetKeyName(1, "ic_revert_disabled.png");
            // 
            // _saveBtn
            // 
            this._saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this._saveBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this._saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this._saveBtn.HoveredColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this._saveBtn.ImageListButton = this._saveBtnImageList;
            this._saveBtn.Location = new System.Drawing.Point(84, 0);
            this._saveBtn.Margin = new System.Windows.Forms.Padding(0);
            this._saveBtn.Name = "_saveBtn";
            this._saveBtn.Padding = new System.Windows.Forms.Padding(8);
            this._saveBtn.Size = new System.Drawing.Size(42, 42);
            this._saveBtn.TabIndex = 11;
            this._saveBtn.Click += new System.EventHandler(this._saveBtn_Click);
            // 
            // _saveBtnImageList
            // 
            this._saveBtnImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_saveBtnImageList.ImageStream")));
            this._saveBtnImageList.TransparentColor = System.Drawing.Color.Transparent;
            this._saveBtnImageList.Images.SetKeyName(0, "ic_save.png");
            this._saveBtnImageList.Images.SetKeyName(1, "ic_save_disabled.png");
            // 
            // _deleteBtn
            // 
            this._deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this._deleteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this._deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this._deleteBtn.HoveredColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this._deleteBtn.ImageListButton = this._deleteBtnImageList;
            this._deleteBtn.Location = new System.Drawing.Point(42, 0);
            this._deleteBtn.Margin = new System.Windows.Forms.Padding(0);
            this._deleteBtn.Name = "_deleteBtn";
            this._deleteBtn.Padding = new System.Windows.Forms.Padding(8);
            this._deleteBtn.Size = new System.Drawing.Size(42, 42);
            this._deleteBtn.TabIndex = 12;
            this._deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // _deleteBtnImageList
            // 
            this._deleteBtnImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_deleteBtnImageList.ImageStream")));
            this._deleteBtnImageList.TransparentColor = System.Drawing.Color.Transparent;
            this._deleteBtnImageList.Images.SetKeyName(0, "ic_remove.png");
            this._deleteBtnImageList.Images.SetKeyName(1, "ic_remove_disabled.png");
            // 
            // _addBtn
            // 
            this._addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this._addBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this._addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this._addBtn.HoveredColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this._addBtn.ImageListButton = this.addBtnImageList;
            this._addBtn.Location = new System.Drawing.Point(0, 0);
            this._addBtn.Margin = new System.Windows.Forms.Padding(0);
            this._addBtn.Name = "_addBtn";
            this._addBtn.Padding = new System.Windows.Forms.Padding(8);
            this._addBtn.Size = new System.Drawing.Size(42, 42);
            this._addBtn.TabIndex = 13;
            this._addBtn.Load += new System.EventHandler(this._addBtn_Load);
            this._addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addBtnImageList
            // 
            this.addBtnImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("addBtnImageList.ImageStream")));
            this.addBtnImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.addBtnImageList.Images.SetKeyName(0, "ic_add.png");
            this.addBtnImageList.Images.SetKeyName(1, "ic_add_disabled.png");
            // 
            // _searchBoxTb
            // 
            this._searchBoxTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this._searchBoxTb.Location = new System.Drawing.Point(6, 32);
            this._searchBoxTb.Margin = new System.Windows.Forms.Padding(4);
            this._searchBoxTb.Name = "_searchBoxTb";
            this._searchBoxTb.Size = new System.Drawing.Size(428, 26);
            this._searchBoxTb.TabIndex = 1;
            this._searchBoxTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBoxTb_KeyPress);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this._searchBoxTb);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(6);
            this.panel5.Size = new System.Drawing.Size(440, 64);
            this.panel5.TabIndex = 4;
            // 
            // _currentHotelsGv
            // 
            this._currentHotelsGv.AllowUserToAddRows = false;
            this._currentHotelsGv.AutoGenerateColumns = false;
            this._currentHotelsGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._currentHotelsGv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this._currentHotelsGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._currentHotelsGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._currentHotelsGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this._addressColumn,
            this._phoneColumn,
            this.priceColumn});
            this._currentHotelsGv.DataSource = this._hotelBindingSource;
            this._currentHotelsGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this._currentHotelsGv.Location = new System.Drawing.Point(12, 76);
            this._currentHotelsGv.Margin = new System.Windows.Forms.Padding(24, 22, 24, 22);
            this._currentHotelsGv.MultiSelect = false;
            this._currentHotelsGv.Name = "_currentHotelsGv";
            this._currentHotelsGv.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.NullValue = "####";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(16);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._currentHotelsGv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this._currentHotelsGv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this._currentHotelsGv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Constantia", 11.5F);
            this._currentHotelsGv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._currentHotelsGv.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4);
            this._currentHotelsGv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this._currentHotelsGv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._currentHotelsGv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._currentHotelsGv.RowTemplate.Height = 48;
            this._currentHotelsGv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._currentHotelsGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._currentHotelsGv.Size = new System.Drawing.Size(440, 437);
            this._currentHotelsGv.TabIndex = 3;
            this._currentHotelsGv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.currentHotelsGv_CellValueChanged);
            this._currentHotelsGv.SelectionChanged += new System.EventHandler(this.currentTourSiteGv_SelectionChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this._currentHotelsGv);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 48);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.panel7.Size = new System.Drawing.Size(464, 513);
            this.panel7.TabIndex = 4;
            // 
            // _mainPanel
            // 
            this._mainPanel.Controls.Add(this.panel7);
            this._mainPanel.Controls.Add(this.panel4);
            this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPanel.Location = new System.Drawing.Point(240, 0);
            this._mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(464, 561);
            this._mainPanel.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(16);
            this.panel4.Size = new System.Drawing.Size(464, 48);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm mới điểm tham quan";
            // 
            // _hotelNameTb
            // 
            this._hotelNameTb.Dock = System.Windows.Forms.DockStyle.Top;
            this._hotelNameTb.Location = new System.Drawing.Point(16, 38);
            this._hotelNameTb.Margin = new System.Windows.Forms.Padding(4);
            this._hotelNameTb.Name = "_hotelNameTb";
            this._hotelNameTb.Size = new System.Drawing.Size(208, 26);
            this._hotelNameTb.TabIndex = 2;
            this._hotelNameTb.TextChanged += new System.EventHandler(this.hotelInfo_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16);
            this.panel1.Size = new System.Drawing.Size(240, 48);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách sạn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this._statusTb);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this._phoneTb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this._addressNameTb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this._hotelNameTb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(16);
            this.panel2.Size = new System.Drawing.Size(240, 513);
            this.panel2.TabIndex = 3;
            this.panel2.Layout += new System.Windows.Forms.LayoutEventHandler(this.panel2_Layout);
            // 
            // _statusTb
            // 
            this._statusTb.Dock = System.Windows.Forms.DockStyle.Top;
            this._statusTb.Location = new System.Drawing.Point(16, 218);
            this._statusTb.Margin = new System.Windows.Forms.Padding(4);
            this._statusTb.Name = "_statusTb";
            this._statusTb.Size = new System.Drawing.Size(208, 26);
            this._statusTb.TabIndex = 13;
            this._statusTb.Visible = false;
            this._statusTb.TextChanged += new System.EventHandler(this.hotelInfo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(16, 184);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 12, 0, 4);
            this.label7.Size = new System.Drawing.Size(61, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ghi chú";
            this.label7.Visible = false;
            // 
            // _phoneTb
            // 
            this._phoneTb.Dock = System.Windows.Forms.DockStyle.Top;
            this._phoneTb.Location = new System.Drawing.Point(16, 158);
            this._phoneTb.Margin = new System.Windows.Forms.Padding(4);
            this._phoneTb.Name = "_phoneTb";
            this._phoneTb.Size = new System.Drawing.Size(208, 26);
            this._phoneTb.TabIndex = 11;
            this._phoneTb.TextChanged += new System.EventHandler(this.hotelInfo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(16, 124);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 12, 0, 4);
            this.label6.Size = new System.Drawing.Size(94, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số điện thoại";
            // 
            // _addressNameTb
            // 
            this._addressNameTb.Dock = System.Windows.Forms.DockStyle.Top;
            this._addressNameTb.Location = new System.Drawing.Point(16, 98);
            this._addressNameTb.Margin = new System.Windows.Forms.Padding(4);
            this._addressNameTb.Name = "_addressNameTb";
            this._addressNameTb.Size = new System.Drawing.Size(208, 26);
            this._addressNameTb.TabIndex = 9;
            this._addressNameTb.TextChanged += new System.EventHandler(this.hotelInfo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(16, 64);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 12, 0, 4);
            this.label5.Size = new System.Drawing.Size(54, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ";
            // 
            // _leftPanel
            // 
            this._leftPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._leftPanel.Controls.Add(this.panel2);
            this._leftPanel.Controls.Add(this.panel1);
            this._leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._leftPanel.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._leftPanel.Location = new System.Drawing.Point(0, 0);
            this._leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this._leftPanel.Name = "_leftPanel";
            this._leftPanel.Size = new System.Drawing.Size(240, 561);
            this._leftPanel.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(16, 244);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 12, 0, 4);
            this.label8.Size = new System.Drawing.Size(178, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "Phí thuê phòng (tr. đồng)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(16, 278);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(208, 26);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ToolTipText = "Click đôi để thêm vào vào điểm đến";
            // 
            // _addressColumn
            // 
            this._addressColumn.DataPropertyName = "address";
            this._addressColumn.HeaderText = "Địa chỉ";
            this._addressColumn.Name = "_addressColumn";
            // 
            // _phoneColumn
            // 
            this._phoneColumn.DataPropertyName = "phone";
            this._phoneColumn.HeaderText = "Sđt";
            this._phoneColumn.Name = "_phoneColumn";
            // 
            // priceColumn
            // 
            this.priceColumn.DataPropertyName = "price";
            this.priceColumn.HeaderText = "Phí (nghìn đ)";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // fmHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this._mainPanel);
            this.Controls.Add(this._leftPanel);
            this.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmHotels";
            this.Text = "fmHotels";
            this.Load += new System.EventHandler(this.fmHotels_Load);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._currentHotelsGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._hotelBindingSource)).EndInit();
            this.panel7.ResumeLayout(false);
            this._mainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this._leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private CustomControl.AddButton _addBtn;
        private System.Windows.Forms.ImageList addBtnImageList;
        private CustomControl.AddButton _deleteBtn;
        private System.Windows.Forms.ImageList _deleteBtnImageList;
        private CustomControl.AddButton _saveBtn;
        private System.Windows.Forms.ImageList _saveBtnImageList;
        private CustomControl.AddButton _revertBtn;
        private System.Windows.Forms.ImageList _revertBtnImageList;
        private System.Windows.Forms.TextBox _searchBoxTb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView _currentHotelsGv;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _hotelNameTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel _leftPanel;
        private System.Windows.Forms.TextBox _addressNameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _statusTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _phoneTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource _hotelBindingSource;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
    }
}