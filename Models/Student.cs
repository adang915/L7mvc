using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
 
//tinfo200:[2021-03-10-adang915-dykstra1] – Adding five different auto properties into the Student class

    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}