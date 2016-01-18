using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClarityConference.Models
{
    public class ConferenceViewModel
    {
        public List<ClientViewModel> Clients { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}