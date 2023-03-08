using Microsoft.AspNetCore.Mvc;
using WebApiMotorcicles.Entities;

namespace WebApiMotorcicles.Controllers
{
    [ApiController]
    [Route("motor")]
    public class MotorController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Motor>> Get()
        {
            return new List<Motor>()
            {
                new Motor {id=1, demon =true, ethanol = true, nitro= true, supercharger=true, turbo = true, tamaño = "400CC"}
            };
        }
    }
}
