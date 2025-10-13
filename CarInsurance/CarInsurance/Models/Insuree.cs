using System;
using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insuree
    {
        // Unique ID
        public int Id { get; set; }

        // First name
        [Required] // Ensures this field is not null
        public string FirstName { get; set; }

        // Last name
        [Required]
        public string LastName { get; set; }

        // Email
        [Required] 
        [EmailAddress] // Ensures the email format is valid
        public string EmailAddress { get; set; }

        // Date of birth
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        // Car year
        [Required]
        public int CarYear { get; set; }

        // Car make (brand)
        [Required]
        public string CarMake { get; set; }

        // Car model
        [Required]
        public string CarModel { get; set; }

        // Has DUI (yes/no)
        [Required]
        public bool DUI { get; set; }

        // Number of speeding tickets
        [Required]
        public int SpeedingTickets { get; set; }

        // Coverage type (true = full, false = liability)
        [Required]
        public bool CoverageType { get; set; }

        // Insurance quote amount
        [Required]
        [DataType(DataType.Currency)] // Ensures the value is treated as currency
        public decimal Quote { get; set; }
    }
}
