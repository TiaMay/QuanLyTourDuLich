using Microsoft.SqlServer.Management.Common; // ServerConnection
using Microsoft.SqlServer.Management.Smo; // Server
using Microsoft.Win32; // RegistryView
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // SqlConnection
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTourDuLich.GUI
{
    public partial class fmConnectDatabase : Form
    {
        private List<string> _serverList;
        public static string _connectionString = null;
        private Server _getDatabaseName;
        private ServerConnection _serverConnection;
        private string _serverName;
        private string _databaseName;
        private string _userName;
        private string _passWord;
        private bool _integratedSecurity;
        private bool _resultConnectedServer = false;
        private bool _resultConnectedDatabase = false;


        public fmConnectDatabase()
        {
            InitializeComponent();
        }

        //
        //fmConnectDatabase: Event Load
        //
        private void fmConnectDatabase_Load(object sender, EventArgs e)
        {
            _integratedSecurity = true;
            grbConnectServer.Enabled = true;
            grbConnectDatabase.Enabled = false;
            btnSave.Enabled = false;

            _serverList = getAllNameServer();
            foreach (string s in _serverList)
                cbbServerName.Items.Add(s);

            cbbServerName.SelectedIndex = 1;
            cbbAuthentication.SelectedIndex = 0;
        }

        //
        //btnBack: Event Click
        //
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        //Function: checkServer
        //Output: Kiểm tra các server có trong máy
        public static List<string> checkServer()
        {
            List<string> _instanceNameList = new List<string>();

            RegistryView _registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey regKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, _registryView))
            {
                RegistryKey _instanceKey = regKey.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if(_instanceKey != null)
                {
                    foreach (var _instanceName in _instanceKey.GetValueNames())
                        _instanceNameList.Add(_instanceName);
                }
            }
            return _instanceNameList;
        }

        //
        //Function: getAllNameServer
        //Output: Trả về danh sách tên các server
        public static List<string> getAllNameServer()
        {
            List<string> _serverList = checkServer();
            List<string> _serverNameList = new List<string>();
            string _machineName = Environment.MachineName;
            _serverNameList.Add(_machineName);
            foreach(string s in _serverList)
            {
                _serverNameList.Add(_machineName + @"\" + s);
            }
            return _serverNameList;
        }

        //
        //cbbNameServer: Event SelectedIndexChanged
        //
        private void cbbNameServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            _serverName = cbbServerName.Text;
        }

        //
        //cbbAuthentication: Event SelectedIndexChanged
        //
        private void cbbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbAuthentication.SelectedIndex == 0)
            {
                txbUserName.Enabled = false;
                txbPassWord.Enabled = false;
                txbUserName.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
                _integratedSecurity = true;
                ckbShowPassword.Enabled = false;
            }
            else
            {
                txbUserName.Enabled = true;
                txbUserName.Clear();
                txbPassWord.Enabled = true;
                _integratedSecurity = false;
                ckbShowPassword.Enabled = true;
            }
        }

        //
        //btnExit: Event Click
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        //txbUserName: Event TextChanged
        //
        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            _userName = txbUserName.Text;
        }

        //
        //txbPassWord: Event TextChanged
        //
        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {
            _passWord = txbPassWord.Text;
        }

        //
        //ckbShowPassword: Event CheckedChanged
        //
        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPassword.Checked == true)
                txbPassWord.UseSystemPasswordChar = false;
            else
                txbPassWord.UseSystemPasswordChar = true;
        }

        //
        //btnConnect: Event Click
        //
        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if(cbbAuthentication.SelectedIndex == 0)
                {
                    if(serverConnection(serverConnectString(_serverName, "master", _integratedSecurity)))
                    {
                        _resultConnectedServer = true;
                        _serverConnection = new ServerConnection(cbbServerName.Text);
                        _getDatabaseName = new Server(_serverConnection);
                    }
                }
                else
                {
                    if(serverConnection(serverConnectString(_serverName, "master", _userName, _passWord, _integratedSecurity)))
                    {
                        _resultConnectedServer = true;
                        _serverConnection = new ServerConnection(cbbServerName.Text);
                        _getDatabaseName = new Server(_serverConnection);
                    }
                }

                getAllDatabaseName();

                if(_resultConnectedServer == true)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Kết nối đến SQL Server: " + _serverName + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grbConnectServer.Enabled = false;
                    grbConnectDatabase.Enabled = true;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Kết nối đến SQL Server: " + _serverName + " thất bại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grbConnectServer.Enabled = true;
                    grbConnectDatabase.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Cursor = Cursors.Default;
        }

        //
        //Function: connectServer
        //Output: Chuỗi kết nối đến server
        public static bool serverConnection(string connectString)
        {
            try
            {
                using (var conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    conn.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        //
        //Function: serverConnectString
        //Output: Gồm 2 hàm overload dùng để tạo chuỗi kết nối đến server
        public static string serverConnectString(string serverName, string dbName, string userName, string passWord, bool integratedSecurity)
        {
            return "Data Source=" + serverName.Trim() + ";Initial Catalog=" + dbName.Trim() + ";Integrated Security=" + integratedSecurity +
                ";User ID=" + userName.Trim() + ";Password=" + passWord + ";";
        }
        public static string serverConnectString(string serverName, string dbName, bool integratedSecurity)
        {
            return "Data Source=" + serverName.Trim() + ";Initial Catalog=" + dbName.Trim() + ";Integrated Security=" + integratedSecurity + ";";       
        }

        //
        //
        //
        private void getAllDatabaseName()
        {
            foreach(Database db in _getDatabaseName.Databases)
            {
                if (!db.IsSystemObject)
                    cbbDatabaseName.Items.Add(db.Name);
            }
        }
    }
}
