namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-10-adang915-dykstra1] – Adding six different auto properties in the Enrollment 
    //                                          class and an enum for the alphabetical grades.

    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}