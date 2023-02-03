using Microsoft.EntityFrameworkCore;
using EFCore.Models;

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
