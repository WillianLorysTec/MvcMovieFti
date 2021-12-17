#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovieFti.Models;

namespace MvcMovieFti.Data
{
    public class MvcMovieFtiContext : DbContext
    {
        public MvcMovieFtiContext (DbContextOptions<MvcMovieFtiContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieFti.Models.Movie> Movie { get; set; }
    }
}
