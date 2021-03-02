using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using reFactorPrj.Models;

namespace reFactorPrj.Controllers
{
    public class MembersController : Controller
    {
        private reModel db = new reModel();


        // GET: Members/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Members/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tMembers tMembers)
        {
            var confirmedEmail = db.tMembers.FirstOrDefault(e => e.fM_Email == tMembers.fM_Email);
            if (confirmedEmail != null)
            {
                ModelState.AddModelError("fM_Email", "Email重複");
            }
            if (ModelState.IsValid)
            {
                db.tMembers.Add(tMembers);
                db.SaveChanges();
                TempData["SuccesedMessage"] = "註冊成功，請重新登入";
                return RedirectToAction("Login", "Members");
            }
           
            return View(tMembers);
        }



        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        //登入
        public ActionResult Login(Login login)
        {

            if (ModelState.IsValid)
            {
                var user = db.tMembers.FirstOrDefault(s => s.fM_Email == login.fM_Email && s.fM_Password == login.fM_Password);
               

                if (user != null)
                {
                    Session["isLogin"] = user.fM_Id;
                    TempData["SuccesedLogin"] = "登入成功";
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("fM_Password", "帳號或密碼錯誤");

            }
            return View(login);
        }
    }
}
