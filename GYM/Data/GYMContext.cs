using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GYM.Models;

namespace GYM.Data
{
    public class GYMContext : DbContext
    {
        public GYMContext (DbContextOptions<GYMContext> options)
            : base(options)
        {
        }

        public DbSet<GYM.Models.CustomerDetail> CustomerDetail { get; set; }

        public DbSet<GYM.Models.Trainer> Trainer { get; set; }

        public DbSet<GYM.Models.Exersice> Exersice { get; set; }

        public DbSet<GYM.Models.ExpTrainer> ExpTrainer { get; set; }
    }
}
