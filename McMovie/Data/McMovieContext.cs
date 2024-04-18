using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using McMovie.Models;

namespace McMovie.Data
{
    public class McMovieContext : DbContext
    {
        public McMovieContext (DbContextOptions<McMovieContext> options)
            : base(options)
        {
        }

        public DbSet<McMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
