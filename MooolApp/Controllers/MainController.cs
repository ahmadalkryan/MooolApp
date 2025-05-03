using Microsoft.AspNetCore.Mvc;
using MooolApp.Models;

namespace MooolApp.Controllers
{
    public class MainController : Controller
    {
        private readonly DbMool _db;

        public MainController(DbMool db)
        {
             _db = db;
        }

        [HttpGet]

        public async Task<IActionResult> GEtAllItem()
        {
            var result = await _db.Items.FindAsync();
            if (result != null)
            {

                return View(result);

            }

            return BadRequest();
        }


        [HttpPost]

        public async Task<IActionResult> CreateItem(Item item)
        {
            var it = await _db.Items.AddAsync(item);
            _db.SaveChangesAsync();

            return View(it);

        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateItem(Item item)
        {
                
           
                await _db.Items.Update(item);

                 
           


        }


















    }
}
