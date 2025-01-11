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
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos;


            return View(emprestimos);
        }

        public IActionResult Register() 
        {
            return View();
        }
    }
}
