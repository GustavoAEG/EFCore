using Microsoft.EntityFrameworkCore;
using MVC_EF.Models;

namespace EFCore.Context
{
    public class DbContext
    {
        private DbContextOptions<ApplicationDbContext> contextOptions;

        public DbContext(DbContextOptions<ApplicationDbContext> contextOptions)
        {
            this.contextOptions = contextOptions;
        }
    }
}
