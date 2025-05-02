using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace HRSolutions.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Initials { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Race { get; set; }
        public string BloodGroup { get; set; }

        public string NICNumber { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? PassportExpiryDate { get; set; }

        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string ZIPCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string MobileNumber { get; set; }
        public string LandLine { get; set; }
        public string PersonalEmail { get; set; }
    }
}
