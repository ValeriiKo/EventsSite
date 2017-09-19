using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.Entities;

namespace WUI.Controllers
{
    public class EventController : Controller
    {
        private IEventRepository repository;

        public EventController(IEventRepository eventRepository)
        {
            this.repository = eventRepository;
        }

        //private Event myEvent = new Event {Name = "ASP", Description = "^-)"};
        //Event [] arrayEvent=
        //{
        //    new Event {Name = "Soccer game", Description = "Zenit-Spartak"},
        //    new Event {Name = "Day of cinema", Description = "Cinema festival"},
        //    new Event {Name = "Race", Description = "Participants: Ferrary, Lambordginy, Mercedes"}
        //};
        public ViewResult List()
        {
            
            return View(repository.Events);
        }
    }
}