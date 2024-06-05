using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovieWebApp.Models;

namespace MvcMovieWebApp.Data
{
    public class MvcMovieWebAppContext : DbContext
    {
        public MvcMovieWebAppContext (DbContextOptions<MvcMovieWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieWebApp.Models.Movie> Movie { get; set; } = default!;
    }
}
