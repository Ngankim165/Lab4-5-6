using BS.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BS.Controllers
{
    public class FollowingsController : Controller
    {
        [HttpPost]
      
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
          
            
                return BadRequest(" Following already exits!");
        }

        private ActionResult Ok()
        {
            throw new NotImplementedException();
        }

        private ActionResult BadRequest(string v)
        {
            throw new NotImplementedException();
        }
    }
}