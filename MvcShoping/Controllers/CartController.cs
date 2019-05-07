using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShoping.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        [HttpPost]
        public ActionResult AddToCart(int productId, int amount)
        {
            return View();
        }
        /// <summary>
        /// 显示当前购物车项目
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 移除购物车项目
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Remove(int productId)
        {
            return View();
        }
        /// <summary>
        /// 更新购物车中特定项目的购买数量
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="NewAmount"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UpdateAmount(int productId, int NewAmount)
        {
            return View();
        }
    }
}