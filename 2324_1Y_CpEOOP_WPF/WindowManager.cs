using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_CpEOOP_WPF
{
    internal static class WindowManager
    {
        public static Window1 w1 = null;
        public static bool w1_exist = false;

        public static void w1_status(bool open)
        {
            if(!w1_exist && open)
            {
                w1 = new Window1();
                w1.Show();
                w1_exist = true;
            }
            else if(!open)
            {
                w1_exist = false;
            }
        }
    }
}
