using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PDS_WebApp.Models
{
    public class PersonalDataSheet
    {
        public int Id { get; set; }

        // Personal Information
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string? MiddleName { get; set; }

        [Display(Name = "Name Extension (Jr., Sr., III)")]
        public string? NameExtension { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Place of Birth")]
        public string PlaceOfBirth { get; set; }

        [Required]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Required]
        [Display(Name = "Civil Status")]
        public string CivilStatus { get; set; }

        [Display(Name = "Height (m)")]
        public decimal? Height { get; set; }

        [Display(Name = "Weight (kg)")]
        public decimal? Weight { get; set; }

        [Display(Name = "Blood Type")]
        public string? BloodType { get; set; }

        [Display(Name = "GSIS ID No.")]
        public string? GSISIdNo { get; set; }

        [Display(Name = "PAG-IBIG ID No.")]
        public string? PagIbigIdNo { get; set; }

        [Display(Name = "PhilHealth No.")]
        public string? PhilHealthNo { get; set; }

        [Display(Name = "SSS No.")]
        public string? SSSNo { get; set; }

        [Display(Name = "TIN No.")]
        public string? TINNo { get; set; }

        [Display(Name = "Agency Employee No.")]
        public string? AgencyEmployeeNo { get; set; }

        // Contact Information
        [Required]
        [Display(Name = "Residential Address")]
        public string ResidentialAddress { get; set; }

        [Display(Name = "Residential Zip Code")]
        public string? ResidentialZipCode { get; set; }

        [Display(Name = "Permanent Address")]
        public string? PermanentAddress { get; set; }

        [Display(Name = "Permanent Zip Code")]
        public string? PermanentZipCode { get; set; }

        [Required]
        [Display(Name = "Mobile Number")]
        [Phone]
        public string MobileNumber { get; set; }

        [Display(Name = "Telephone No.")]
        public string? TelephoneNo { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        // Citizenship
        [Display(Name = "Citizenship")]
        public string? Citizenship { get; set; }

        [Display(Name = "Dual Citizenship")]
        public bool IsDualCitizen { get; set; } = false;

        [Display(Name = "Dual Citizenship Type")]
        public string? DualCitizenshipType { get; set; }

        [Display(Name = "Country")]
        public string? Country { get; set; }

        // Helper: Full Name
        public string FullName => $"{LastName}, {FirstName} {MiddleName} {NameExtension}".Trim();
    }
}
