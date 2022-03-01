using System;
using System.ComponentModel.DataAnnotations;

namespace Trainees_Management_System
{
    internal class Trainee
    {
        public Trainee()
        {
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public long MobileNumber { get; set; }

        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Qualification { get; set; }
    }
}
