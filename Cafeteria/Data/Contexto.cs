using Cafeteria.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Cafeteria.Data
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Produto> Produto { get; set; }
    }
}
