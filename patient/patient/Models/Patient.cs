using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatientInformationSystem.Models
{
    public class Patient
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Blood Group is required")]
        public string BloodGroup { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Ph No should be of 10 digits")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Doctor Referred is required")]
        public string DoctorReferred { get; set; }

        [Required(ErrorMessage = "Height is required")]
        [Range(1.0, 6.0, ErrorMessage = "Height must be between 1 and 6 feet")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "BMI is required")]
        [Range(18.0, 25.0, ErrorMessage = "BMI must be between 18 and 25")]
        public decimal BMI { get; set; }

        [Required(ErrorMessage = "Marital Status is required")]
        public string MaritalStatus { get; set; }

        [Required(ErrorMessage = "Allergies are required")]
        public string Allergies { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
