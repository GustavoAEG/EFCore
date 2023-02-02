﻿using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC_EF.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>contextOptions)
            :base(contextOptions)
        {

        }
        public DbSet<TipoSocios> TipoSocioL { get; set; }
        public DbSet<Aluno> Alunos { get; set; }

    }
}
