using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Thblesson09.Models.DataModels;

namespace Thblesson09.Controllers
{
    public class ThbHomeController : Controller
    {
        private static List<ThbMember> _thbMembers=new List<ThbMember>();
        // GET: ThbHomeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ThbHomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ThbHomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThbHomeController/Create
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

        // GET: ThbHomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ThbHomeController/Edit/5
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

        // GET: ThbHomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ThbHomeController/Delete/5
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
