using Microsoft.EntityFrameworkCore;
using WebApplicationExam2.Infrastructure.DataBase;
using WebApplicationExam2.Models.Entity;
using WebApplicationExam2.Models.QueryModel;
using System.Linq;
namespace WebApplicationExam2.Infrastructure.DataAccess

{
    public class ShopRepository
    {
        private ShopeContext O_shopcontext;
        public ShopRepository()
        {
            O_shopcontext = new ShopeContext();
        }

        public List<ProductWithCategoryQueryModel> GetAllproduct()
        {
            var x = (from p in O_shopcontext.Products
                     join c in O_shopcontext.Categorys
                     on p.categoryID equals c.ID
                     select new ProductWithCategoryQueryModel()
                     {
                         IDP=p.ID,
                         NameP=p.Name,
                         PriceP=p.Price,
                         CountP=p.Count,
                         generateDateP=p.generateDate,
                         categorytitleC=c.Title,
                         
                         
                     }).ToList();
            return x;
                   
        }

        public Product getproduct(int Pid)
        {
            return O_shopcontext.Products.Where(X => X.ID == Pid).FirstOrDefault();
        }

        public void AddProduct(Product item)
        {
            O_shopcontext.Products.Add(item);
            O_shopcontext.SaveChanges();
        }
        public void Delete(Product item)
        {
            O_shopcontext.Products.Remove(item);
            O_shopcontext.SaveChanges();
        }
        public void EditProduct (Product item)
        {
            var p= getproduct(item.ID);
            p.Name = item.Name;
            p.Price = item.Price;
            p.Count = item.Count;
            p.generateDate = item.generateDate;
            p.categoryID = item.categoryID;
            p.userID = item.userID;

            O_shopcontext.SaveChanges();
        }
    }
}
