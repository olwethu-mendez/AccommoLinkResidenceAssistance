using AccommoLinkResidenceAssistance.Areas.Identity.Data;
using AccommoLinkResidenceAssistance.Models.SystemUsers;
using Microsoft.AspNetCore.Mvc;

namespace AccommoLinkResidenceAssistance.Controllers
{
    public class UniversityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UniversityController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<UniversityDetails> objList = _context.tblUniversityDetails;
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UniversityDetails model)
        {
            if (ModelState.IsValid)
            {
                _context.tblUniversityDetails.Add(model);
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
            var obj = _context.tblUniversityDetails.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UniversityDetails model)
        {
            if (ModelState.IsValid) { 
                _context.tblUniversityDetails.Update(model);
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
            var obj = _context.tblUniversityDetails.Find(Id);
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
            var obj = _context.tblUniversityDetails.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(UniversityDetails model)
        {
            if (ModelState.IsValid) { 
                _context.tblUniversityDetails.Remove(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public List<UniversityDetails> GetAll()
        {
            return _context.tblUniversityDetails.ToList();
        }

        public UniversityDetails GetById(int? Id)
        {
            return _context.tblUniversityDetails.FirstOrDefault(x => x.Id == Id);
        }
    }
}
