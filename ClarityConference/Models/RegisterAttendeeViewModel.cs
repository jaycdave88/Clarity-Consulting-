using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClarityConference.Models
{
    public class RegisterAttendeeViewModel
    {
        public IEnumerable<SelectListItem> Clients { get; set; }

        [Required(ErrorMessage = "Your name is required")]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Clients")]
        public string SelectedClient { get; set; }
    }
}