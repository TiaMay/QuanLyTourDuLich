namespace QuanLyTourDuLich
{
    partial class frmEmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeManagement));
            this.employeeDgv = new System.Windows.Forms.DataGridView();
            this.controlCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.noCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBs = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.employeeNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeRoleCb = new System.Windows.Forms.ComboBox();
            this.employeeRolesBs = new System.Windows.Forms.BindingSource(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.discardBtn = new System.Windows.Forms.Button();
            this.discardBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this.deleteBtn = new System.Windows.Forms.Button();
            this.deleteBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this.addBtn = new System.Windows.Forms.Button();
            this.addBtnImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this._backBtnPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRolesBs)).BeginInit();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this._backBtnPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeDgv
            // 
            this.employeeDgv.AllowUserToAddRows = false;
            this.employeeDgv.AllowUserToDeleteRows = false;
            this.employeeDgv.AllowUserToResizeColumns = false;
            this.employeeDgv.AllowUserToResizeRows = false;
            this.employeeDgv.AutoGenerateColumns = false;
            this.employeeDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.controlCol,
            this.noCol,
            this._idColumn,
            this.nameCol,
            this.roleCol});
            this.employeeDgv.DataSource = this.employeesBs;
            this.employeeDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDgv.Location = new System.Drawing.Point(32, 32);
            this.employeeDgv.Name = "employeeDgv";
            this.employeeDgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.employeeDgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.employeeDgv.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4);
            this.employeeDgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.employeeDgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.employeeDgv.RowTemplate.Height = 32;
            this.employeeDgv.Size = new System.Drawing.Size(920, 414);
            this.employeeDgv.TabIndex = 0;
            this.employeeDgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.employeeDgv_CellFormatting);
            this.employeeDgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDgv_CellValueChanged);
            this.employeeDgv.SelectionChanged += new System.EventHandler(this.employeeDgv_SelectionChanged);
            // 
            // controlCol
            // 
            this.controlCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.controlCol.HeaderText = "";
            this.controlCol.Name = "controlCol";
            this.controlCol.Width = 40;
            // 
            // noCol
            // 
            this.noCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.noCol.HeaderText = "STT";
            this.noCol.Name = "noCol";
            this.noCol.ReadOnly = true;
            this.noCol.Width = 40;
            // 
            // _idColumn
            // 
            this._idColumn.DataPropertyName = "id";
            this._idColumn.FillWeight = 50F;
            this._idColumn.HeaderText = "Mã nhân viên";
            this._idColumn.Name = "_idColumn";
            this._idColumn.ReadOnly = true;
            // 
            // nameCol
            // 
            this.nameCol.DataPropertyName = "name";
            this.nameCol.HeaderText = "Tên";
            this.nameCol.Name = "nameCol";
            // 
            // roleCol
            // 
            this.roleCol.DataPropertyName = "EmployeeRole";
            this.roleCol.HeaderText = "Vai trò";
            this.roleCol.Name = "roleCol";
            this.roleCol.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhân viên";
            // 
            // employeeNameTb
            // 
            this.employeeNameTb.Location = new System.Drawing.Point(154, 18);
            this.employeeNameTb.Name = "employeeNameTb";
            this.employeeNameTb.Size = new System.Drawing.Size(314, 26);
            this.employeeNameTb.TabIndex = 2;
            this.employeeNameTb.TextChanged += new System.EventHandler(this.employeeNameTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vai trò";
            // 
            // employeeRoleCb
            // 
            this.employeeRoleCb.DataSource = this.employeeRolesBs;
            this.employeeRoleCb.DisplayMember = "id";
            this.employeeRoleCb.FormattingEnabled = true;
            this.employeeRoleCb.Location = new System.Drawing.Point(154, 60);
            this.employeeRoleCb.Name = "employeeRoleCb";
            this.employeeRoleCb.Size = new System.Drawing.Size(229, 26);
            this.employeeRoleCb.TabIndex = 4;
            this.employeeRoleCb.ValueMember = "id";
            this.employeeRoleCb.SelectedValueChanged += new System.EventHandler(this.employeeRoleCb_SelectedValueChanged);
            // 
            // topPanel
            // 
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.discardBtn);
            this.topPanel.Controls.Add(this.saveBtn);
            this.topPanel.Controls.Add(this.deleteBtn);
            this.topPanel.Controls.Add(this.addBtn);
            this.topPanel.Controls.Add(this.employeeNameTb);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.employeeRoleCb);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 80);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(984, 103);
            this.topPanel.TabIndex = 7;
            this.topPanel.Layout += new System.Windows.Forms.LayoutEventHandler(this.topPanel_Layout);
            // 
            // discardBtn
            // 
            this.discardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.discardBtn.ImageIndex = 0;
            this.discardBtn.ImageList = this.discardBtnImageList;
            this.discardBtn.Location = new System.Drawing.Point(596, 19);
            this.discardBtn.Name = "discardBtn";
            this.discardBtn.Size = new System.Drawing.Size(28, 28);
            this.discardBtn.TabIndex = 10;
            this.discardBtn.UseVisualStyleBackColor = true;
            this.discardBtn.Click += new System.EventHandler(this.discardBtn_Click);
            // 
            // discardBtnImageList
            // 
            this.discardBtnImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("discardBtnImageList.ImageStream")));
            this.discardBtnImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.discardBtnImageList.Images.SetKeyName(0, "ic_revert.png");
            this.discardBtnImageList.Images.SetKeyName(1, "ic_revert_disabled.png");
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.saveBtn.ImageIndex = 0;
            this.saveBtn.ImageList = this.saveBtnImageList;
            this.saveBtn.Location = new System.Drawing.Point(565, 19);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(28, 28);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveBtnImageList
            // 
            this.saveBtnImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("saveBtnImageList.ImageStream")));
            this.saveBtnImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.saveBtnImageList.Images.SetKeyName(0, "ic_save.png");
            this.saveBtnImageList.Images.SetKeyName(1, "ic_save_disabled.png");
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.deleteBtn.ImageIndex = 0;
            this.deleteBtn.ImageList = this.deleteBtnImageList;
            this.deleteBtn.Location = new System.Drawing.Point(531, 19);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(28, 28);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteEmployeeBtn_Click);
            // 
            // deleteBtnImageList
            // 
            this.deleteBtnImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("deleteBtnImageList.ImageStream")));
            this.deleteBtnImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.deleteBtnImageList.Images.SetKeyName(0, "ic_remove.png");
            this.deleteBtnImageList.Images.SetKeyName(1, "ic_remove_disabled.png");
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.addBtn.ImageIndex = 0;
            this.addBtn.ImageList = this.addBtnImageList;
            this.addBtn.Location = new System.Drawing.Point(497, 19);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(28, 28);
            this.addBtn.TabIndex = 7;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // addBtnImageList
            // 
            this.addBtnImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("addBtnImageList.ImageStream")));
            this.addBtnImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.addBtnImageList.Images.SetKeyName(0, "ic_add.png");
            this.addBtnImageList.Images.SetKeyName(1, "ic_add_disabled.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this._backBtnPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 80);
            this.panel2.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(314, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(393, 37);
            this.label7.TabIndex = 16;
            this.label7.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // _backBtnPanel
            // 
            this._backBtnPanel.Controls.Add(this.btnBack);
            this._backBtnPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._backBtnPanel.Location = new System.Drawing.Point(0, 0);
            this._backBtnPanel.Margin = new System.Windows.Forms.Padding(0);
            this._backBtnPanel.Name = "_backBtnPanel";
            this._backBtnPanel.Padding = new System.Windows.Forms.Padding(12);
            this._backBtnPanel.Size = new System.Drawing.Size(80, 80);
            this._backBtnPanel.TabIndex = 30;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.BackgroundImage = global::QuanLyTourDuLich.Properties.Resources.back_left_arrow_circular_button_outline;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 56);
            this.btnBack.TabIndex = 29;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.employeeDgv);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Constantia", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(0, 183);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(32);
            this.mainPanel.Size = new System.Drawing.Size(984, 478);
            this.mainPanel.TabIndex = 30;
            // 
            // frmEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployeeManagement";
            this.Load += new System.EventHandler(this.frmEmployeeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRolesBs)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this._backBtnPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDgv;
        private System.Windows.Forms.BindingSource employeesBs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox employeeRoleCb;
        private System.Windows.Forms.BindingSource employeeRolesBs;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel _backBtnPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ImageList addBtnImageList;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ImageList deleteBtnImageList;
        private System.Windows.Forms.ImageList saveBtnImageList;
        private System.Windows.Forms.Button discardBtn;
        private System.Windows.Forms.ImageList discardBtnImageList;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn controlCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn _idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleCol;
    }
}