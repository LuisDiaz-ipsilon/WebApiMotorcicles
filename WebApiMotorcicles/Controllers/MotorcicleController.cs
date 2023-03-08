using Microsoft.AspNetCore.Mvc;
using WebApiMotorcicles.Entities;

namespace WebApiMotorcicles.Controllers
{
    [ApiController]
    [Route("motorcicle")]
    public class MotorcicleController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Motorcicle>> Get()
        {
            return new List<Motorcicle>() 
            { 
                new Motorcicle {id=1, idMotor= 1, modelo="Indian", piel = true}
            };
        }
    }
}
