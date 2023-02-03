using Microsoft.AspNetCore.Mvc;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Controllers
{
    public class AlunoTipoSocioController : Controller
    {
        private ApplicationDbContext contexto; //pega os dados do banco e faz a injecao de dependencia

        public AlunoTipoSocioController(ApplicationDbContext _applicationDbContext)
        {
                contexto = _applicationDbContext;//Injecao de dependencia
        }

        public IActionResult Index()
        {
            var infoAluno = contexto.Alunos.Include(tp => tp.TipoSocios);
            return View(infoAluno);
        }
    }
}
