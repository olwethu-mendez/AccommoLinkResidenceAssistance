using AccommoLinkResidenceAssistance.Areas.Identity.Data;
using AccommoLinkResidenceAssistance.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccommoLinkResidenceAssistance.Controllers
{
    public class ReportResidenceController : Controller
    {
        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {
            IEnumerable<ReportResidence> objList = _context.tblReportResidences;
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ReportResidence model)
        {
            if (ModelState.IsValid)
            {
                _context.tblReportResidences.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? Id)
        {
            if (Id == 0 || Id == null)
            {
                return NotFound();
            }
            var obj = _context.tblReportResidences.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ReportResidence model)
        {
            if (ModelState.IsValid)
            {
                _context.tblReportResidences.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(int? Id)
        {
            if (Id == 0 || Id == null)
            {
                return NotFound();
            }
            var obj = _context.tblReportResidences.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == 0 || Id == null)
            {
                return NotFound();
            }
            var obj = _context.tblReportResidences.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(ReportResidence model)
        {
            if (ModelState.IsValid)
            {
                _context.tblReportResidences.Remove(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
