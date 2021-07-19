using BS.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace BS.Controllers
{
    public class AttendancesController : Controller
    {
        private ApplicationDbContext _dbContext;
        private readonly Models.Attendance attendances;

        public object Model { get; private set; }

        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend([FromBody] int courseId)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.courseId))
                return BadRequest("The Attendance already exists!");
            
                var attendance = new Attendance
                {
                   CourseId = courseId,
                    AttendeeId = userId
                };
                _dbContext.Attendances.Add(attendances);
                _dbContext.SaveChanges();
                return Ok();
            
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            return BadRequest("The Attendance already exists!");
        }

        private IHttpActionResult BadRequest(string v)
        {
            throw new NotImplementedException();
        }


        // GET: Attendance
        public ActionResult Index()
        {
            return View();
        }
    

       

        private IHttpActionResult Ok()
        {
            throw new NotImplementedException();
        }
    }
}