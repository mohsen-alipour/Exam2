namespace WebApplicationExam2.Models.Entity
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public DateTime generateDate { get; set; }
       
        public int categoryID { get; set; }
        public Category category { get; set; }

        public int userID { get; set; }
        public User user { get; set; }
    }


}
