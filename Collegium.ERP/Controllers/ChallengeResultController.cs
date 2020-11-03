using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TP3.Core.Data.Account;
using TP3.Core.Data.Challenge;
using TP3.Core.Interfaces;
using TP3.Domain.Entities;
using TP3.ERP.Helper;

namespace TP3.ERP.Controllers
{
    public class ChallengeResultController : Controller
    {
        private readonly IUserService _userService;
        private readonly IChallengeService _challengeService;
        private readonly IEnumService _enumService;
        private List<NetElement> _netElementOption;

        public ChallengeResultController(IUserService userService,
                                         IChallengeService challengeService,
                                         IEnumService enumService)
        {
            _userService = userService;
            _challengeService = challengeService;
            _enumService = enumService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(ChallengeResultData data)
        {
            _netElementOption = new List<NetElement>
            {
                new NetElement { Name = "Adaptador Wi-Fi USB" },
                new NetElement { Name = "Placa de Red PCI" },
                new NetElement { Name = "Conector RJ45" },
                new NetElement { Name = "Conector RJ15" },
                new NetElement { Name = "Conector RJ11" },
                new NetElement { Name = "Extensor/Repetidor Wi-Fi" },
                new NetElement { Name = "Hub" },
                new NetElement { Name = "Router" },
                new NetElement { Name = "Switch" },
                new NetElement { Name = "Segmento de Cable 220V" },
                new NetElement { Name = "Segmento de Cable UTP Categoría 4" },
                new NetElement { Name = "Segmento de Cable UTP Categoría 5" },
                new NetElement { Name = "Segmento de Cable UTP Categoría 6" }
            };
            data.NetElementOption = _netElementOption;


            data.Cable = _enumService.GetAllCableSelectable();
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
                //Verificar si existe el código del challenge ingresado
                var challengeValid = _challengeService.ValidByCode(data.Code);
                if (!challengeValid.Result)
                {
                    TempData.Put("RESPONSE", challengeValid);
                    return View(data);
                }

                var challenge = _challengeService.GetByCode(data.Code);
                if (challenge == null)
                {
                    return View(data);
                }

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

                ChallengeResultData resultData = new ChallengeResultData
                {
                    Student = data.Name,
                    ChallengeCode = data.Code,
                    ChallengeDescription = challenge.Description,
                    ChallengeTitle = challenge.Title,
                    TimeLimit = DateTime.Now.AddMinutes(60), //debería pasarse el tiempo establecido para el challenge                   
                };
                return RedirectToAction("Create", "ChallengeResult", resultData);
            }
            return View(data);
        }
    }
}