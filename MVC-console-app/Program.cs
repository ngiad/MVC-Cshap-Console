using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_console_app.View;

namespace MVC_console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentView app = new StudentView();

            app.Menu();
        }
    }
}
