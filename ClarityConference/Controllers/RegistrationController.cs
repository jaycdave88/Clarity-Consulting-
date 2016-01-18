using ClarityConference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClarityConference.Controllers
{
    public class RegistrationController : Controller
    {
        private ClarityConferenceDBConnection db = new ClarityConferenceDBConnection();
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        // GET: Registration/RegisterClient
        public ActionResult RegisterClient()
        {
            var registerClientViewModel = new RegisterClientViewModel();

            return View(registerClientViewModel);
        }

        [HttpPost]
        public ActionResult RegisterClient(RegisterClientViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var client = new Client();
                client.Name = viewModel.Name;
                client.Phone = viewModel.Phone;
                client.Email = viewModel.Email;
                client.Street = viewModel.Street;
                client.City = viewModel.City;
                client.State = viewModel.State;
                client.ZipCode = viewModel.ZipCode;

                db.Clients.Add(client);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(viewModel);
        }

        // GET: Registration/RegisterAttendee
        public ActionResult RegisterAttendee()
        {
            var registerAttendeesViewModel = new RegisterAttendeeViewModel();

            PopulateClients(registerAttendeesViewModel);
            return View(registerAttendeesViewModel);
        }

        [HttpPost]
        public ActionResult RegisterAttendee(RegisterAttendeeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var attendee = new Attendee();
                attendee.ClientId = Int32.Parse(viewModel.SelectedClient);
                attendee.Name = viewModel.Name;
                attendee.Email = viewModel.Email;

                db.Attendees.Add(attendee);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            PopulateClients(viewModel);
            return View(viewModel);
        }


        private void PopulateClients(RegisterAttendeeViewModel registerAttendeesViewModel)
        {
            var clientList = db.Clients.ToList();

            registerAttendeesViewModel.Clients = clientList.Select(c => new SelectListItem() { Text = c.Name, Value = c.Id.ToString() });
        }

    }
}
