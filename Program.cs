using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTourDuLich
{

    static class Program
    {
        public static string CompanyName = "OOD";
        public static string AppName = "TourManagement";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //initAppData();

            //// Nếu chưa tồn tại file db thì copy file db gốc vào thư mục db
            //if (DatabaseManager.getInsance().isValidDataFile() == false)
            //{
            //    DatabaseManager.getInsance().createDataFile();
            //}

            // keep above. don't uncomment it. but don't delete it.

            // code behind just test. also example 

            /* Bussiness object for all you need */
            var bus = new BusinessEntity.CustomerBUS();

            /* Get by Id Examples */
            // var c = bus.getCustomerById(2);

            /* Get all Examples */ 
            // var all = bus.getEntries();

            /* Insert example */
            //DTO.Customer newC = new DTO.Customer()
            //{
            //    address = "some thing new",
            //    gender = 4,
            //    name = "TungHH",
            //    nationality = "Vn"
            //};
            //bus.add(newC);
            
            /* Delete example */
            //bus.deletaById(2);

            /* Update example */
            //c.name = "Tung";
            //bus.update(c);

            /* end test. */

            // Chú ý
            // File database dùng để chỉnh sửa là file ở thư mục QUanLyTourDuLich/Resource/db/TourManager.mdf
            // Khi chạy chuong trình, complier tự động copy database và thư mục QUanLyTourDuLich/bin/Debug[hoặc Release]/Resource/db/TourManager.mdf
            // Để kiểm tra sự thay đổi khi chạy chương trình thì kiểm tra file trong thư mục bin
            // Ví dụ insert new Customer thì customer mới nằm trong file của thư mục bin
            // còn file trong thư mục của project thì chỉ dùng để edit. 


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmMain());
        }

        private static void initAppData()
        {
            AppDataDirectory.OriginRoot = System.IO.Directory.GetCurrentDirectory();
            // Get đường dẫn tuyệt đối cho %AppData%
            string windowAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // thư mục root của ứng dụng là %AppData%\TênTổChức\TênApp
            AppDataDirectory.AppDataRoot = windowAppDataPath + "\\" + CompanyName + "\\" + AppName;

            // Nếu thư mục không tồn tại thì tạo thư mục mới
            if (Directory.Exists(AppDataDirectory.AppDataRoot) == false)
                System.IO.Directory.CreateDirectory(AppDataDirectory.AppDataRoot);

            // Set thư mục gốc của ứng dụng trở thành thư mục AppData
            System.IO.Directory.SetCurrentDirectory(AppDataDirectory.AppDataRoot);

            // Set thư mục DataDirectory để dùng cho connectionString
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDataDirectory.AppDataRoot);
        }

        public class AppDataDirectory
        {
            public static string OriginRoot = "";
            public static string AppDataRoot = "";
        }
    }
}
