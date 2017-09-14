using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Moq;
using System.Linq;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Abstract;

namespace WUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel=new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController) ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            Mock<IEventRepository> mock=new Mock<IEventRepository>();
            mock.Setup(m => m.Events).Returns(new List<Event>
            {
                new Event {Name = "Soccer game", Description = "Zenit-Spartak"},
                new Event {Name = "Day of cinema", Description = "Cinema festival"},
                new Event {Name = "Race", Description = "Participants: Ferrary, Lambordginy, Mercedes"}
            }.AsQueryable());

            ninjectKernel.Bind<IEventRepository>().ToConstant(mock.Object);
        }
    }
}