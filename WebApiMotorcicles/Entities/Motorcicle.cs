using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiMotorcicles.Entities
{
    public class Motorcicle
    {
        public int id { get; set; }

        public string modelo { get; set; }

        public bool piel { get; set; }

        public List<Motor> motor { get; set; }
    }
}
