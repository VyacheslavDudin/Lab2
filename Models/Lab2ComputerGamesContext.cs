using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyLab2.Models
{
    public class Lab2ComputerGamesContext : DbContext
    {
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<ComputerGames> ComputerGames { get; set; }
        public virtual DbSet<Platform> Platforms { get; set; }
        public virtual DbSet<DevelopmentStudio> DevelopmentStudios { get; set; }
        public virtual DbSet<Subsidiaries> Subsidiaries { get; set; }
        public virtual DbSet<DevelopingGames> DevelopingGames { get; set; }
        public virtual DbSet<ComputerGameOnPlatform> ComputerGamesOnPlatforms { get; set; }

        public Lab2ComputerGamesContext(DbContextOptions<Lab2ComputerGamesContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
