using AccommoLinkResidenceAssistance.Areas.Identity.Data;
using AccommoLinkResidenceAssistance.Models.SystemUsers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AccommoLinkResidenceAssistance.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StudentController
        public IActionResult Index()
        {
            IEnumerable<StudentDetails> objList = _context.tblStudentDetails;
            return View(objList);
        }

        // GET: StudentController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public IActionResult Create(string? Id)
        {
            ViewBag.StudentId = Id;
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentDetails model)
        {
            if (ModelState.IsValid)
            {
                _context.tblStudentDetails.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        // GET: StudentController/Edit/5
        public IActionResult Edit(int? Id)
        {
            if (Id == 0 || Id == null)
            {
                return NotFound();
            }
            var obj = _context.tblStudentDetails.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(StudentDetails model)
        {
            if (ModelState.IsValid)
            {
                _context.tblStudentDetails.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: StudentController/Delete/5
        public IActionResult Delete(int? Id)
        {
            if (Id == 0 || Id == null)
            {
                return NotFound();
            }
            var obj = _context.tblStudentDetails.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(StudentDetails model)
        {
            if (ModelState.IsValid)
            {
                _context.tblStudentDetails.Remove(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
