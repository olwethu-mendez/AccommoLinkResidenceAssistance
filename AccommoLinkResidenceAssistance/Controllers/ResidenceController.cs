using AccommoLinkResidenceAssistance.Areas.Identity.Data;
using AccommoLinkResidenceAssistance.Models.SystemUsers;
using AccommoLinkResidenceAssistance.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccommoLinkResidenceAssistance.Controllers
{
    public class ResidenceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResidenceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StudentController
        public IActionResult Index()
        {
            IEnumerable<Residences> objList = _context.tblResidences;
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Residences model)
        {
            if (ModelState.IsValid)
            {
                _context.tblResidences.Add(model);
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
            var obj = _context.tblResidences.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Residences model)
        {
            if (ModelState.IsValid)
            {
                _context.tblResidences.Update(model);
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
            var obj = _context.tblResidences.Find(Id);
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
            var obj = _context.tblResidences.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Residences model)
        {
            if (ModelState.IsValid)
            {
                _context.tblResidences.Remove(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
