using Microsoft.EntityFrameworkCore;

namespace DnD_NPC_Generator.Models
{
    public class NPCContext : DbContext
    {
        public NPCContext(DbContextOptions<NPCContext> options) : base(options) { }

        public DbSet<NPC> NPCs { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<NPC>().HasData(
                new NPC
                {
                    NPCId = 1,
                    Name = "Test NPC",
                    Class = "Barbarian",
                    Race = "Human",
                    Level = 1
                }
            );
        }
    }
}
