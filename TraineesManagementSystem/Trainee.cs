using System;

namespace Trainees_Management_System
{
    internal class Trainee
    {
        public Trainee()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }

        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Qualification { get; set; }
    }
}