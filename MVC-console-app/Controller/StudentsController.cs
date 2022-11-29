using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_console_app.Model;
using MVC_console_app.Helper;


namespace MVC_console_app.Controller
{
    class StudentsController
    {
        List<Student> students = new List<Student>();
        
        public ErrorType AddStudent(Student student)
        {
            if(students.Count > 0)
            {
                students.Add(student);
                return ErrorType.success;
            }

            int indexStudentCheck = students.FindIndex(s => s.ID == student.ID);

            if(indexStudentCheck == -1) 
            {
                students.Add(student);
                return ErrorType.success;
            }else return ErrorType.warning;
        }

        public ErrorType UpdateStudent(Student student) 
        {
            if(students.Count == 0 ) 
            {
                return ErrorType.warning;
            }

            int indexStudentCheck = students.FindIndex(s => s.ID == student.ID);

            if(indexStudentCheck > -1)
            {
                students[indexStudentCheck] = student;
                return ErrorType.success;
                
            }else return ErrorType.error;
        }

        public ErrorType RemoveStudent(int student) 
        {
            if (students.Count == 0)
            {
                return ErrorType.warning;
            }

            int indexStudentCheck = students.FindIndex(s => s.ID == student);

            if (indexStudentCheck > -1)
            {
                students.RemoveAt(indexStudentCheck);
                return ErrorType.success;

            }
            else return ErrorType.error;
        }

        public ErrorType StudentsGet() 
        {
            if(students.Count == 0)
                return ErrorType.warning;

            students.ForEach(student => student.ShowStudent());
            return ErrorType.success;
        }
    }
}
