using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShoping.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        // GET: Order
        /// <summary>
        /// 显示完成的订单窗体页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Complate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Complate(FormCollection form)
        {
            //TODO:将订单信息与购物协和信息写入数据库

            //TODO:订单完成后必须清空现在的购物车信息

            //TODO:生而为人 不能自大骄傲 也不必妄自菲薄，

            //订单完成后返回网站首页
            return RedirectToAction("Index", "Home");
        }

    }
}