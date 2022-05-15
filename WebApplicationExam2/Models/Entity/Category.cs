
namespace WebApplicationExam2.Models.Entity
{
    public class Category
    {
        public int ID { get; set; }
        public string Title { get; set; }
        
        public ICollection<Product>? Products { get; set; }

    }

}
