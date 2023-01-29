using Microsoft.AspNetCore.Mvc;
using MVC_EF.Models;

namespace EFCore.Controllers
{
    public class TesteController : Controller
    {
        private ApplicationDbContext _context;

        public TesteController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var alunos = _context.Alunos.ToList();
           // var aluno = _context.Alunos.OrderBy(a => a.Nome);

            return View();
        }
    }
}
