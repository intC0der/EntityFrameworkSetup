using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace entityTest1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DataContext dataContext = new DataContext("yourconnectionstring");

            var users = dataContext.Users.ToList();

            var userPermissions = dataContext.UserPermissions.ToList();

            User user = new User()
            {
                LastName = "Bryan",
                FirstName = "Mac",
                Email = "bmac@GMAIL.COM",
                DateCreated = DateTime.Now,
                Age = 20,
            };

            dataContext.Users.Add(user);
            dataContext.SaveChanges();

            UserPermission userPermission = new UserPermission()
            {
                Name = "Admin",
                UserId = 1,
            };

            dataContext.UserPermissions.Add(userPermission);
            dataContext.SaveChanges();


            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
