using System;

namespace Test_1.Models
{
    public class Student
    {
        public string RollNumber { get; set; }
        public string Fullname { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public StudentStatus Status { get; set; }
        public int MyStatus { get; set; }

        public override string ToString()
        {
            return
                $"RollNumber {RollNumber}, Fullname {Fullname}, Birthday {Birthday}, Email {Email}, Phone{Phone}, Create At{CreatedAt}";
        }
    }
}