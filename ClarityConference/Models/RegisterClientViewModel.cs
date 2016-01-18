using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClarityConference.Models
{
    public class RegisterClientViewModel
    {
        [Required(ErrorMessage = "Client name is required")]
        [StringLength(150)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(150)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(150)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Street name is required")]
        [StringLength(150)]
        public string Street { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(150)]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(150)]
        public string State { get; set; }

        [Required(ErrorMessage = "Zipcode is required")]
        [StringLength(150)]
        public string ZipCode { get; set; }
    }
}