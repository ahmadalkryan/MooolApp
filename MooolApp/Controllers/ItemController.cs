using Microsoft.AspNetCore.Mvc;
using MooolApp.Models;
using MooolApp.Models.Repo;

namespace MooolApp.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepo _repo;

        public ItemController(IItemRepo repo)
        {
             _repo = repo;
        }

        [HttpGet]   
        public IActionResult GEtAllItem()
        {
            var result =  _repo.GETAll();

            return View(result);
           
        }

        [HttpGet]
        public  IActionResult CreateItem()
        {
            return View();
        }


        [HttpPost]

        public ActionResult CreateItem(Item item)
        {
           _repo.insertItem(item);
            return View(item);
        }

        [HttpGet]
        public IActionResult UpdateItem()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult UpdateItem(Item item)
        {
                
           _repo.updateItem(item);

            return View();
           

        }

        public ActionResult DeleteItem(string id)
        {
            _repo.DeleteItem(id);
            return View();
        }
        [HttpGet]
        public ActionResult GetItem(string id)
        {

            var result = _repo.GetItem(id);
            return View(result);
        }
        
















    }
}
