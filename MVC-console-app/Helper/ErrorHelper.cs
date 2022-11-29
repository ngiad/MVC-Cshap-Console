using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_console_app.Helper
{
    enum ErrorType
    {
        None,
        success,
        warning,
        error,
    }
    class ErrorHelper
    {
        public static void log(ErrorType err)
        { 
            switch(err) 
            {
               case ErrorType.None:
                    Console.WriteLine("perform all fail!");
                    break;
                case ErrorType.success:
                    Console.WriteLine("perform all success!");
                    break;
                case ErrorType.warning:
                    Console.WriteLine("perform all warning!");
                    break;      
                default:
                    Console.WriteLine("perform all error!");
                    break;
            }
        }
    }
}
