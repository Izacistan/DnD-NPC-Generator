﻿// <auto-generated />
using System;
using DnD_NPC_Generator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DnD_NPC_Generator.Migrations
{
    [DbContext(typeof(NPCContext))]
    partial class NPCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DnD_NPC_Generator.Models.NPC", b =>
                {
                    b.Property<int>("NPCId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NPCId"), 1L, 1);

                    b.Property<int>("AC")
                        .HasColumnType("int");

                    b.Property<int>("ChaMod")
                        .HasColumnType("int");

                    b.Property<int>("ChaSave")
                        .HasColumnType("int");

                    b.Property<int>("ChaScore")
                        .HasColumnType("int");

                    b.Property<int>("ConMod")
                        .HasColumnType("int");

                    b.Property<int>("ConSave")
                        .HasColumnType("int");

                    b.Property<int>("ConScore")
                        .HasColumnType("int");

                    b.Property<int>("DexMod")
                        .HasColumnType("int");

                    b.Property<int>("DexSave")
                        .HasColumnType("int");

                    b.Property<int>("DexScore")
                        .HasColumnType("int");

                    b.Property<int>("HitDie")
                        .HasColumnType("int");

                    b.Property<int>("HitDieCount")
                        .HasColumnType("int");

                    b.Property<int>("HitPoints")
                        .HasColumnType("int");

                    b.Property<bool>("IEAcrobatics")
                        .HasColumnType("bit");

                    b.Property<bool>("IEAnimalHandling")
                        .HasColumnType("bit");

                    b.Property<bool>("IEArcana")
                        .HasColumnType("bit");

                    b.Property<bool>("IEAthletic")
                        .HasColumnType("bit");

                    b.Property<bool>("IEDeception")
                        .HasColumnType("bit");

                    b.Property<bool>("IEHistory")
                        .HasColumnType("bit");

                    b.Property<bool>("IEInsight")
                        .HasColumnType("bit");

                    b.Property<bool>("IEIntimidation")
                        .HasColumnType("bit");

                    b.Property<bool>("IEInvestigation")
                        .HasColumnType("bit");

                    b.Property<bool>("IEMedicine")
                        .HasColumnType("bit");

                    b.Property<bool>("IENature")
                        .HasColumnType("bit");

                    b.Property<bool>("IEPerception")
                        .HasColumnType("bit");

                    b.Property<bool>("IEPerformance")
                        .HasColumnType("bit");

                    b.Property<bool>("IEPersuasion")
                        .HasColumnType("bit");

                    b.Property<bool>("IEReligion")
                        .HasColumnType("bit");

                    b.Property<bool>("IESleightOfHand")
                        .HasColumnType("bit");

                    b.Property<bool>("IEStealth")
                        .HasColumnType("bit");

                    b.Property<bool>("IESurvival")
                        .HasColumnType("bit");

                    b.Property<bool>("IPAcrobatics")
                        .HasColumnType("bit");

                    b.Property<bool>("IPAnimalHandling")
                        .HasColumnType("bit");

                    b.Property<bool>("IPArcana")
                        .HasColumnType("bit");

                    b.Property<bool>("IPAthletic")
                        .HasColumnType("bit");

                    b.Property<bool>("IPDeception")
                        .HasColumnType("bit");

                    b.Property<bool>("IPHistory")
                        .HasColumnType("bit");

                    b.Property<bool>("IPInsight")
                        .HasColumnType("bit");

                    b.Property<bool>("IPIntimidation")
                        .HasColumnType("bit");

                    b.Property<bool>("IPInvestigation")
                        .HasColumnType("bit");

                    b.Property<bool>("IPMedicine")
                        .HasColumnType("bit");

                    b.Property<bool>("IPNature")
                        .HasColumnType("bit");

                    b.Property<bool>("IPPerception")
                        .HasColumnType("bit");

                    b.Property<bool>("IPPerformance")
                        .HasColumnType("bit");

                    b.Property<bool>("IPPersuasion")
                        .HasColumnType("bit");

                    b.Property<bool>("IPReligion")
                        .HasColumnType("bit");

                    b.Property<bool>("IPSleightOfHand")
                        .HasColumnType("bit");

                    b.Property<bool>("IPStealth")
                        .HasColumnType("bit");

                    b.Property<bool>("IPSurvival")
                        .HasColumnType("bit");

                    b.Property<int>("IntMod")
                        .HasColumnType("int");

                    b.Property<int>("IntSave")
                        .HasColumnType("int");

                    b.Property<int>("IntScore")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("NPCClassId")
                        .HasColumnType("int");

                    b.Property<int>("NPCRaceId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfMod")
                        .HasColumnType("int");

                    b.Property<int>("StrMod")
                        .HasColumnType("int");

                    b.Property<int>("StrSave")
                        .HasColumnType("int");

                    b.Property<int>("StrScore")
                        .HasColumnType("int");

                    b.Property<string>("Subclass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WisMod")
                        .HasColumnType("int");

                    b.Property<int>("WisSave")
                        .HasColumnType("int");

                    b.Property<int>("WisScore")
                        .HasColumnType("int");

                    b.Property<bool>("isSpellcaster")
                        .HasColumnType("bit");

                    b.Property<string>("spellData")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NPCId");

                    b.HasIndex("NPCClassId");

                    b.HasIndex("NPCRaceId");

                    b.HasIndex("UserId");

                    b.ToTable("NPCs");

                    b.HasData(
                        new
                        {
                            NPCId = 1,
                            AC = 0,
                            ChaMod = 0,
                            ChaSave = 0,
                            ChaScore = 0,
                            ConMod = 0,
                            ConSave = 0,
                            ConScore = 0,
                            DexMod = 0,
                            DexSave = 0,
                            DexScore = 0,
                            HitDie = 0,
                            HitDieCount = 0,
                            HitPoints = 0,
                            IEAcrobatics = false,
                            IEAnimalHandling = false,
                            IEArcana = false,
                            IEAthletic = false,
                            IEDeception = false,
                            IEHistory = false,
                            IEInsight = false,
                            IEIntimidation = false,
                            IEInvestigation = false,
                            IEMedicine = false,
                            IENature = false,
                            IEPerception = false,
                            IEPerformance = false,
                            IEPersuasion = false,
                            IEReligion = false,
                            IESleightOfHand = false,
                            IEStealth = false,
                            IESurvival = false,
                            IPAcrobatics = false,
                            IPAnimalHandling = false,
                            IPArcana = false,
                            IPAthletic = false,
                            IPDeception = false,
                            IPHistory = false,
                            IPInsight = false,
                            IPIntimidation = false,
                            IPInvestigation = false,
                            IPMedicine = false,
                            IPNature = false,
                            IPPerception = false,
                            IPPerformance = false,
                            IPPersuasion = false,
                            IPReligion = false,
                            IPSleightOfHand = false,
                            IPStealth = false,
                            IPSurvival = false,
                            IntMod = 0,
                            IntSave = 0,
                            IntScore = 0,
                            Level = 1,
                            NPCClassId = 1,
                            NPCRaceId = 4,
                            Name = "Test NPC",
                            ProfMod = 0,
                            StrMod = 0,
                            StrSave = 0,
                            StrScore = 0,
                            Subclass = "",
                            WisMod = 0,
                            WisSave = 0,
                            WisScore = 0,
                            isSpellcaster = false,
                            spellData = ""
                        });
                });

            modelBuilder.Entity("DnD_NPC_Generator.Models.NPCClass", b =>
                {
                    b.Property<int>("NPCClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NPCClassId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NPCClassId");

                    b.ToTable("NPCClasses");

                    b.HasData(
                        new
                        {
                            NPCClassId = 1,
                            Name = "Barbarian"
                        },
                        new
                        {
                            NPCClassId = 2,
                            Name = "Bard"
                        },
                        new
                        {
                            NPCClassId = 3,
                            Name = "Cleric"
                        },
                        new
                        {
                            NPCClassId = 4,
                            Name = "Druid"
                        },
                        new
                        {
                            NPCClassId = 5,
                            Name = "Fighter"
                        },
                        new
                        {
                            NPCClassId = 6,
                            Name = "Monk"
                        },
                        new
                        {
                            NPCClassId = 7,
                            Name = "Paladin"
                        },
                        new
                        {
                            NPCClassId = 8,
                            Name = "Ranger"
                        },
                        new
                        {
                            NPCClassId = 9,
                            Name = "Rogue"
                        },
                        new
                        {
                            NPCClassId = 10,
                            Name = "Sorcerer"
                        },
                        new
                        {
                            NPCClassId = 11,
                            Name = "Warlock"
                        },
                        new
                        {
                            NPCClassId = 12,
                            Name = "Wizard"
                        });
                });

            modelBuilder.Entity("DnD_NPC_Generator.Models.NPCRace", b =>
                {
                    b.Property<int>("NPCRaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NPCRaceId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NPCRaceId");

                    b.ToTable("NPCRaces");

                    b.HasData(
                        new
                        {
                            NPCRaceId = 1,
                            Name = "Dwarf"
                        },
                        new
                        {
                            NPCRaceId = 2,
                            Name = "Elf"
                        },
                        new
                        {
                            NPCRaceId = 3,
                            Name = "Halfling"
                        },
                        new
                        {
                            NPCRaceId = 4,
                            Name = "Human"
                        },
                        new
                        {
                            NPCRaceId = 5,
                            Name = "Dragonborn"
                        },
                        new
                        {
                            NPCRaceId = 6,
                            Name = "Gnome"
                        },
                        new
                        {
                            NPCRaceId = 7,
                            Name = "Half-Elf"
                        },
                        new
                        {
                            NPCRaceId = 8,
                            Name = "Half-Orc"
                        },
                        new
                        {
                            NPCRaceId = 9,
                            Name = "Tiefling"
                        });
                });

            modelBuilder.Entity("DnD_NPC_Generator.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DnD_NPC_Generator.Models.NPC", b =>
                {
                    b.HasOne("DnD_NPC_Generator.Models.NPCClass", "NPCClass")
                        .WithMany()
                        .HasForeignKey("NPCClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DnD_NPC_Generator.Models.NPCRace", "NPCRace")
                        .WithMany()
                        .HasForeignKey("NPCRaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DnD_NPC_Generator.Models.User", null)
                        .WithMany("NPCs")
                        .HasForeignKey("UserId");

                    b.Navigation("NPCClass");

                    b.Navigation("NPCRace");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DnD_NPC_Generator.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DnD_NPC_Generator.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DnD_NPC_Generator.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DnD_NPC_Generator.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DnD_NPC_Generator.Models.User", b =>
                {
                    b.Navigation("NPCs");
                });
#pragma warning restore 612, 618
        }
    }
}
