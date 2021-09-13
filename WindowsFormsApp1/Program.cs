using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DOB { get; set; }
        public int CityId { get; set; }

        List<Course> Courses {  get; set; }

        //public DateTime Created { get; set; }
        //public DateTime Updated { get; set; }
        //public int UserCureatedId { get; set; }
        //public int UserUpdatedId { get; set; }



    }

    public class Course
    {
        public string Name { get; set; }
    }
}
