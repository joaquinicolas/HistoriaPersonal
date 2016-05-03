using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using System.Web.Routing;

using HistoriaPersonalCormillot;

namespace HistoriaPersonalCormillot.Common
{
    public class ActionFilterUsuarioLogeado : ActionFilterAttribute
    {
        private CormillotHistoriaPersonalCustomEntities model = new CormillotHistoriaPersonalCustomEntities();

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(excluyeActionFilter(filterContext) || esPedidoAjax(filterContext))
                return;

            bool estaLogeado =  filterContext.HttpContext.Session["IdUsuario"] != null && 
                                (int)filterContext.HttpContext.Session["IdUsuario"] > 0;

            if (!estaLogeado)
            {
                filterContext.Result =
                    new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Usuarios", action = "Login" }));
                filterContext.Result.ExecuteResult(filterContext.Controller.ControllerContext);
                return;
            }

            filterContext.Controller.ViewBag.NombreUsuario = filterContext.HttpContext.Session["NombreUsuario"].ToString();

            base.OnActionExecuting(filterContext);
        }

        private bool esPedidoAjax(ActionExecutingContext filterContext)
        {
            return filterContext.RequestContext.HttpContext.Request.IsAjaxRequest();
        }

        private bool excluyeActionFilter(ActionExecutingContext filterContext)
        {
            return false;
            //return filterContext.ActionDescriptor.GetCustomAttributes(typeof(SkipMyGlobalActionFilterAttribute), false).Any();
        }
    }
}