using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_console_app.Controller;
using MVC_console_app.Model;
using MVC_console_app.Helper;

namespace MVC_console_app.View
{
    class StudentView
    {
        StudentsController ListStudents = new StudentsController(); 

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("================= Menu =================");
            Console.WriteLine("1. Show Class list Studetn .");
            Console.WriteLine("2. add student to list .");
            Console.WriteLine("3. Update Student in Class list .");
            Console.WriteLine("4. Remove Student in Class list .");
            Console.WriteLine("*. turn off! ");
            Console.WriteLine("=======================================");
            Console.WriteLine("choose option!");
            Console.WriteLine();
            string option = Console.ReadLine();

            DoAction(option);
        }

        private void DoAction(string option)
        {
            switch(option)
            {
                case "1":
                    ErrorHelper.log(ListStudents.StudentsGet());
                    break;
                case "2":
                    ErrorHelper.log(ListStudents.AddStudent(new Student()));
                    break;
                case "3":
                    ErrorHelper.log(ListStudents.UpdateStudent(new Student()));
                    break;
                case "4":
                    ErrorHelper.log(ListStudents.RemoveStudent(InputHelper.InputNumber("ID student remove!", "student not must!")));
                    break;
                default:
                    return;
            }   

            Console.ReadKey();
            Menu();
        }
    }
}
