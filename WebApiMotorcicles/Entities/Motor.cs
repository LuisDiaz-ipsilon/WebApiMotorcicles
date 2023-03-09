namespace WebApiMotorcicles.Entities
{
    public class Motor
    {
        public int Id { get; set; }

        public string Tamaño { get; set; }

        public bool Turbo { get; set; }

        public int MotorcicleId { get; set; }

        public Motorcicle Motorcicle { get; set; }


    }
}
