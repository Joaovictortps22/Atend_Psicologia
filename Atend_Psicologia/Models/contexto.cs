using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atend_Psicologia.Models;

namespace Atend_Psicologia.Models
{
    public class contexto : DbContext
    {
        public contexto(DbContextOptions<contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public static object TodoItems { get; internal set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
