﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgramingEasy.Models;

namespace ProgramingEasy.Migrations.ProgramingEasyDB
{
    [DbContext(typeof(ProgramingEasyDBContext))]
    partial class ProgramingEasyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EASY_PROGRAMING_PLATAFORM.Models.Alumnos", b =>
                {
                    b.Property<int>("Id_alumno")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("correo_electronico")
                        .IsRequired();

                    b.Property<string>("nombre")
                        .IsRequired();

                    b.HasKey("Id_alumno");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("EASY_PROGRAMING_PLATAFORM.Models.Cursos", b =>
                {
                    b.Property<int>("Id_curso")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lenguaje_programacion")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id_curso");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("EASY_PROGRAMING_PLATAFORM.Models.Etapas", b =>
                {
                    b.Property<int>("Id_etapa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nivel")
                        .IsRequired();

                    b.HasKey("Id_etapa");

                    b.ToTable("Etapas");
                });

            modelBuilder.Entity("ProgramingEasy.Models.Calificaciones", b =>
                {
                    b.Property<int>("Id_calificacion")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("calificacion");

                    b.HasKey("Id_calificacion");

                    b.ToTable("Calificaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
