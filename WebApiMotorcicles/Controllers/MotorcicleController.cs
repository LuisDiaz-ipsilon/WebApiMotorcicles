using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiMotorcicles.Entities;

namespace WebApiMotorcicles.Controllers
{
    [ApiController]
    [Route("motorcicle")]
    public class MotorcicleController: ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public MotorcicleController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Motorcicle>> Get()
        {
            return new List<Motorcicle>() 
            { 
                //new Motorcicle {Id=1, Modelo="Indian", Piel = true}
            };
        }

        [HttpPost]
        public async Task<ActionResult> Post(Motorcicle motorcicle)
        {
            _context.Add(motorcicle);
            await _context.SaveChangesAsync();
            return Ok();

        }

        [HttpGet("lista")]
        public async Task<ActionResult<List<Motorcicle>>> GetAll()
        {
            return await _context.Motocicletas.Include(x => x.Motor).ToListAsync();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Motorcicle motocicleta, int id)
        {
            if(motocicleta.Id != id)
            {
                return BadRequest("No se contro el id mencionado");
            }

            _context.Update(motocicleta);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await _context.Motocicletas.AnyAsync(x => x.Id == id);

            if(!exist)
            {
                return NotFound("No se encontro el id del registro a eliminar.");
            }

            _context.Remove(new Motorcicle() { Id = id });
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
