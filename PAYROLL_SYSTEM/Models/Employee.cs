using System;
using System.ComponentModel.DataAnnotations;

namespace PayrollApi.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string EmployeeNumber { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public decimal DailyRate { get; set; }

        [Required]
        public string WorkingDays { get; set; }
    }
}
