namespace StudentApp
{
    // Represents a student
    public class Student
    {
        public int Id { get; set; }           // Primary key
        public string FirstName { get; set; } // Student first name
        public string LastName { get; set; }  // Student last name
        public int Age { get; set; }          // Student age
    }
}