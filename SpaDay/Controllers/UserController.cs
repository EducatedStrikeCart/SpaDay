using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel addEVentViewModel = new AddUserViewModel();
            return View(addEVentViewModel);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid && addUserViewModel.Password == addUserViewModel.VerifyPassword)
            {
                    User newUser = new User(addUserViewModel.Username, addUserViewModel.Email, addUserViewModel.Password);
                    return View("Index", addUserViewModel);

            }

            if (addUserViewModel.Password != addUserViewModel.VerifyPassword)
            {
                ViewBag.error = "Passwords don't match";
            }
          
            return View("Add", addUserViewModel);

            //if (newUser.Password == verify)
            //{
            //    ViewBag.user = newUser;
            //    return View("Index");
            //}
            //else
            //{
            //    ViewBag.error = "Passwords do not match! Try again!";
            //    ViewBag.userName = newUser.Username;
            //    ViewBag.eMail = newUser.Email;
            //    return View("Add");
            //}
        }

    }
}
