using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace CourseApp.API.Security
{
    public class BasicHandler : AuthenticationHandler<BasicOption>
    {
        public BasicHandler(IOptionsMonitor<BasicOption> optionsMonitor, ILoggerFactory logger, UrlEncoder encoder, ISystemClock systemClock): base(optionsMonitor, logger, encoder, systemClock)
        {
            
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return Task.FromResult(AuthenticateResult.NoResult());
            }

            if (!AuthenticationHeaderValue.TryParse(Request.Headers["Authorization"], out AuthenticationHeaderValue headerValue))
            {
                return Task.FromResult(AuthenticateResult.NoResult());
            }

            if (headerValue.Scheme != "Basic")
            {
                return Task.FromResult(AuthenticateResult.NoResult());
            }

            var base64Bytes = Convert.FromBase64String(headerValue.Parameter);
            var decoded = Encoding.UTF8.GetString(base64Bytes);
            string username = decoded.Split(":")[0];
            string pass = decoded.Split(":")[1];

            if (username != "turko" && pass !="123")
            {
                return Task.FromResult(AuthenticateResult.Fail("Kullanıcı adı veya şifre yanlış"));
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username)
            };

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);

            AuthenticationTicket ticket = new AuthenticationTicket(principal, Scheme.Name);
            return Task.FromResult(AuthenticateResult.Success(ticket));
        }
    }
}
