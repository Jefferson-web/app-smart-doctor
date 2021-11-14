﻿// <auto-generated />
using System;
using AppSmartDoctor.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppSmartDoctor.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211114072619_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppSmartDoctor.Models.Archivo", b =>
                {
                    b.Property<string>("archivoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("citaId")
                        .HasColumnType("int");

                    b.Property<string>("content_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("data")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha_registro")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("tamano")
                        .HasColumnType("bigint");

                    b.HasKey("archivoId");

                    b.HasIndex("citaId");

                    b.ToTable("Archivos");
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Cita", b =>
                {
                    b.Property<int>("citaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("atendido")
                        .HasColumnType("bit");

                    b.Property<double>("costo")
                        .HasColumnType("float");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_registro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("hora_fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("hora_inicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("medicoId")
                        .HasColumnType("int");

                    b.Property<string>("motivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pacienteId")
                        .HasColumnType("int");

                    b.Property<bool>("pagado")
                        .HasColumnType("bit");

                    b.HasKey("citaId");

                    b.HasIndex("medicoId");

                    b.HasIndex("pacienteId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Consultorio", b =>
                {
                    b.Property<int>("consultorioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<double>("importe")
                        .HasColumnType("float");

                    b.Property<int>("medicoId")
                        .HasColumnType("int");

                    b.HasKey("consultorioId");

                    b.HasIndex("medicoId")
                        .IsUnique();

                    b.ToTable("Consultorios");
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Especialidad", b =>
                {
                    b.Property<int>("especialidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("especialidadId");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Estudio", b =>
                {
                    b.Property<int>("estudioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("anio")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("medicoId")
                        .HasColumnType("int");

                    b.HasKey("estudioId");

                    b.HasIndex("medicoId");

                    b.ToTable("Estudios");
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Experiencia", b =>
                {
                    b.Property<int>("experienciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("anio")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("medicoId")
                        .HasColumnType("int");

                    b.HasKey("experienciaId");

                    b.HasIndex("medicoId");

                    b.ToTable("Experiencias");
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Horario", b =>
                {
                    b.Property<int>("horarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("disponible")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("hora_fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("hora_inicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("medicoId")
                        .HasColumnType("int");

                    b.HasKey("horarioId");

                    b.HasIndex("medicoId");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Medico", b =>
                {
                    b.Property<int>("medicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CMP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("especialidadId")
                        .HasColumnType("int");

                    b.Property<string>("nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("residenciaId")
                        .HasColumnType("int");

                    b.HasKey("medicoId");

                    b.HasIndex("especialidadId");

                    b.HasIndex("residenciaId");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Paciente", b =>
                {
                    b.Property<int>("pacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DNI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("distrito_colonia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha_nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("sexo")
                        .HasColumnType("bit");

                    b.HasKey("pacienteId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Pago", b =>
                {
                    b.Property<int>("pagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("citaId")
                        .HasColumnType("int");

                    b.Property<string>("cvv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("expiracion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha_pago")
                        .HasColumnType("datetime2");

                    b.Property<double>("monto")
                        .HasColumnType("float");

                    b.Property<string>("nombreTarjeta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroTarjeta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipoPagoId")
                        .HasColumnType("int");

                    b.HasKey("pagoId");

                    b.HasIndex("citaId");

                    b.HasIndex("tipoPagoId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Residencia", b =>
                {
                    b.Property<int>("residenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("pais")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("residenciaId");

                    b.ToTable("Residencias");
                });

            modelBuilder.Entity("AppSmartDoctor.Models.TipoPago", b =>
                {
                    b.Property<int>("tipoPagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tipoPagoId");

                    b.ToTable("TipoPago");
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Archivo", b =>
                {
                    b.HasOne("AppSmartDoctor.Models.Cita", null)
                        .WithMany()
                        .HasForeignKey("citaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Cita", b =>
                {
                    b.HasOne("AppSmartDoctor.Models.Medico", null)
                        .WithMany()
                        .HasForeignKey("medicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppSmartDoctor.Models.Paciente", null)
                        .WithMany()
                        .HasForeignKey("pacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Consultorio", b =>
                {
                    b.HasOne("AppSmartDoctor.Models.Medico", null)
                        .WithOne()
                        .HasForeignKey("AppSmartDoctor.Models.Consultorio", "medicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Estudio", b =>
                {
                    b.HasOne("AppSmartDoctor.Models.Medico", null)
                        .WithMany()
                        .HasForeignKey("medicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Experiencia", b =>
                {
                    b.HasOne("AppSmartDoctor.Models.Medico", null)
                        .WithMany()
                        .HasForeignKey("medicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Horario", b =>
                {
                    b.HasOne("AppSmartDoctor.Models.Medico", null)
                        .WithMany()
                        .HasForeignKey("medicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Medico", b =>
                {
                    b.HasOne("AppSmartDoctor.Models.Especialidad", null)
                        .WithMany()
                        .HasForeignKey("especialidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppSmartDoctor.Models.Residencia", null)
                        .WithMany()
                        .HasForeignKey("residenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppSmartDoctor.Models.Pago", b =>
                {
                    b.HasOne("AppSmartDoctor.Models.Cita", null)
                        .WithMany()
                        .HasForeignKey("citaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppSmartDoctor.Models.TipoPago", null)
                        .WithMany()
                        .HasForeignKey("tipoPagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
