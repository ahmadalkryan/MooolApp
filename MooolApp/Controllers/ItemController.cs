using Microsoft.AspNetCore.Mvc;
using MooolApp.Models;
using MooolApp.Models.Repo;

namespace MooolApp.Controllers
{
    public class ItemController : Controller
    {
        private readonly ItemRepo _repo;

        public ItemController(ItemRepo repo)
        {
             _repo = repo;
        }

        [HttpGet]

        public async Task<IActionResult> GEtAllItem()
        {
            var result =  _repo.GETAll();

            return View(result);
           
        }


        [HttpPost]

        public async Task<IActionResult> CreateItem(Item item)
        {
           _repo.insertItem(item);
            return View(item);
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateItem(Item item)
        {
                
           _repo.updateItem(item);

            return Ok();
           

        }
        public async Task<IActionResult> DeleteItem(string id)
        {
            _repo.DeleteItem(id);
            return Ok();
        }


















    }
}
