using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Store
{
    static class Program
    {
        /// The main entry point for the application.
        /// 
        [STAThread]
        static void Main()
        {
            Driver driver = new Driver();
        }
    }
}
