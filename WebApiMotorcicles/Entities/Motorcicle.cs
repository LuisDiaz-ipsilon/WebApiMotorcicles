using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiMotorcicles.Entities
{
    public class Motorcicle
    {
        public int Id { get; set; }

        public string Modelo { get; set; }

        public bool Piel { get; set; }

        public List<Motor> Motor { get; set; }
    }
}
