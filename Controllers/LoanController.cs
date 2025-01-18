using EmprestimoLivros.data;
using EmprestimoLivros.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.Controllers
{
    public class LoanController : Controller
    {

        readonly private ApplicationDbContext _db;

        public LoanController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<LoansModel> loans = _db.Loans;


            return View(loans);
        }
        [HttpGet]
        public IActionResult Register() 
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id) 
        {
           if( id == null || id == 0)
            {
                return NotFound();
            }

            LoansModel loans = _db.Loans.FirstOrDefault(x => x.Id == id);

            if(loans == null)
            {
                return NotFound();
            }

            return View(loans);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if( id == null || id == 0)
            {
                return NotFound();
            }

            LoansModel loans = _db.Loans.FirstOrDefault(x => x.Id == id);

            if(loans == null)
            {
                return NotFound();
            }

            return View(loans);
        }

        [HttpPost]
        public IActionResult Register(LoansModel loans)
        {
            if (ModelState.IsValid)
            {
                _db.Loans.Add(loans);
                _db.SaveChanges();

                TempData["SuccessMessage"] = "registration completed successfully";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Edit(LoansModel loan)
        {
            if (ModelState.IsValid)
            {
                _db.Loans.Update(loan);
                _db.SaveChanges();

                TempData["SuccessMessage"] = "change completed successfully";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Delete(LoansModel loan)
        {
            if (loan == null)
            {
                return NotFound();
            }

            _db.Loans.Remove(loan);
            _db.SaveChanges();

            TempData["SuccessMessage"] = "deletion completed successfully";

            return RedirectToAction("Index");
        }
    }
}
