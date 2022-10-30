using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todea_Denisa_Lab2.Models;

namespace Todea_Denisa_Lab2.Data
{
    public class Todea_Denisa_Lab2Context : DbContext
    {
        public Todea_Denisa_Lab2Context (DbContextOptions<Todea_Denisa_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Todea_Denisa_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Todea_Denisa_Lab2.Models.Publishers> Publisher { get; set; }

        public DbSet<Todea_Denisa_Lab2.Models.Authors> Authors { get; set; }

        public DbSet<Todea_Denisa_Lab2.Models.Category> Category { get; set; }
    }
}
