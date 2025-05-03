using Microsoft.AspNetCore.Mvc;
using MooolApp.Models;
using MooolApp.Models.Repo;

namespace MooolApp.Controllers
{
    public class MoolController : Controller
    {

        private readonly IMoolRepo _repo ;

        public MoolController(IMoolRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _repo.GetAll();


            return View();
        }

        [HttpGet]

        public IActionResult CreatMool()
        {
            return View(); 
        }


        [HttpPost]

        public IActionResult CreatMool(Mool m)
        { 
            _repo.InsertMoll(m);

            return View();
        }
        [HttpGet]
        public IActionResult updateMool()
        {
            return View();
        }

        [HttpPost]
        public IActionResult updateMool(Mool m)
        {
            _repo.updateMool(m);
            return View();
        }


        public IActionResult DeleteMool(string id)
        {
            _repo.deleteMool(id);
            return View();

        }

        [HttpGet]

        public IActionResult GetMool(string id)
        {
            var result = _repo.GetMool(id);
            return View(result);
        }













    }
}
