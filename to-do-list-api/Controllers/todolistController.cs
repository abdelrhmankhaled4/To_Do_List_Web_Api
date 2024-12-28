using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using to_do_list_api.repo;

namespace to_do_list_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class todolistController : ControllerBase
    {
        private readonly todolist_rebo context;
        public todolistController(todolist_rebo _context)
        {
            context = _context;
        }
        [HttpGet("all")]
        public IActionResult GetAll() 
        {
            return Ok(context.get_all());
        }
        [HttpPut]
        public IActionResult update(int id,string name,bool ischecked)
        {
            var x = context.update(id,name,ischecked);
            if (x)
            {
                return Ok();
            }
            return NotFound();
        }
        [HttpDelete]
        public IActionResult Delete(string name) 
        {
            var x = context.remove_task(name);
            if (x)
            {
                return Ok();
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult add(string name, bool ischecked)
        {
            context.add_task(name, ischecked);
            return Ok();
        }
    }
}
