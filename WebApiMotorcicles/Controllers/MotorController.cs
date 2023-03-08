using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiMotorcicles.Entities;

namespace WebApiMotorcicles.Controllers
{
    [ApiController]
    [Route("motor")]
    public class MotorController: ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MotorController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public ActionResult<List<Motor>> Get()
        {
            return new List<Motor>()
            {
                new Motor {id=1, demon =true, ethanol = true, nitro= true, supercharger=true, turbo = true, tamaño = "400CC"}
            };
        }

        [HttpPost]
        public async Task<ActionResult> Post (Motor motor)
        {
            _context.Add(motor);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("lista")]
        public async Task<ActionResult<List<Motor>>> GetAll()
        {
            return await _context.Motores.ToListAsync();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Motor motor, int id)
        {
            if(motor.id != id)
            {
                return BadRequest("No se encontro el motor con el id mencionado");
            }

            _context.Update(motor);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = await _context.Motores.AnyAsync(x => x.id == id);

            if (!exists)
            {
                return NotFound("No se encontro el motor con el id ingresado");
            }

            _context.Remove(new Motor() { id = id });
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
