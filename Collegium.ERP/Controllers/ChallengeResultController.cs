using Microsoft.AspNetCore.Mvc;
using System;
using TP3.Core.Data.Account;
using TP3.Core.Data.Challenge;
using TP3.Core.Data.Datatable;
using TP3.Core.Data.User;
using TP3.Core.Interfaces;
using TP3.Domain.Entities;
using TP3.ERP.Helper;

namespace TP3.ERP.Controllers
{
    public class ChallengeResultController : Controller
    {
        private readonly IUserService _userService;

        public ChallengeResultController(IUserService userService)
        {
            _userService = userService;
        }       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(ResultData data)
        {
            return View(data);
        }

        public IActionResult Start()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Start(StartData data)
        {
            if (ModelState.IsValid)
            {
                //Verificar si el usuario no existe crearlo
                var response = _userService.GetByUserName(data.Email);
                if (response == null)
                {
                    LoginData user = new LoginData
                    {
                        Name = data.Name,
                        Email = data.Email,
                        Password = data.Email,
                        RepeatPassword = data.Email,
                        Role = (byte)eRole.Student
                    };
                    _userService.Create(user);                    
                }

                //Registrar la relacion entre el usuario y el challenge

                ResultData resultData = new ResultData
                {
                    Name = data.Name,
                    Code = data.Code,
                    TimeLimit = DateTime.Now.AddMinutes(60) //debería pasarse el tiempo establecido para el challenge
                };
                return RedirectToAction("Create", "ChallengeResult", resultData);
            }
            return View(data);
        }
    }
}