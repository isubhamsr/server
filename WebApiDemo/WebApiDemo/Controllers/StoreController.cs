using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private List<GroceryStor> _groceryStore = new List<GroceryStor>();

        public StoreController()
        {
            _groceryStore.Add(new GroceryStor() { Id = 1, Name = "Spencer", Address = "Kalyani" });
            _groceryStore.Add(new GroceryStor() { Id = 2, Name = "More", Address = "Asansol" });
            _groceryStore.Add(new GroceryStor() { Id = 3, Name = "Big Bazar", Address = "Kolkata" });
        }

        // GET: api/<StoreController>
        [HttpGet]
        public IEnumerable<GroceryStor> Get()
        {
            return _groceryStore;
        }

        // GET api/<StoreController>/5
        [HttpGet("{id}")]
        public ActionResult<GroceryStor> Get(int id)
        {
            var grocory = _groceryStore.SingleOrDefault(p => p.Id == id);
            if(grocory == null)
            {
                return NotFound();
            }
            return grocory;
        }

        // POST api/<StoreController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StoreController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StoreController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
