﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClarityConference.Models
{
    public class AttendeeViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set;}
    }
}