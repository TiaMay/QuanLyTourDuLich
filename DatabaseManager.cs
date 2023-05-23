using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.IO;

namespace QuanLyTourDuLich
{
    class DatabaseManager
    {
        private static DatabaseManager _instance;
        private string _subFolder;
        private string _dbName;
        private string _dbLogName;
        private string _connectionString;

        private DatabaseManager()
        {
            _subFolder = QuanLyTourDuLich.Resources.Constants.subFolderDb;
            _dbName = QuanLyTourDuLich.Resources.Constants.dbName;
            _dbLogName = QuanLyTourDuLich.Resources.Constants.dbLogName;
            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QuanLyTourDuLich.Properties.Settings.DatabaseConnectionString"].ToString();
        }

        public static DatabaseManager getInsance()
        {
            if (_instance == null)
            {
                _instance = new DatabaseManager();
            }
            return _instance;
        }

        public bool isValidDataFile()
        {
            return File.Exists(
                QuanLyTourDuLich.Program.AppDataDirectory.AppDataRoot +
                SubFolder + DbName);
        }

        public void createDataFile()
        {
            Directory.CreateDirectory(QuanLyTourDuLich.Program.AppDataDirectory.AppDataRoot + SubFolder);
            File.Copy(QuanLyTourDuLich.Program.AppDataDirectory.OriginRoot + SubFolder + DbName,
                QuanLyTourDuLich.Program.AppDataDirectory.AppDataRoot + SubFolder + DbName);
            // Nếu trườn hợp chỉ có log file mà không còn file mdf thì override
            File.Copy(QuanLyTourDuLich.Program.AppDataDirectory.OriginRoot + SubFolder + DbLogName,
                QuanLyTourDuLich.Program.AppDataDirectory.AppDataRoot +SubFolder + DbLogName, true);
        }

        public string SubFolder
        {
            get { return _subFolder; }
            set { _subFolder = value; }
        }

        public string DbName
        {
            get { return _dbName; }
            set { _dbName = value; }
        }

        public string DbLogName
        {
            get { return _dbLogName; }
            set { _dbLogName = value; }
        }

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }


    }
}
