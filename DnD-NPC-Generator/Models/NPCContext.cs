using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace DnD_NPC_Generator.Models
{
    public class NPCContext : IdentityDbContext<User>
    {
        public NPCContext(DbContextOptions<NPCContext> options) : base(options) { }

        public DbSet<NPC> NPCs { get; set; } = null!;
        public DbSet<NPCClass> NPCClasses { get; set; } = null!;
        public DbSet<NPCRace> NPCRaces { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<NPCClass>().HasData(
                new NPCClass { NPCClassId = 1, Name = "Barbarian"},
                new NPCClass { NPCClassId = 2, Name = "Bard" },
                new NPCClass { NPCClassId = 3, Name = "Cleric" },
                new NPCClass { NPCClassId = 4, Name = "Druid" },
                new NPCClass { NPCClassId = 5, Name = "Fighter" },
                new NPCClass { NPCClassId = 6, Name = "Monk" },
                new NPCClass { NPCClassId = 7, Name = "Paladin" },
                new NPCClass { NPCClassId = 8, Name = "Ranger" },
                new NPCClass { NPCClassId = 9, Name = "Rogue" },
                new NPCClass { NPCClassId = 10, Name = "Sorcerer" },
                new NPCClass { NPCClassId = 11, Name = "Warlock" },
                new NPCClass { NPCClassId = 12, Name = "Wizard" }
            );

            modelBuilder.Entity<NPCRace>().HasData(
                new NPCRace { NPCRaceId = 1, Name = "Dwarf"},
                new NPCRace { NPCRaceId = 2, Name = "Elf" },
                new NPCRace { NPCRaceId = 3, Name = "Halfling" },
                new NPCRace { NPCRaceId = 4, Name = "Human" },
                new NPCRace { NPCRaceId = 5, Name = "Dragonborn" },
                new NPCRace { NPCRaceId = 6, Name = "Gnome" },
                new NPCRace { NPCRaceId = 7, Name = "Half-Elf" },
                new NPCRace { NPCRaceId = 8, Name = "Half-Orc" },
                new NPCRace { NPCRaceId = 9, Name = "Tiefling" }
            );

            modelBuilder.Entity<NPC>().HasData(
                new NPC
                {
                    NPCId = 1,
                    Name = "Test NPC",
                    NPCClassId = 1,
                    NPCRaceId = 4,
                    Level = 1,
                    isSpellcaster = false,
                    spellData = ""
                }
            );
        }

        public static async Task CreateAdminUser(IServiceProvider servicesProvider)
        { 
            using (var scoped = servicesProvider.CreateScope()) 
            { 
                UserManager<User> userManager = scoped.ServiceProvider.GetRequiredService<UserManager<User>>();
                RoleManager<IdentityRole> roleManager = scoped.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                string username = "admin";
                string pwd = "admin";
                string roleName = "Admin";

                // if role doesn't exist, create it
                if (await roleManager.FindByNameAsync(roleName) == null) 
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }

                if (await userManager.FindByNameAsync(username) == null) 
                {
                    User user = new User() { UserName = username };
                    var result = await userManager.CreateAsync(user, pwd);
                    if (result.Succeeded) 
                    {
                        await userManager.AddToRoleAsync(user, roleName);
                    }
                }
            }
        }


    }
}
