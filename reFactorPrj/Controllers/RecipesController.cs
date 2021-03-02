using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcPaging;
using reFactorPrj.Models;
using System.IO;

namespace reFactorPrj.Controllers
{
    public class RecipesController : Controller
    {
        private reModel db = new reModel();
        private int PageSize = 9;
   
        // GET: Recipes
        // 食譜頁面
        public ActionResult Index(int Page=0)
        {     
            Page = Page-1 > 0 ? Page-1:0;
            return View(db.tRecipe.OrderByDescending(m =>m.fR_Id).ToList().ToPagedList(Page,PageSize));

            //return View(db.tRecipe.OrderBy(x => Guid.NewGuid()).ToList());

            
        }



        // 搜尋食譜
        [HttpPost]
        public ActionResult Search(string searchMenu, int Page = 0)
        {
            Page = Page - 1 > 0 ? Page - 1 : 0;
            // AsQueryable 產生SQL 的 where語法
            var result = db.tRecipe.OrderByDescending(m => m.fR_Id).AsQueryable();
            if (!String.IsNullOrEmpty(searchMenu))
            {
                result = result.Where(s => s.fR_Menu.Contains(searchMenu));
            }

            if (result.Any())
            {
                return View("Index", result.ToList().ToPagedList(Page, PageSize));
            }
            else
            {
                TempData["Message"] = "查無結果";
                return RedirectToAction("Index");
            }
        }
      
        // 食譜細項
        public ActionResult Details(int Id)
        {
            tRecipe tRecipe = db.tRecipe.Find(Id);
            return View(tRecipe);
        }

        // 加入購物車
        public ActionResult AddToCart(int Id)
        {
            int UserId = (Session["isLogin"] as tMembers).fM_Id;

            tRecipe tRecipe = db.tRecipe.Find(Id);
            return RedirectToAction("Index","Cart",tRecipe);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
