using MvcShoping.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShoping.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var data = new List<ProductCategory>()
            {
                new ProductCategory(){ Id=1,Name="文具"},
                new ProductCategory(){ Id=2,Name="礼品"},
                new ProductCategory(){ Id=3,Name="学习"},
                new ProductCategory(){ Id=4,Name="二毛"}
            };
            return View(data);
        }
        /// <summary>
        /// 商品列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ProductList(int id)
        {

            var productCategory = new ProductCategory()
            {
                Id = id,
                Name = "类别" + id
            };
            var data = new List<Product>() {
                new Product(){ Id=1,productCategory=productCategory,Name="原子笔",Description="N/A", Price=30, PublishOn=DateTime.Now,Color=Color.Black},
                new Product(){ Id=1,productCategory=productCategory,Name="水彩笔",Description="N/A", Price=35, PublishOn=DateTime.Now,Color=Color.Black},
                new Product(){ Id=1,productCategory=productCategory,Name="素描笔",Description="N/A", Price=50, PublishOn=DateTime.Now,Color=Color.Black},

            };
            return View(data);
        }
        /// <summary>
        /// 商品明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ProductDetail(int id)
        {
            var productCategory = new ProductCategory()
            {
                Id = 1,
                Name = "文具"
            };
            var data = new Product()
            {
                Id = id,
                productCategory = productCategory,
                Name = "商品" + id,
                Description = "N/A",
                Price = 30,
                PublishOn = DateTime.Now,
                Color = Color.Black
            };
            return View(data);
        }
    }
}