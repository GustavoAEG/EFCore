using EFCore.Models;
using Microsoft.AspNetCore.Mvc;
using EFCore.Context;
using EFCore.Models;
using System.Data;

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
        public IActionResult Create([Bind("Id,Nome,Sexo,Email,Nascimento")] Aluno aluno)
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
                return NotFound();
            }
            return View(aluno);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id, Nome, Sexo, Email, Nascimento")] Aluno aluno)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aluno);
                    _context.SaveChanges();
                }
                catch (DBConcurrencyException)
                {
                    if (!AlunoExists(aluno.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }
        private bool AlunoExists(int id)
        {
            return _context.Alunos.Any(e => e.Id == id);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var aluno = _context.Alunos.SingleOrDefault(a => a.Id == id); //pegar aluno cujo ID seja igual ID q estou passando

            if (aluno == null)
            {

                return NotFound();

            }

            return View(aluno); //caso seja encontrado, sera renderizado pra view aluno
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirma(int? id)
        {
            var aluno = _context.Alunos.SingleOrDefault(a => a.Id == id);
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = _context.Alunos.SingleOrDefault(a => a.Id == id);

            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }
    }
}


