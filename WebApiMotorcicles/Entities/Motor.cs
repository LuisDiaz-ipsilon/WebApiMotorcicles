namespace WebApiMotorcicles.Entities
{
    public class Motor
    {
        public int id { get; set; }

        public string tamaño { get; set; }

        public bool turbo { get; set; }

        public int MotorcicleId { get; set; }

        public Motorcicle Motorcicle { get; set; }


    }
}
