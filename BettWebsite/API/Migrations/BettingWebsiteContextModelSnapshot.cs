﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(BettingWebsiteContext))]
    partial class BettingWebsiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.Bundesliga", b =>
                {
                    b.Property<int>("MatchId")
                        .HasColumnType("int")
                        .HasColumnName("match_id");

                    b.Property<DateTime>("Datat")
                        .HasColumnType("datetime")
                        .HasColumnName("datat");

                    b.Property<decimal>("Moneys")
                        .HasColumnType("money")
                        .HasColumnName("moneys");

                    b.Property<int>("ScoreAway")
                        .HasColumnType("int")
                        .HasColumnName("score_away");

                    b.Property<int>("ScoreHome")
                        .HasColumnType("int")
                        .HasColumnName("score_home");

                    b.Property<string>("TeamsName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("teamsName");

                    b.HasKey("MatchId")
                        .HasName("PK__Bundesli__9D7FCBA3180CE55F");

                    b.ToTable("Bundesliga");
                });

            modelBuilder.Entity("API.Models.Laliga", b =>
                {
                    b.Property<int>("MatchId")
                        .HasColumnType("int")
                        .HasColumnName("match_id");

                    b.Property<DateTime>("Datat")
                        .HasColumnType("datetime")
                        .HasColumnName("datat");

                    b.Property<decimal>("Moneys")
                        .HasColumnType("money")
                        .HasColumnName("moneys");

                    b.Property<int>("ScoreAway")
                        .HasColumnType("int")
                        .HasColumnName("score_away");

                    b.Property<int>("ScoreHome")
                        .HasColumnType("int")
                        .HasColumnName("score_home");

                    b.Property<string>("TeamsName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("teamsName");

                    b.HasKey("MatchId")
                        .HasName("PK__Laliga__9D7FCBA3F57EA5B1");

                    b.ToTable("Laliga");
                });

            modelBuilder.Entity("API.Models.Liga1", b =>
                {
                    b.Property<int>("MatchId")
                        .HasColumnType("int")
                        .HasColumnName("match_id");

                    b.Property<DateTime>("Datat")
                        .HasColumnType("datetime")
                        .HasColumnName("datat");

                    b.Property<decimal>("Moneys")
                        .HasColumnType("money")
                        .HasColumnName("moneys");

                    b.Property<int>("ScoreAway")
                        .HasColumnType("int")
                        .HasColumnName("score_away");

                    b.Property<int>("ScoreHome")
                        .HasColumnType("int")
                        .HasColumnName("score_home");

                    b.Property<string>("TeamsName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("teamsName");

                    b.HasKey("MatchId")
                        .HasName("PK__Liga1__9D7FCBA30D9C9658");

                    b.ToTable("Liga1");
                });

            modelBuilder.Entity("API.Models.PremierLeague", b =>
                {
                    b.Property<int>("MatchId")
                        .HasColumnType("int")
                        .HasColumnName("match_id");

                    b.Property<DateTime>("Datat")
                        .HasColumnType("datetime")
                        .HasColumnName("datat");

                    b.Property<decimal>("Moneys")
                        .HasColumnType("money")
                        .HasColumnName("moneys");

                    b.Property<int>("ScoreAway")
                        .HasColumnType("int")
                        .HasColumnName("score_away");

                    b.Property<int>("ScoreHome")
                        .HasColumnType("int")
                        .HasColumnName("score_home");

                    b.Property<string>("TeamsName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("teamsName");

                    b.HasKey("MatchId")
                        .HasName("PK__PremierL__9D7FCBA37B50C052");

                    b.ToTable("PremierLeague");
                });

            modelBuilder.Entity("API.Models.SeriaA", b =>
                {
                    b.Property<int>("MatchId")
                        .HasColumnType("int")
                        .HasColumnName("match_id");

                    b.Property<DateTime>("Datat")
                        .HasColumnType("datetime")
                        .HasColumnName("datat");

                    b.Property<decimal>("Moneys")
                        .HasColumnType("money")
                        .HasColumnName("moneys");

                    b.Property<int>("ScoreAway")
                        .HasColumnType("int")
                        .HasColumnName("score_away");

                    b.Property<int>("ScoreHome")
                        .HasColumnType("int")
                        .HasColumnName("score_home");

                    b.Property<string>("TeamsName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("teamsName");

                    b.HasKey("MatchId")
                        .HasName("PK__SeriaA__9D7FCBA34EBBC1C4");

                    b.ToTable("SeriaA");
                });
#pragma warning restore 612, 618
        }
    }
}
