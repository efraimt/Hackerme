using Hackerme.Infrastucture.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDB
{
    public class StudendsTable
    {
        public static List<Student> List { get; set; }=new List<Student>();

        public static void Add(Student student)
        {
            List.Add(student);
        }
    }
}
