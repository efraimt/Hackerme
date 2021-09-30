using Hackerme.Infrastucture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDB
{

    public delegate bool StudentsFilterDelegate(Student student);

    public class StudendsTable
    {
        public static ILogger Logger { get; set; }

        public static LogDelegate Log { get; set; }

        public static List<Student> List { get; set; } = new List<Student>();

        public static void Add(Student student)
        {
            List.Add(student);
            //Logger.Log("Added " + student.FirstName);
            Log("Added " + student.FirstName);
        }

        /// <summary>
        /// Delete student from college
        /// </summary>
        /// <param name="student"></param>
        public static void Remove(Student student, LogDelegate logParam)
        {
            List.Remove(student);
            //Logger.Log("Added " + student.FirstName);
            logParam("Remove " + student.FirstName);
        }


        public static List<Student> Filter(StudentsFilterDelegate filterDelegate)
        {
            var list = new List<Student>();
            foreach (var student in List)
            {
                if(filterDelegate(student))
                    list.Add(student);
            }
            return list;
        }

    }
}
