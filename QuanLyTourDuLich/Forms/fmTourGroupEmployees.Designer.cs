namespace QuanLyTourDuLich.Forms
{
    partial class fmTourGroupEmployees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTourGroupEmployees));
            this._tourGroupPanel = new System.Windows.Forms.Panel();
            this._returnDateLb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._departDateLb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._tourNameLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._tourGroupNameLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this._resultGv = new System.Windows.Forms.DataGridView();
            this._noColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this._countLb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._showStateCb = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.removeAllBtn = new System.Windows.Forms.Button();
            this.removeAllBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this.addAllBtn = new System.Windows.Forms.Button();
            this.addAllBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this._searchBtn = new System.Windows.Forms.Button();
            this._searchTb = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._tourGroupPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._resultGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._employeeBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tourGroupPanel
            // 
            this._tourGroupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._tourGroupPanel.Controls.Add(this._returnDateLb);
            this._tourGroupPanel.Controls.Add(this.label8);
            this._tourGroupPanel.Controls.Add(this._departDateLb);
            this._tourGroupPanel.Controls.Add(this.label6);
            this._tourGroupPanel.Controls.Add(this._tourNameLb);
            this._tourGroupPanel.Controls.Add(this.label4);
            this._tourGroupPanel.Controls.Add(this._tourGroupNameLb);
            this._tourGroupPanel.Controls.Add(this.label2);
            this._tourGroupPanel.Controls.Add(this.label1);
            this._tourGroupPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._tourGroupPanel.Location = new System.Drawing.Point(0, 0);
            this._tourGroupPanel.Margin = new System.Windows.Forms.Padding(4);
            this._tourGroupPanel.Name = "_tourGroupPanel";
            this._tourGroupPanel.Padding = new System.Windows.Forms.Padding(16);
            this._tourGroupPanel.Size = new System.Drawing.Size(240, 661);
            this._tourGroupPanel.TabIndex = 1;
            // 
            // _returnDateLb
            // 
            this._returnDateLb.Dock = System.Windows.Forms.DockStyle.Top;
            this._returnDateLb.Font = new System.Drawing.Font("Constantia", 13.5F);
            this._returnDateLb.Location = new System.Drawing.Point(16, 324);
            this._returnDateLb.Name = "_returnDateLb";
            this._returnDateLb.Size = new System.Drawing.Size(206, 44);
            this._returnDateLb.TabIndex = 8;
            this._returnDateLb.Text = "...";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Constantia", 10F);
            this.label8.Location = new System.Drawing.Point(16, 292);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label8.Size = new System.Drawing.Size(206, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày trở về";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _departDateLb
            // 
            this._departDateLb.Dock = System.Windows.Forms.DockStyle.Top;
            this._departDateLb.Font = new System.Drawing.Font("Constantia", 13.5F);
            this._departDateLb.Location = new System.Drawing.Point(16, 248);
            this._departDateLb.Name = "_departDateLb";
            this._departDateLb.Size = new System.Drawing.Size(206, 44);
            this._departDateLb.TabIndex = 6;
            this._departDateLb.Text = "...";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Constantia", 10F);
            this.label6.Location = new System.Drawing.Point(16, 216);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label6.Size = new System.Drawing.Size(206, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày khởi hành";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _tourNameLb
            // 
            this._tourNameLb.Dock = System.Windows.Forms.DockStyle.Top;
            this._tourNameLb.Font = new System.Drawing.Font("Constantia", 13.5F);
            this._tourNameLb.Location = new System.Drawing.Point(16, 172);
            this._tourNameLb.Name = "_tourNameLb";
            this._tourNameLb.Size = new System.Drawing.Size(206, 44);
            this._tourNameLb.TabIndex = 4;
            this._tourNameLb.Text = "...";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Constantia", 10F);
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label4.Size = new System.Drawing.Size(206, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên tour";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _tourGroupNameLb
            // 
            this._tourGroupNameLb.Dock = System.Windows.Forms.DockStyle.Top;
            this._tourGroupNameLb.Font = new System.Drawing.Font("Constantia", 13.5F);
            this._tourGroupNameLb.Location = new System.Drawing.Point(16, 96);
            this._tourGroupNameLb.Name = "_tourGroupNameLb";
            this._tourGroupNameLb.Size = new System.Drawing.Size(206, 44);
            this._tourGroupNameLb.TabIndex = 2;
            this._tourGroupNameLb.Text = "...";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Constantia", 10F);
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label2.Size = new System.Drawing.Size(206, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đoàn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đoàn du lịch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(240, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16);
            this.panel1.Size = new System.Drawing.Size(744, 661);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._resultGv);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(16, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 504);
            this.panel3.TabIndex = 14;
            // 
            // _resultGv
            // 
            this._resultGv.AllowUserToAddRows = false;
            this._resultGv.AutoGenerateColumns = false;
            this._resultGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._resultGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._resultGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._resultGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._noColumn,
            this._idColumn,
            this._nameColumn,
            this._genderColumn});
            this._resultGv.DataSource = this._employeeBindingSource;
            this._resultGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this._resultGv.EnableHeadersVisualStyles = false;
            this._resultGv.Location = new System.Drawing.Point(0, 0);
            this._resultGv.Margin = new System.Windows.Forms.Padding(4);
            this._resultGv.Name = "_resultGv";
            this._resultGv.RowHeadersVisible = false;
            this._resultGv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this._resultGv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this._resultGv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Constantia", 11.5F);
            this._resultGv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._resultGv.RowTemplate.DefaultCellStyle.NullValue = "...";
            this._resultGv.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4);
            this._resultGv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this._resultGv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._resultGv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._resultGv.RowTemplate.Height = 48;
            this._resultGv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._resultGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._resultGv.ShowEditingIcon = false;
            this._resultGv.Size = new System.Drawing.Size(712, 468);
            this._resultGv.TabIndex = 12;
            this._resultGv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this._resultGv_CellFormatting);
            this._resultGv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._resultGv_CellMouseDoubleClick);
            // 
            // _noColumn
            // 
            this._noColumn.FillWeight = 30F;
            this._noColumn.HeaderText = "STT";
            this._noColumn.Name = "_noColumn";
            this._noColumn.ReadOnly = true;
            // 
            // _idColumn
            // 
            this._idColumn.DataPropertyName = "id";
            this._idColumn.FillWeight = 60F;
            this._idColumn.HeaderText = "Mã nhân viên";
            this._idColumn.Name = "_idColumn";
            this._idColumn.ReadOnly = true;
            // 
            // _nameColumn
            // 
            this._nameColumn.DataPropertyName = "name";
            this._nameColumn.HeaderText = "Họ tên";
            this._nameColumn.Name = "_nameColumn";
            this._nameColumn.ReadOnly = true;
            // 
            // _genderColumn
            // 
            this._genderColumn.DataPropertyName = "EmployeeRole";
            this._genderColumn.HeaderText = "Chức vụ";
            this._genderColumn.Name = "_genderColumn";
            this._genderColumn.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this._countLb);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 468);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(712, 36);
            this.panel5.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(573, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _countLb
            // 
            this._countLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this._countLb.Dock = System.Windows.Forms.DockStyle.Right;
            this._countLb.Font = new System.Drawing.Font("Constantia", 13.5F);
            this._countLb.Location = new System.Drawing.Point(640, 0);
            this._countLb.Name = "_countLb";
            this._countLb.Size = new System.Drawing.Size(72, 36);
            this._countLb.TabIndex = 9;
            this._countLb.Text = "...";
            this._countLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._showStateCb);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this._searchBtn);
            this.panel2.Controls.Add(this._searchTb);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(16, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 77);
            this.panel2.TabIndex = 12;
            // 
            // _showStateCb
            // 
            this._showStateCb.Dock = System.Windows.Forms.DockStyle.Right;
            this._showStateCb.Location = new System.Drawing.Point(426, 0);
            this._showStateCb.Name = "_showStateCb";
            this._showStateCb.Padding = new System.Windows.Forms.Padding(24, 16, 16, 4);
            this._showStateCb.Size = new System.Drawing.Size(191, 77);
            this._showStateCb.TabIndex = 21;
            this._showStateCb.Text = "Chỉ hiển thị nhân viên tour này";
            this._showStateCb.UseVisualStyleBackColor = true;
            this._showStateCb.CheckedChanged += new System.EventHandler(this._showStateCb_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.removeAllBtn);
            this.panel4.Controls.Add(this.addAllBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(617, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(8);
            this.panel4.Size = new System.Drawing.Size(95, 77);
            this.panel4.TabIndex = 20;
            // 
            // removeAllBtn
            // 
            this.removeAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.removeAllBtn.ImageIndex = 0;
            this.removeAllBtn.ImageList = this.removeAllBtnImageList;
            this.removeAllBtn.Location = new System.Drawing.Point(49, 29);
            this.removeAllBtn.Name = "removeAllBtn";
            this.removeAllBtn.Size = new System.Drawing.Size(32, 32);
            this.removeAllBtn.TabIndex = 1;
            this.removeAllBtn.UseVisualStyleBackColor = true;
            this.removeAllBtn.Click += new System.EventHandler(this.removeAllBtn_Click);
            // 
            // removeAllBtnImageList
            // 
            this.removeAllBtnImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("removeAllBtnImageList.ImageStream")));
            this.removeAllBtnImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.removeAllBtnImageList.Images.SetKeyName(0, "ic_remove_all.png");
            this.removeAllBtnImageList.Images.SetKeyName(1, "ic_remove_all_disable.png");
            // 
            // addAllBtn
            // 
            this.addAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.addAllBtn.ImageIndex = 0;
            this.addAllBtn.ImageList = this.addAllBtnImageList;
            this.addAllBtn.Location = new System.Drawing.Point(11, 29);
            this.addAllBtn.Name = "addAllBtn";
            this.addAllBtn.Size = new System.Drawing.Size(32, 32);
            this.addAllBtn.TabIndex = 0;
            this.addAllBtn.UseVisualStyleBackColor = true;
            this.addAllBtn.Click += new System.EventHandler(this.addAllBtn_Click);
            // 
            // addAllBtnImageList
            // 
            this.addAllBtnImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("addAllBtnImageList.ImageStream")));
            this.addAllBtnImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.addAllBtnImageList.Images.SetKeyName(0, "ic_add_all.png");
            this.addAllBtnImageList.Images.SetKeyName(1, "ic_add_all_disable.png");
            // 
            // _searchBtn
            // 
            this._searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._searchBtn.FlatAppearance.BorderSize = 0;
            this._searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._searchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._searchBtn.Location = new System.Drawing.Point(357, 36);
            this._searchBtn.Name = "_searchBtn";
            this._searchBtn.Size = new System.Drawing.Size(77, 26);
            this._searchBtn.TabIndex = 19;
            this._searchBtn.Text = "Tìm";
            this._searchBtn.UseVisualStyleBackColor = false;
            this._searchBtn.Click += new System.EventHandler(this._searchBtn_Click);
            // 
            // _searchTb
            // 
            this._searchTb.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._searchTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this._searchTb.Location = new System.Drawing.Point(22, 36);
            this._searchTb.Name = "_searchTb";
            this._searchTb.Size = new System.Drawing.Size(310, 26);
            this._searchTb.TabIndex = 5;
            this._searchTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._searchTb_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(15, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 18);
            this.label18.TabIndex = 4;
            this.label18.Text = "Tìm kiếm nhanh";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(712, 48);
            this.label3.TabIndex = 11;
            this.label3.Text = "Danh sách nhân viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fmTourGroupEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._tourGroupPanel);
            this.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmTourGroupEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fmTourGroupEmployees";
            this.Load += new System.EventHandler(this.fmTourGroupEmployees_Load);
            this._tourGroupPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._resultGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._employeeBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _tourGroupPanel;
        private System.Windows.Forms.Label _returnDateLb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label _departDateLb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _tourNameLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _tourGroupNameLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox _showStateCb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button removeAllBtn;
        private System.Windows.Forms.Button addAllBtn;
        private System.Windows.Forms.Button _searchBtn;
        private System.Windows.Forms.TextBox _searchTb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ImageList addAllBtnImageList;
        private System.Windows.Forms.ImageList removeAllBtnImageList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView _resultGv;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label _countLb;
        private System.Windows.Forms.BindingSource _employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn _noColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _genderColumn;
    }
}