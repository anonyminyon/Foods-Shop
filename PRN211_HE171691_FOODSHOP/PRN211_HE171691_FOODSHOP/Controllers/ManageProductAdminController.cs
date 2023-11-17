using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using PRN211_HE171691_FOODSHOP.Models;
using System.Collections.Generic;

namespace PRN211_HE171691_FOODSHOP.Controllers
{
    public class ManageProductAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }        
        public IActionResult LoadProduct()
        {
            List<ProductHe171691> productList = PRN211_FA23_SE1733Context.INSTANCE.ProductHe171691s.ToList();
            ViewBag.ProductList = productList;
            return View();
        }
        [HttpPost]
        public IActionResult Edit(IFormCollection form)
        {
            //lấy biết check xem edit chưa
            String checkEdit = form["isEdit"];
            //nếu chưa edit thì 
            if (checkEdit.Equals("false"))
            {
                return View();
            }
            else
            {
                //lấy tất cả 
                return View();
            }
        }
        
        public IActionResult Details(int id)
        {
            //lấy id product về 
            int productID = id;
            //var product = PRN211_FA23_SE1733Context.INSTANCE.ProductHe171691s
            //    .Where(x => x.ProductId == productID)
            //    .FirstOrDefault();
            var product = (from p in PRN211_FA23_SE1733Context.INSTANCE.ProductHe171691s
                           where p.ProductId == productID
                           select p).FirstOrDefault();

            //ViewBag.Product = product;
            return View( product);
        }
        [HttpPost]
        public IActionResult Update(int id)
        {
            //lấy id product về 
            int productID = id;
            var product = PRN211_FA23_SE1733Context.INSTANCE.ProductHe171691s
                .Select(x => x)
                .Where(x => x.ProductId == productID);
            ViewBag.Product = product;
            return View();
        }

        [HttpPost]
        public IActionResult Delete(IFormCollection form)
        {
            return View();
        }
    }
}
