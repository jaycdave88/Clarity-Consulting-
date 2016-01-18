using ClarityConference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClarityConference.Controllers
{
    public class HomeController : Controller
    {
        private ClarityConferenceDBConnection db = new ClarityConferenceDBConnection();
        public ActionResult Index()
        {
            var conferenceModel = db.Conferences.FirstOrDefault();
            var clientModels = db.Clients.ToList();
            var conferenceViewModel = new ConferenceViewModel();

            if(conferenceModel!=null)
            {
                conferenceViewModel.Id = conferenceModel.Id;
                conferenceViewModel.Name = conferenceModel.Name;
                conferenceViewModel.Description = conferenceModel.Description;
                conferenceViewModel.Street = conferenceModel.Street;
                conferenceViewModel.City = conferenceModel.City;
                conferenceViewModel.State = conferenceModel.State;
                conferenceViewModel.ZipCode = conferenceModel.ZipCode;

                conferenceViewModel.Clients = createClientViewModels(clientModels);
            }
            return View(conferenceViewModel);
        }

        private List<ClientViewModel> createClientViewModels(List<Client> clientModels)
        {
            
            var clientViewModels = new List<ClientViewModel>();
            foreach (var client in clientModels)
            {
                var attendeeModels = db.Attendees.Where(a=>a.ClientId == client.Id).ToList();
                var clientViewModel = new ClientViewModel();
                clientViewModel.Name = client.Name;
                clientViewModel.Phone = client.Phone;
                clientViewModel.Email = client.Email;
                clientViewModel.Street = client.Street;
                clientViewModel.City = client.City;
                clientViewModel.State = client.State;
                clientViewModel.ZipCode = client.ZipCode;
                clientViewModels.Add(clientViewModel);

                clientViewModel.Attendees = createAttendeeViewModels(attendeeModels);

            }
            return clientViewModels;
        }

        private List<AttendeeViewModel> createAttendeeViewModels(List<Attendee>attendeeModels)
        {
            var attendeeViewModels = new List<AttendeeViewModel>();
            foreach (var attendee in attendeeModels)
            {
                var attendeeViewModel = new AttendeeViewModel();
                attendeeViewModel.Name = attendee.Name;
                attendeeViewModel.Email = attendee.Email;
                attendeeViewModels.Add(attendeeViewModel);
            }
            return attendeeViewModels;
        }
    }
}