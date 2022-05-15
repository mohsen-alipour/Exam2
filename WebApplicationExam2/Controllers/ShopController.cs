using WebApplicationExam2.Infrastructure.DataAccess;
using WebApplicationExam2.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationExam2.Controllers
{
    public class ShopController : Controller
    {
        private ShopRepository O_shop_R;
      
        public ShopController()
        {
            O_shop_R = new ShopRepository();
            
        }

        public IActionResult Index()
        {
            var productslist = O_shop_R.GetAllproduct();
            return View(productslist);
            
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product item)
        {
            O_shop_R.AddProduct(item);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var P= O_shop_R.getproduct(id);
            O_shop_R.Delete(P);
            return RedirectToAction("Index");
        }
        public  IActionResult Detail(int id)
        {
            var P = O_shop_R.getproduct(id);
            return View(P);
        }
        public IActionResult Edit(int id)
        {
            var P = O_shop_R.getproduct(id);
            return View(P);

        }
        [HttpPost]
        public IActionResult Edit(Product item)
        {
            
            O_shop_R.EditProduct(item);
        return RedirectToAction("Index");
      
        }
      

    }
}
