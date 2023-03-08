namespace WebApiMotorcicles.Entities
{
    public class Motor
    {
        public int id { get; set; }

        public string tamaño { get; set; }

        public bool turbo { get; set; }

        public int motorcicleId { get; set; }

        public Motorcicle motorcicle { get; set; }


    }
}
