using HospitaFlow.Core.Entities.Application;
using HospitaFlow.Core.Entities.Billing;
using HospitaFlow.Core.Entities.Lookups;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        // -------------------------
        // Application Schema
        // -------------------------
        public DbSet<PatientFile> PatientFiles { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<LabOrder> LabOrders { get; set; }
        public DbSet<Admission> Admissions { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Visit> Visits { get; set; }
  

        // -------------------------
        // Lookups Schema
        // -------------------------
        public DbSet<Department> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Specialization> DoctorSpecialities { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<LabTest> LabTests { get; set; }

        // -------------------------
        // Billing Schema
        // -------------------------
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // -------------------------
            // Schemas Mapping
            // -------------------------

            // Application
            modelBuilder.Entity<PatientFile>().ToTable("PatientFile", "Application");
            modelBuilder.Entity<Appointment>().ToTable("Appointment", "Application");
            modelBuilder.Entity<MedicalRecord>().ToTable("MedicalRecord", "Application");
            modelBuilder.Entity<LabOrder>().ToTable("LabOrder", "Application");
            modelBuilder.Entity<Admission>().ToTable("Appointment", "Admission");
            modelBuilder.Entity<Prescription>().ToTable("Prescription", "Application");
            modelBuilder.Entity<Insurance>().ToTable("Insurance", "Application");
            modelBuilder.Entity<Visit>().ToTable("Visit", "Application");

            // Lookups
            modelBuilder.Entity<Department>().ToTable("Department", "Lookups");
            modelBuilder.Entity<Doctor>().ToTable("Doctor", "Lookups");
            modelBuilder.Entity<Specialization>().ToTable("Specialization", "Lookups");
            modelBuilder.Entity<Item>().ToTable("Item", "Lookups");
            modelBuilder.Entity<Bed>().ToTable("Bed", "Lookups");
            modelBuilder.Entity<Room>().ToTable("Room", "Lookups");
            modelBuilder.Entity<PrescriptionItem>().ToTable("PrescriptionItem", "Lookups");
            modelBuilder.Entity<LabTest>().ToTable("LabTest", "Lookups");


            // Billing
            modelBuilder.Entity<Invoice>().ToTable("Invoice", "Billing");
            modelBuilder.Entity<InvoiceItem>().ToTable("InvoiceItem", "Billing");

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
            .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
