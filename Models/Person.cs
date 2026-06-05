using System;

namespace StudentManagement.Models
{
    public abstract class Person
    {
        
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}