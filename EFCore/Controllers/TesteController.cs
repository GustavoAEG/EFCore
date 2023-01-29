using EFCore.Models;
using Microsoft.AspNetCore.Mvc;
using EFCore.Context;
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
            //var alunos = _context.Alunos.ToList();
           var alunos = _context.Alunos.OrderBy(a => a.Nome);

            return View(alunos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Nome,Sexo,Email,Nascimento")]Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluno);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var aluno = _context.Alunos.SingleOrDefault(a => a.Id == id);
            if (aluno == null)
            {

            }

        }
    }
}
