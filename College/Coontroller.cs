using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    internal class Coontroller
    {
        public static void addStudent(string student)
        {
            string sql = "if not exists (select studentName from Students\r\n--בדיקה האם המשתנה לא שווה לאחת מהסטודנטים\r\nwhere studentName =@student_name)\r\n\tbegin\r\n\t--הכנסת סטודנט לטבלה\r\n\t\tinsert into Students(studentName) values(@student_name)\r\n\tend";
            string[] parameters = { "@student_name" };
            string[] values = { student };
            DBconection.RunSqlNoReturn(sql, parameters, values);
        }
        public static List<string> GetCourses()
        {
            string sql = "select * from Courses";

            // Add items to the ListBox
            SqlDataReader CoursesReader = DBconection.RunSqlAllResult(sql);
            List<string> courses = new List<string>();
            for (int i = 0; CoursesReader.Read(); i++)
            {
                courses.Add(CoursesReader.GetString(1));
            }
            CoursesReader.Close();
            return courses;
        }
        public static List<string> SearchceCoursesName(string CoursesName)
        {

            string sql = "select * from Courses where CoursesName like '%'+@filter+'%'";
            string[] parameters = { "@filter" };
            string[] values = { CoursesName };
            SqlDataReader CoursesReader = DBconection.RunSqlAllResult(sql, parameters, values);
            List<string> courses = new List<string>();
            for (int i = 0; CoursesReader.Read(); i++)
            {
                courses.Add(CoursesReader.GetString(1));
            }
            CoursesReader.Close();
            return courses;
        }
        public static void addStudentCourse(string course)
        {
            string sql = "\r\nif not exists(\r\n    select 1\r\n    from Students\r\n    join Payments ON Students.StudentID = Payments.studentID\r\n    join Courses ON Payments.CoursesId = Courses.CoursesId\r\n    where CoursesName = @CoursesName AND Students.studentID = @student_id\r\n)\r\nbegin\r\n   \r\n    insert into Payments (PaymentsReceived, studentID, CoursesId)\r\n    values (\r\n        (select CoursePrice from Courses where CoursesName = @CoursesName), \r\n        @student_id, \r\n        (select CoursesId from Courses where CoursesName = @CoursesName)\r\n    );\r\n\r\n    \r\n    update Students\r\n    set balancePayment = balancePayment + \r\n        (select CoursePrice from Courses where CoursesName = @CoursesName)\r\n    where studentID = @student_id;\r\nend";
            string[] parameters = { "@CoursesName" };
            string[] values = { course };
            //int number = { CoursePrice };
            DBconection.RunSqlNoReturn(sql, parameters, values);
        }
        public static DataTable selectRows(string labCategorey)
        {
            string sql = "";
            string[] parameters = { "" };
            string[] values = { labCategorey };
            DataTable coursesAdapter = DBconection.RunSqlTableResult(sql, parameters, values);
            return coursesAdapter;



        }
    }
}
