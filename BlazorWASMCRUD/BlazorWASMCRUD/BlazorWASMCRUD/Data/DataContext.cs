using BlazorWASMCRUD.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorWASMCRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame { Id = 1, Title = "Cyberpunk 2077", Publisher = "CD Projekt Red", ReleaseYear = 2020 },
                new VideoGame { Id = 2, Title = "Elden Ring", Publisher = "FromSoftware", ReleaseYear = 2022 },
                new VideoGame { Id = 3, Title = "Legend of Zelda: Majora's Mask", Publisher = "Nintendo", ReleaseYear = 2000 }
            );
        }

        public DbSet<VideoGame> VideoGames {  get; set; }
    }
}
