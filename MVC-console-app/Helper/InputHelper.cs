using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MVC_console_app.Helper
{
    class InputHelper
    {
        public static int InputNumber (string NameinputUser,string err)
        {
            bool check = true;
            int ret;

            do
            {
                Console.WriteLine(NameinputUser);
                check = int.TryParse(Console.ReadLine(), out ret);

                if (!check) Console.WriteLine(err);
            } while (!check);

            return ret;
        }

        public static string InputString(string NameinputUser, string err,int minLength = 0,int MaxLength = int.MaxValue)
        {
            bool check = true;
            string output;

            do
            {
                Console.WriteLine(NameinputUser);
                output = Console.ReadLine();

                if (!(output.Length >= minLength || output.Length <= MaxLength)) Console.WriteLine(err);
            } while (!check);

            return output;
        }

        public static DateTime InputDeteTime (string NameInputUser,string err,DateTime min,DateTime max)
        {
            bool check = false;
            DateTime output;

            do
            {
                Console.WriteLine(NameInputUser);
                check = DateTime.TryParse(Console.ReadLine(),out output);

                if (check && !(output >= min || output <= max)) Console.WriteLine(err);
            } while (!check);

            return output;
        }
    }
}
