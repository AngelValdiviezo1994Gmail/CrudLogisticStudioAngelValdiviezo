using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Module.Security.Infrastructure.Interfaces.Client;
using Common.Domain.Wrappers;
using Module.Security.Infrastructure.Client;
using System.Net;
using Common.Domain.Interfaces;
using Common.Domain.Entities;
using Common.Infrastructure.Helpers;
using Module.Security.Domain.CQRS.Query;
using System.Web.WebPages;
using Newtonsoft.Json;
using WebAPP.ViewModel;
using Module.Security.Domain.Entities;
using NuGet.Protocol;

namespace WebAPP.Filters
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class AuthorizeUserFilter : ActionFilterAttribute
    {
        private  string _keyOpMenu;


        public AuthorizeUserFilter(string keyOpMenu)
        {
            _keyOpMenu = keyOpMenu;
        }

        public override async void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            bool continuar = false;
            var sesionHelper = context.HttpContext.RequestServices.GetService<ISesionHelper>();
            var isRolUserSuperAdmin = sesionHelper?.IsRolUserSuperAdmin() ?? false;
            var strPermisosRolesUsr = sesionHelper?.GetPermisosRolesUsuario() ?? string.Empty;
            if (!strPermisosRolesUsr.IsEmpty())
            {
                var objLstPermisosRoles = JsonConvert.DeserializeObject<List<RolesOperacionesOpcion>>(strPermisosRolesUsr);
                var permisoOtorgado = objLstPermisosRoles.Any(x => x.Opcion.Llave == _keyOpMenu);
                if (permisoOtorgado || isRolUserSuperAdmin)
                    continuar = true;
            }

            if (!continuar)
            {
                context.Result = new RedirectToRouteResult(
                  new RouteValueDictionary()
                  {
                      { "controller", "Home" },
                      { "action", "Privacy" }
                  });
                return;
            }
        }

    }
}
