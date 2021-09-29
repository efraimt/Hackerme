using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerme.Infrastucture.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly DOB { get; set; }
        public int CityId { get; set; }

        //public List<Course> Courses { get; set; }

        //public DateTime Created { get; set; }
        //public DateTime Updated { get; set; }
        //public int UserCureatedId { get; set; }
        //public int UserUpdatedId { get; set; }



    }
}
