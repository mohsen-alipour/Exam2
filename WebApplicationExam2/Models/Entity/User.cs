namespace WebApplicationExam2.Models.Entity
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<Product>? Products { get; set; }

    }
}
