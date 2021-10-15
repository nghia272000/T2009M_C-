using System;
using Test_1.Models;

namespace Test_1
{
    public enum StudentStatus
    {
        Active =1,
        Deactive =0,
        Deleted = -1,
            
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var st = new Student
            {
                RollNumber = "A001",
                Birthday = DateTime.Parse("2000-07-02"),
                Email = "blabla@gmail.com",
                Phone = "0123456789",
                CreatedAt = DateTime.Now,
                Fullname = "Nghia Le",
                Status = StudentStatus.Active,
            };
            Console.WriteLine((int)st.Status);    
        }
    }
}