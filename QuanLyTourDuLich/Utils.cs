using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTourDuLich
{
    class Utils
    {
        
        public static void cursorWait()
        {
            Cursor.Current = Cursors.WaitCursor;
        }

        public static void cursorDefault()
        {
            Cursor.Current = Cursors.Default;
        }
    }
}
