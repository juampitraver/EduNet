using Microsoft.AspNetCore.Mvc;
using TP3.Core.Data.ChallengeCreation;
using TP3.Core.Data.Datatable;
using TP3.Core.Interfaces;
using TP3.ERP.Controllers.Authorization;

namespace TP3.ERP.Controllers
{
    public class ChallengeCreationController : AuthorizationController
    {
        private readonly IChallengeCreationService _challengeCreationService;

        public ChallengeCreationController(IAuthorizationService authorizationService,
                                           IChallengeCreationService challengeCreationService) : base(authorizationService)
        {
            _challengeCreationService = challengeCreationService;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public JsonResult Index([FromBody] DTParameters param)
        {
            GridData<ChallengeCreationGridData> data = _challengeCreationService.GetAll(param, User.Identity.Name);
            return new JsonResult(new { draw = param.Draw++, recordsTotal = data.Count, recordsFiltered = data.Count, data = data.List });
        }

        //public IActionResult Create()
        //{
        //    LoadReferences();
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(ClientData data)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        TempData.Put("RESPONSE", _clientService.Create(data));
        //        return RedirectToAction("Index");
        //    }
        //    LoadReferences();
        //    return View(data);
        //}

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

        //[HttpPost]
        //public JsonResult Delete(long id)//clientId
        //{
        //    return new JsonResult(new { response = _clientService.Delete(id) });
        //}
    }
}
