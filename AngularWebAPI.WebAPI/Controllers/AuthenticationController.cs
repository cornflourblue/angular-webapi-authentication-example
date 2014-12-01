using AngularWebAPI.WebAPI.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularWebAPI.WebAPI.Controllers
{
    public class AuthenticationController : ApiController
    {
        [Route("authenticate")]
        public IHttpActionResult Authenticate(AuthenticateViewModel viewModel)
        {
            /* REPLACE THIS WITH REAL AUTHENTICATION
            ----------------------------------------------*/
            if (!(viewModel.Username == "test" && viewModel.Password == "test"))
            {
                return Ok(new { success = false, message = "User code or password is incorrect" });
            }

            return Ok(new { success = true });
        }
    }
}
