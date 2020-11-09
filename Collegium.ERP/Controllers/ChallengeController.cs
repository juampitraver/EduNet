using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TP3.Core.Data.Challenge;
using TP3.Core.Data.Datatable;
using TP3.Core.Interfaces;
using TP3.ERP.Controllers.Authorization;
using TP3.ERP.Helper;
using IAuthorizationService = TP3.Core.Interfaces.IAuthorizationService;

namespace TP3.ERP.Controllers
{
    public class ChallengeController : AuthorizationController
    {

        private readonly IChallengeService _challengeService;
        private readonly IEnumService _enumService;

        public ChallengeController(IAuthorizationService authorizationService,
                                           IChallengeService challengeService,
                                           IEnumService enumService) : base(authorizationService)
        {
            _challengeService = challengeService;
            _enumService = enumService;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public JsonResult Index([FromBody] DTParameters param)
        {
            GridData<ChallengeGridData> data = _challengeService.GetAll(param, User.Identity.Name);
            return new JsonResult(new { draw = param.Draw++, recordsTotal = data.Count, recordsFiltered = data.Count, data = data.List });
        }

        public IActionResult Create()
        {
            LoadReferences();
            return View();
        }

        [HttpPost]
        public IActionResult Create(ChallengeData data)
        {
            if (ModelState.IsValid)
            {
                TempData.Put("RESPONSE", _challengeService.Create(data, User.Identity.Name));
                return RedirectToAction("Index");
            }
            LoadReferences();
            return View(data);
        }

        //public IActionResult Edit(long id)//clientId
        //{
        //    var data = _clientService.GetById(id);
        //    LoadReferences();
        //    if (data.ProvinceId.HasValue && data.ProvinceId.Value != 0)
        //    {
        //        ViewBag.Locations = _locationService.GetByProvinceId(data.ProvinceId.Value);
        //    }
        //    else
        //    {
        //        ViewBag.Locations = new List<SelectableData>();
        //    }
        //    return View(data);
        //}



        //[HttpPost]
        //public IActionResult Edit(ClientData data)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        TempData.Put("RESPONSE", _clientService.Update(data));
        //        return RedirectToAction("Index");
        //    }
        //    LoadReferences();
        //    return View(data);
        //}



        [AllowAnonymous]
        [HttpPost]
        public IActionResult AddElement(ChallengeData data)
        {
            ModelState.Clear();
            if (data.ElementId.HasValue && data.ElementId.Value > 0 && data.Quantity.HasValue && data.Quantity > 0)
            {
                _challengeService.AddElement(data);
            }
            return PartialView("_Element", data);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult UpdateElement(ChallengeData data)
        {
            ModelState.Clear();
            data.Elements = data.Elements.FindAll(f => f.IsSelect);
            return PartialView("_Element", data);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult AddCable(ChallengeData data)
        {
            ModelState.Clear();
            if (data.CableId.HasValue && data.CableId.Value > 0 && data.Order.HasValue && data.Order > 0)
            {
                _challengeService.AddCable(data);
            }
            return PartialView("_Cable", data);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult UpdateCable(ChallengeData data)
        {
            ModelState.Clear();
            data.Cables = data.Cables.FindAll(f => f.IsSelect);
            return PartialView("_Cable", data);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult AddCommand(ChallengeData data)
        {
            ModelState.Clear();
            if (data.CommandId.HasValue && data.CommandId.Value > 0)
            {
                _challengeService.AddCommand(data);
            }
            return PartialView("_Command", data);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult UpdateCommand(ChallengeData data)
        {
            ModelState.Clear();
            data.Commands = data.Commands.FindAll(f => f.IsSelect);
            return PartialView("_Command", data);
        }

        public void LoadReferences()
        {
            ViewBag.NetTypes = _enumService.GetNetTypes();
            ViewBag.ConnectionTypes = _enumService.GetConnectionTypes();
            ViewBag.Elements = _enumService.GetElements();
            ViewBag.Cables = _enumService.GetCables();
            ViewBag.Commands = _enumService.GetCommands();
        }

        //[HttpPost]
        //public JsonResult Delete(long id)//clientId
        //{
        //    return new JsonResult(new { response = _clientService.Delete(id) });
        //}
    }
}