using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiMotorcicles.Entities
{
    public class Motorcicle
    {
        public int id { get; set; }

        public string modelo { get; set; }

        public bool piel { get; set; }

        [ForeignKey("Motor")]
        public int idMotor { get; set; }
    }
}
