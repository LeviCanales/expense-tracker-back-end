﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using expense_tracker_back_end.Contexts;

namespace expense_tracker_back_end.Migrations
{
    [DbContext(typeof(ExpenseContext))]
    [Migration("20200510013021_m2")]
    partial class m2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("expense_tracker_back_end.Models.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("text");

                    b.Property<string>("Correo")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("expense_tracker_back_end.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Contra")
                        .HasColumnType("text");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("text");

                    b.Property<int>("PersonaID")
                        .HasColumnType("integer");

                    b.HasKey("UsuarioId");

                    b.HasIndex("PersonaID")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("expense_tracker_back_end.Models.Usuario", b =>
                {
                    b.HasOne("expense_tracker_back_end.Models.Persona", "Persona")
                        .WithOne("Usuario")
                        .HasForeignKey("expense_tracker_back_end.Models.Usuario", "PersonaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
