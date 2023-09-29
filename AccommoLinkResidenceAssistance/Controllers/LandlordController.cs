using AccommoLinkResidenceAssistance.Areas.Identity.Data;
using AccommoLinkResidenceAssistance.Models.SystemUsers;
using Microsoft.AspNetCore.Mvc;

namespace AccommoLinkResidenceAssistance.Controllers
{
    public class LandlordController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LandlordController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StudentController
        public IActionResult Index()
        {
            IEnumerable<LandlordDetails> objList = _context.tblLandlordDetails;
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LandlordDetails model)
        {
            if (ModelState.IsValid)
            {
                _context.tblLandlordDetails.Add(model);
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
            var obj = _context.tblLandlordDetails.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(LandlordDetails model)
        {
            if (ModelState.IsValid)
            {
                _context.tblLandlordDetails.Update(model);
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
            var obj = _context.tblLandlordDetails.Find(Id);
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
            var obj = _context.tblLandlordDetails.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(LandlordDetails model)
        {
            if (ModelState.IsValid)
            {
                _context.tblLandlordDetails.Remove(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
