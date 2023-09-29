using AccommoLinkResidenceAssistance.Areas.Identity.Data;
using AccommoLinkResidenceAssistance.Models.SystemUsers;
using Microsoft.AspNetCore.Mvc;

namespace AccommoLinkResidenceAssistance.Controllers
{
    public class CampusController : Controller
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
                IEnumerable<Campuses> objList = _context.tblCampuses;
                return View(objList);
            }

            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create(Campuses model)
            {
                if (ModelState.IsValid)
                {
                    _context.tblCampuses.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }

            public IActionResult Edit(int? Id)
            {
                if(Id == 0 || Id == null)
                {
                    return NotFound();
                }
                var obj = _context.tblCampuses.Find(Id);
                if (obj == null)
                {
                    return NotFound();
                }
                return View(obj);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Edit(Campuses model)
            {
                if (ModelState.IsValid)
                {
                    _context.tblCampuses.Update(model);
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
                var obj = _context.tblCampuses.Find(Id);
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
                var obj = _context.tblCampuses.Find(Id);
                if (obj == null)
                {
                    return NotFound();
                }
                return View(obj);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Delete(Campuses model)
            {
                if (ModelState.IsValid)
                {
                    _context.tblCampuses.Remove(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }

            public List<Campuses> GetAll()
            {
                return _context.tblCampuses.ToList();
            }

            public Campuses GetById(int? Id)
            {
                return _context.tblCampuses.FirstOrDefault(x => x.Id == Id);
            }
        }
    }
}
