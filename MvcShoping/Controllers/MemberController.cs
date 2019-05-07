using MvcShoping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcShoping.Controllers
{
    public class MemberController : Controller
    {
        /// <summary>
        /// 会员注册页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }
        /// <summary>
        /// 写入会员信息
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Register([Bind(Exclude ="RegisterOn,AuthCode")]Member member)
        {
            return View();
        }
        /// <summary>
        /// 显示会员登陆页面
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        /// <summary>
        /// 运行会员登录
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(string email, string password, string returnUrl)
        {
            if (validateUser(email, password))
            {
                FormsAuthentication.SetAuthCookie(email, false);
                if (String.IsNullOrEmpty(returnUrl))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return Redirect(returnUrl);
                }
            }
            ModelState.AddModelError("", "您输入的账号或密码错误！");
            return View();
        }

        private bool validateUser(string email, string password)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 注销登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            //清除窗口的cookies
            FormsAuthentication.SignOut();

            //清除所有曾经写过的session信息
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}