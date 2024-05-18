using Common.Domain.Entities;
using Common.Domain.Interfaces;
using Common.Domain.Wrappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Module.Security.Domain.Entities;
using Module.Security.Infraestructure.Interfaces.Client;
using Newtonsoft.Json;
using NuGet.Protocol;
using System.Web.WebPages;

namespace WebAPP.Filters
{
    public class AuthorizationFilter : ActionFilterAttribute
    {
        private readonly string _modulo;
        private readonly string _metodo;

        public AuthorizationFilter()
        {
            _modulo = string.Empty;
            _metodo = string.Empty;
        }

        public AuthorizationFilter(string modulo)
        {
            _modulo = modulo;
            _metodo = string.Empty;
        }

        public AuthorizationFilter(string modulo, string metodo)
        {
            _modulo = modulo;
            _metodo = metodo;
        }

        public override async void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var userPrincipal = context.HttpContext.User;
            string sessionId = (from c in userPrincipal.Claims where c.Type == "SessionId" select c.Value).FirstOrDefault();
            bool continuar = false;
            if (Guid.TryParse(sessionId, out Guid _sessionId))
            {
                var sessionClient = context.HttpContext.RequestServices.GetService<ISessionClient>();
                Response<DatosSession> datosSession = await sessionClient.GetSession(new Request<Guid>(_sessionId));
                if (datosSession != null)
                {
                    if (datosSession.Data.FechaExpiracion > DateTime.UtcNow)
                    {
                        var sesionHelper = context.HttpContext.RequestServices.GetService<ISesionHelper>();
                        var objdata = datosSession.Data;
                        
                        sesionHelper.SetDatos(objdata);
                        continuar = true;
                    }
                }
            }

            if (!continuar)
            {
                var sesionHelper = context.HttpContext.RequestServices.GetService<ISesionHelper>();
                sesionHelper.SetDatos(null);
                context.Result = new RedirectToRouteResult(
                  new RouteValueDictionary()
                  {
                      { "controller", "Autenticacion" },
                      { "action", "Login" }
                  });
                return;
            }
        }

    }
}
