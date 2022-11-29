using MVC_console_app.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_console_app.Model
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }


        public Student()
        {
            ID = InputHelper.InputNumber("ID Student","this is not Number!");
            Name = InputHelper.InputString("Name Student", "Name must ve up characters!");
            Birthday = InputHelper.InputDeteTime("Student's date of birth", "this is not birtDay",new DateTime(1990,1,1),new DateTime(2022,11,29));
        }

        public void ShowStudent ()
        {
            Console.WriteLine($"ID : {this.ID} \nName : {this.Name}\nDate of birth : {this.Birthday.ToShortDateString()}");
        }
    }
}
