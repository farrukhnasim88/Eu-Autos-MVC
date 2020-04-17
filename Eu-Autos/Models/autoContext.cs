using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eu_Autos.Models
{
    public class autoContext: DbContext
    {
        public autoContext(DbContextOptions<autoContext> options): base(options)
        {


        }
      
        public DbSet<Auto> Autos { get; set; }

    }
}
