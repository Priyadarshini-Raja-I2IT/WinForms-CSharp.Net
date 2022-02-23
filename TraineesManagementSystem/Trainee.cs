using System;

namespace Trainees_Management_System
{
    internal class Trainee
    {
        public Trainee()
        {
        }

        public Trainee(string name, long mobileNumber, string address, DateTime dateOfBirth, string qualification)
        {
            Name = name;
            MobileNumber = mobileNumber;
            Address = address;
            DateOfBirth = dateOfBirth;
            Qualification = qualification;
        }

        public string Name { get; set; }

        public long MobileNumber { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Qualification { get; set; }
    }
}
