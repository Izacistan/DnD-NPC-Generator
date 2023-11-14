﻿// <auto-generated />
using DnD_NPC_Generator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DnD_NPC_Generator.Migrations
{
    [DbContext(typeof(NPCContext))]
    [Migration("20231110212328_Spells")]
    partial class Spells
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DnD_NPC_Generator.Models.NPC", b =>
                {
                    b.Property<int>("NPCId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NPCId"));

                    b.Property<int>("AC")
                        .HasColumnType("int");

                    b.Property<int>("ChaMod")
                        .HasColumnType("int");

                    b.Property<int>("ChaSave")
                        .HasColumnType("int");

                    b.Property<int>("ChaScore")
                        .HasColumnType("int");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfMod")
                        .HasColumnType("int");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StrMod")
                        .HasColumnType("int");

                    b.Property<int>("StrSave")
                        .HasColumnType("int");

                    b.Property<int>("StrScore")
                        .HasColumnType("int");

                    b.Property<string>("Subclass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("NPCs");

                    b.HasData(
                        new
                        {
                            NPCId = 1,
                            AC = 0,
                            ChaMod = 0,
                            ChaSave = 0,
                            ChaScore = 0,
                            Class = "Barbarian",
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
                            Name = "Test NPC",
                            ProfMod = 0,
                            Race = "Human",
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
#pragma warning restore 612, 618
        }
    }
}
