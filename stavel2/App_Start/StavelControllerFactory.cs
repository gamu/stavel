using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using stavel2.Controllers;

namespace stavel2.App_Start
{
    public class StavelControllerFactory:IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            var currentAssembly = this.GetType().Assembly;
            var controller = currentAssembly.GetTypes().FirstOrDefault(n => n.Name == controllerName + "Controller");
            if (controller == null)
            {
                requestContext.RouteData.Values.Add("id", controllerName);
                requestContext.RouteData.Values["controller"] = "Home";
                requestContext.RouteData.Values["action"] = "GetArticle";
                return new HomeController();
            }
            return (Controller)Activator.CreateInstance(controller);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposeedController = controller as IDisposable;
            if (disposeedController != null)
                disposeedController.Dispose();
        }
    }
}