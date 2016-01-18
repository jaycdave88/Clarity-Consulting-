﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClarityConference.Models
{
    public class ClientViewModel
    {
        public List<AttendeeViewModel> Attendees { get; set; } 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}