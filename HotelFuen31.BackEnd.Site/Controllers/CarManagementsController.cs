using HotelFuen31.BLL.Haku;
//using HotelFuen31.DAL.RepoAdo.Haku;
using HotelFuen31.DAL.RepoDapper.Haku;
//using HotelFuen31.DAL.RepoEF.Haku;
using HotelFuen31.IBLL.IServices.Haku;
using HotelFuen31.Infra.Utilities.Exts.Haku;
using HotelFuen31.PL.ViewModels.Haku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelFuen31.BackEnd.Site.Controllers
{
    public class CarManagementsController : Controller
    {
        private ICarManagementService _service;

        public CarManagementsController()
        {
            _service = new CarManagementService(new CarManagementDapperRepo("default"));
        }
        // GET: CarManagements
        public ActionResult Index()
        {
            var dto = _service.Get("ME-8848");
            var vm = dto.DtoToVm();

            var list = new List<CarManagementVm>();
            list.Add(vm);

            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CarManagementVm vm)
        {
            _service.Create(vm.VmToDto());

            return RedirectToAction("Index");
        }
    }
}