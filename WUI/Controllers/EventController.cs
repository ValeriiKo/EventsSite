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

        public ViewResult List()
        {
            return View(repository.Events);
        }
    }
}