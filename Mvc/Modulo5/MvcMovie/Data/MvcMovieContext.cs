using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;

        public DbSet<MvcMovie.Models.User> User { get; set; } = default!;

        public DbSet<MvcMovie.Models.Artist> Artist { get; set; } = default!;

        public DbSet<MvcMovie.Models.Studio> Studio { get; set; } = default!;

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Studio> Studios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        // Configuração do relacionamento de 0 para N entre Movie e Studio
        modelBuilder.Entity<Movie>().HasOne(m => m.Studio).WithMany(s => s.Movies).HasForeignKey(m => m.StudioId);

        // Configuração do relacionamento de 1 para N entre Studio e Movie
        modelBuilder.Entity<Studio>().HasMany(s => s.Movies).WithOne(m => m.Studio).HasForeignKey(m => m.StudioId);
        }
    }
}
