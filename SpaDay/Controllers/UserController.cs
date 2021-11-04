using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            if (ViewBag.passwordVerified == null)
            {
                ViewBag.passwordVerified = true;
            }
            return View();
        }

        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.Username = newUser.Username;
            ViewBag.Email = newUser.Email;

            if (newUser.VerifyPassword(verify))
            {
                ViewBag.passwordVerified = true;
                ViewBag.TimeCreated = newUser.TimeCreated;
                return View("Index");
            }

            ViewBag.passwordVerified = false;
            return View("Add");


        }
    }
}

