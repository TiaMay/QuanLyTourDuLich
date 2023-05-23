using BusinessEntity;
using DTO;
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
    public partial class frmEmployeeManagement : Form
    {
        EmployeeBUS _employeeBus;
        //EmployeeRoleBUS _employeeRoleBus;

        IEnumerable<Employee> _employees;
        IEnumerable<EmployeeRole> _employeeRoles;

        public frmEmployeeManagement()
        {
            InitializeComponent();

            _employeeBus = new EmployeeBUS();
           // _employeeRoleBus = new EmployeeRoleBUS();

        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            init();
            employeeRoleCb.DisplayMember = "name";
            setSaveBtnEnabeled(false);
        }

        private void init()
        {
            _employees = _employeeBus.getEntries();
            _employeeRoles = _employeeBus.getEmployeeRole();

            employeesBs.DataSource = _employees.ToDataTable();
            employeeRolesBs.DataSource = _employeeRoles;
        }

        private void employeeRoleCb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (employeeRoleCb.SelectedValue != null)
            {
                employeesBs.Filter = "role = " + employeeRoleCb.SelectedValue;
            }
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            //if (employeeNameTb.Text.Length <= 0)
            //{
            //    MessageBox.Show("Tên nhân viên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (employeeNameTb.Text.Length >= 1)
            //{
            //    Employee newEmployee = new Employee();
            //    newEmployee.name = employeeNameTb.Text;
            //    newEmployee.role = int.Parse(employeeRoleCb.SelectedValue.ToString());

            //    _employeeBus.add(newEmployee);

            //    init();
            //}
            var empl = new Employee();
            empl.name = employeeNameTb.Text.Trim();
            empl.Status1 = _employeeBus.getStatusById(1);
            empl.role = int.Parse(employeeRoleCb.SelectedValue.ToString());
            _employeeBus.add(empl);
            init();
            employeeNameTb.Clear();
            addBtn.Enabled = false;
        }

        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa những dòng đã chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in employeeDgv.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        _employeeBus.deleteById(int.Parse(row.Cells[2].Value.ToString()));
                    }
                }
                init();
            }
        }

        private void topPanel_Layout(object sender, LayoutEventArgs e)
        {
            addBtn.Enabled = isEnabledAddBtn();
        }

        private bool isEnabledAddBtn()
        {
            if (String.IsNullOrWhiteSpace(employeeNameTb.Text))
                return false;
            return true;
        }

        private void employeeNameTb_TextChanged(object sender, EventArgs e)
        {
            addBtn.Enabled = isEnabledAddBtn();
        }

        private void employeeDgv_SelectionChanged(object sender, EventArgs e)
        {
             //deleteBtn.Enabled = employeeDgv.SelectedRows.Count != 0;
        }

        private void employeeDgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                return;
            setSaveBtnEnabeled(true);
        }

        private void setSaveBtnEnabeled(bool isenabled)
        {
            saveBtn.Enabled = isenabled;
            discardBtn.Enabled = isenabled;
        }

        private void employeeDgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (employeeDgv.Columns[e.ColumnIndex].HeaderText == "STT")
            {
                e.Value = e.RowIndex + 1;
            }
            if (e.Value == null)
                return;
            if (employeeDgv.Columns[e.ColumnIndex].HeaderText == "Vai trò")
            {
                e.Value = (e.Value as EmployeeRole).name;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _employeeBus.updateAll(employeesBs.DataSource as IEnumerable<Employee>);
            init();
            Cursor.Current = Cursors.Default;
            setSaveBtnEnabeled(false);
        }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _employeeBus.refresh();
            init();
            Cursor.Current = Cursors.Default;
            setSaveBtnEnabeled(false);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
