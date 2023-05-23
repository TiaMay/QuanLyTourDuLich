using BusinessEntity;
using DTO;
using QuanLyTourDuLich.Presenters;
using QuanLyTourDuLich.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTourDuLich.Forms
{
    public partial class fmTourGroupEmployees : Form, IEmployeeView
    {
        TourGroup _tourGroup;

        IEmployeePresenter _presenter;

        int _touGroupId;

        public fmTourGroupEmployees(int tourGroupId)
        {
            InitializeComponent();

            _touGroupId = tourGroupId;

            _presenter = new EmployeePresenter(this);
        }

        private void fmTourGroupEmployees_Load(object sender, EventArgs e)
        {
            _tourGroup = _presenter.loadTourGroupById(_touGroupId);

            _tourGroupNameLb.DataBindings.Add("Text", _tourGroup, "name");
            _tourNameLb.DataBindings.Add("Text", _tourGroup.Tour, "name");
            _departDateLb.DataBindings.Add("Text", _tourGroup, "depart_date");
            _returnDateLb.DataBindings.Add("Text", _tourGroup, "return_date");

            this.search();
        }

        private void search()
        {
            _presenter.search(_searchTb.Text.Trim());
        }

        public void updateEmployeeView(IEnumerable<Employee> employees)
        {
            var isChecked = (_showStateCb as CheckBox).Checked;
            if (isChecked == true)
                employees = employees.Where(customer => customer.TourGroups.Any(t => t.id == _tourGroup.id));
            _countLb.Text = employees.Count().ToString();
            _employeeBindingSource.DataSource = employees;
            _resultGv.ClearSelection();

        }

        private void _resultGv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (_resultGv.Columns[e.ColumnIndex].HeaderText == "STT")
            {
                e.Value = e.RowIndex + 1;

                var employees = _employeeBindingSource.DataSource as IEnumerable<Employee>;
                if (employees.Count() <= e.RowIndex)
                    return;     // i dont know why. just fix some fucking crash
                var emp = (_employeeBindingSource.DataSource as IEnumerable<Employee>).ElementAt(e.RowIndex);

                if (_tourGroup.Employees.Contains(emp, new EmployeeComparer()))
                {
                    _resultGv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(51, 255, 102);
                }
                else
                {
                    _resultGv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }

            if (e.Value == null)
                return;
            if (_resultGv.Columns[e.ColumnIndex].HeaderText == "Chức vụ")
            {
                if (e.Value != null)
                    e.Value = (e.Value as EmployeeRole).name;
            }

        }

        private void addAllBtn_Click(object sender, EventArgs e)
        {
            var selectedCustomer = _resultGv.SelectedRows;
            int selectedIndex;
            Employee employee = null;
            foreach (var row in selectedCustomer)
            {
                selectedIndex = (row as DataGridViewBand).Index;
                employee = (_employeeBindingSource.DataSource as IEnumerable<Employee>).ElementAt(selectedIndex);
                _presenter.addPassengerToTourGroup(employee, _tourGroup);
            }
            //this.search(_tourGroupKeywordTb.Text.Trim());
            this.search();
        }

        private void _showStateCb_CheckedChanged(object sender, EventArgs e)
        {
            this.search();
        }

        private void _searchBtn_Click(object sender, EventArgs e)
        {
            this.search();
        }

        private void _searchTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.search();
        }

        private void _resultGv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var employee = (_employeeBindingSource.DataSource as IEnumerable<Employee>).ElementAt(e.RowIndex);
            _presenter.toggleCustomerTourGroupStatus(employee, _tourGroup);
            this.search();
        }

        private void removeAllBtn_Click(object sender, EventArgs e)
        {
            var selectedEmployee = _resultGv.SelectedRows;

            int selectedIndex;
            Employee emp = null;
            foreach (var row in selectedEmployee)
            {
                selectedIndex = (row as DataGridViewBand).Index;
                emp = (_employeeBindingSource.DataSource as IEnumerable<Employee>).ElementAt(selectedIndex);
                _presenter.removePassengerFromTourGroup(emp, _tourGroup);
            }
            this.search();
        }


    }
    public class EmployeeComparer : IEqualityComparer<Employee>
    {

        public bool Equals(Employee x, Employee y)
        {
            return x.id == y.id;
        }

        public int GetHashCode(Employee obj)
        {
            return obj.id;
        }
    }
}
