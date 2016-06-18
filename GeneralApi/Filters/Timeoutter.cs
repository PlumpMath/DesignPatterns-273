using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralApi.Filters
{
    public class Timeoutter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            System.Web.HttpContext.Current.GetType().GetField("_timeoutState",
                System.Reflection.BindingFlags.Instance | 
                System.Reflection.BindingFlags.NonPublic).SetValue(System.Web.HttpContext.Current, 1);
            base.OnActionExecuting(filterContext);
        }
    }
}