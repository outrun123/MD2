using Microsoft.AspNetCore.Mvc;
using md2_backend.Models;
using System.Linq;

namespace md2_backend.Controllers
{
    [Route("api/[controller]")]
    public class PropertyController : Controller
    {
        private readonly ApiContext _ctx;

        public PropertyController(ApiContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _ctx.Properties.OrderBy(c => c.id);

            return Ok(data);
        }

        [HttpGet("{id}", Name = "GetProperty")]
        public IActionResult Get(int id)
        {
            var property = _ctx.Properties.Find(id);
            return Ok(property);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Property property)
        {
            if(property == null)
            {
                return BadRequest();
            }

            _ctx.Properties.Add(property);
            _ctx.SaveChanges();
            return CreatedAtRoute("GetProperty", new { id = property.id }, property);
        }

    }
}