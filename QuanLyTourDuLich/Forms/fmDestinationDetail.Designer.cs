namespace QuanLyTourDuLich.Forms
{
    partial class fmDestinationDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDestinationDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._leftPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this._revertBtn = new QuanLyTourDuLich.CustomControl.AddButton();
            this._revertBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this._saveBtn = new QuanLyTourDuLich.CustomControl.AddButton();
            this._saveBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this._deleteBtn = new QuanLyTourDuLich.CustomControl.AddButton();
            this._deleteBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this._addBtn = new QuanLyTourDuLich.CustomControl.AddButton();
            this.addBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this._tourSiteName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._mainPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this._currentTourSiteGv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tourSiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this._searchBoxTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this._leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this._mainPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._currentTourSiteGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tourSiteBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // _leftPanel
            // 
            this._leftPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._leftPanel.Controls.Add(this.panel2);
            this._leftPanel.Controls.Add(this.panel1);
            this._leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._leftPanel.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._leftPanel.Location = new System.Drawing.Point(0, 0);
            this._leftPanel.Name = "_leftPanel";
            this._leftPanel.Size = new System.Drawing.Size(240, 561);
            this._leftPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this._tourSiteName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(16);
            this.panel2.Size = new System.Drawing.Size(240, 513);
            this.panel2.TabIndex = 3;
            this.panel2.Layout += new System.Windows.Forms.LayoutEventHandler(this.panel2_Layout);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._revertBtn);
            this.panel3.Controls.Add(this._saveBtn);
            this.panel3.Controls.Add(this._deleteBtn);
            this.panel3.Controls.Add(this._addBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(16, 76);
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
            this._revertBtn.Click += new System.EventHandler(this._revertBtn_Click);
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
            this._deleteBtn.Click += new System.EventHandler(this._deleteBtn_Click);
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
            this._addBtn.Click += new System.EventHandler(this._addBtn_Click);
            // 
            // addBtnImageList
            // 
            this.addBtnImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("addBtnImageList.ImageStream")));
            this.addBtnImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.addBtnImageList.Images.SetKeyName(0, "ic_add.png");
            this.addBtnImageList.Images.SetKeyName(1, "ic_add_disabled.png");
            // 
            // _tourSiteName
            // 
            this._tourSiteName.Dock = System.Windows.Forms.DockStyle.Top;
            this._tourSiteName.Location = new System.Drawing.Point(16, 50);
            this._tourSiteName.Name = "_tourSiteName";
            this._tourSiteName.Size = new System.Drawing.Size(208, 26);
            this._tourSiteName.TabIndex = 2;
            this._tourSiteName.TextChanged += new System.EventHandler(this._tourSiteName_TextChanged);
            this._tourSiteName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._tourSiteName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label2.Size = new System.Drawing.Size(144, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên điểm tham quan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16);
            this.panel1.Size = new System.Drawing.Size(240, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm mới điểm tham quan";
            // 
            // _mainPanel
            // 
            this._mainPanel.Controls.Add(this.panel7);
            this._mainPanel.Controls.Add(this.panel4);
            this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPanel.Location = new System.Drawing.Point(240, 0);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(324, 561);
            this._mainPanel.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this._currentTourSiteGv);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 48);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.panel7.Size = new System.Drawing.Size(324, 513);
            this.panel7.TabIndex = 4;
            // 
            // _currentTourSiteGv
            // 
            this._currentTourSiteGv.AllowUserToAddRows = false;
            this._currentTourSiteGv.AutoGenerateColumns = false;
            this._currentTourSiteGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._currentTourSiteGv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this._currentTourSiteGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._currentTourSiteGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._currentTourSiteGv.ColumnHeadersVisible = false;
            this._currentTourSiteGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this._currentTourSiteGv.DataSource = this._tourSiteBindingSource;
            this._currentTourSiteGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this._currentTourSiteGv.Location = new System.Drawing.Point(12, 76);
            this._currentTourSiteGv.Margin = new System.Windows.Forms.Padding(16);
            this._currentTourSiteGv.MultiSelect = false;
            this._currentTourSiteGv.Name = "_currentTourSiteGv";
            this._currentTourSiteGv.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.NullValue = "####";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(16);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._currentTourSiteGv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this._currentTourSiteGv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this._currentTourSiteGv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Constantia", 11.5F);
            this._currentTourSiteGv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._currentTourSiteGv.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4);
            this._currentTourSiteGv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this._currentTourSiteGv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._currentTourSiteGv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._currentTourSiteGv.RowTemplate.Height = 48;
            this._currentTourSiteGv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._currentTourSiteGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._currentTourSiteGv.Size = new System.Drawing.Size(300, 437);
            this._currentTourSiteGv.TabIndex = 3;
            this._currentTourSiteGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._currentTourSiteGv_CellContentClick);
            this._currentTourSiteGv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this._currentTourSiteGv_CellValueChanged);
            this._currentTourSiteGv.SelectionChanged += new System.EventHandler(this._currentTourSiteGv_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ToolTipText = "Click đôi để thêm vào vào điểm đến";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this._searchBoxTb);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(4);
            this.panel5.Size = new System.Drawing.Size(300, 64);
            this.panel5.TabIndex = 4;
            // 
            // _searchBoxTb
            // 
            this._searchBoxTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this._searchBoxTb.Location = new System.Drawing.Point(4, 30);
            this._searchBoxTb.Name = "_searchBoxTb";
            this._searchBoxTb.Size = new System.Drawing.Size(292, 26);
            this._searchBoxTb.TabIndex = 1;
            this._searchBoxTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBoxTb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm nhanh";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(16);
            this.panel4.Size = new System.Drawing.Size(324, 48);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Các điểm tham quan hiện tại";
            // 
            // fmDestinationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(564, 561);
            this.Controls.Add(this._mainPanel);
            this.Controls.Add(this._leftPanel);
            this.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmDestinationDetail";
            this.Text = "fmDestinationDetail";
            this.Load += new System.EventHandler(this.fmDestinationDetail_Load);
            this._leftPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this._mainPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._currentTourSiteGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tourSiteBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _leftPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox _tourSiteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource _tourSiteBindingSource;
        private System.Windows.Forms.Panel panel3;
        private CustomControl.AddButton _revertBtn;
        private System.Windows.Forms.ImageList _revertBtnImageList;
        private System.Windows.Forms.ImageList _saveBtnImageList;
        private System.Windows.Forms.ImageList _deleteBtnImageList;
        private System.Windows.Forms.ImageList addBtnImageList;
        private CustomControl.AddButton _addBtn;
        private CustomControl.AddButton _deleteBtn;
        private CustomControl.AddButton _saveBtn;
        private System.Windows.Forms.DataGridView _currentTourSiteGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox _searchBoxTb;
        private System.Windows.Forms.Label label3;

    }
}