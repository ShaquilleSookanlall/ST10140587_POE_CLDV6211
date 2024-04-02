using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ST10140587_POE_CLDV6211.Models;

namespace ST10140587_POE_CLDV6211.Controllers
{
    public class MyWorkController : Controller
    {
        // GET: MyWorkController
        public ActionResult MyWork()
        {
            //Simulate the event of fetching a product from a database
            var myWork = new List<MyWork>
            {
                new MyWork {Id = 1, Name = "Wraith", Description= "Interdimentional Skirmisher", ImageUrl="//Images/WraithTest.jpg", Price= 500},
                new MyWork {Id = 2, Name = "", Description= "", ImageUrl="", Price= 1}
            };
            return View();
        }

        // GET: MyWorkController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyWorkController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyWorkController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MyWorkController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyWorkController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MyWorkController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyWorkController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
