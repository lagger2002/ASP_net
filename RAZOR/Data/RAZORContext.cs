using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RAZOR.Models;

namespace RAZOR.Data
{
    public class RAZORContext : DbContext
    {
        public RAZORContext (DbContextOptions<RAZORContext> options)
            : base(options)
        {
        }
        
        public DbSet<RAZOR.Models.Movie> Movie { get; set; }
    }
}
