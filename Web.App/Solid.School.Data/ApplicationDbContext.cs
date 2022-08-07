﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Solid.School.Models;

namespace Solid.School.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomAspNetUsers>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
            SeedUser(builder);
            SeedUserRoles(builder);
        }

        private void SeedRoles(ModelBuilder modelBuilder)
        {
            var adminRole = new IdentityRole() { Id = "721841da-b446-45e1-988c-29234d26e562", Name = "Admin", ConcurrencyStamp = "721841da-b446-45e1-988c-29234d26e562", NormalizedName = "ADMIN" };
            var employeeRole = new IdentityRole() { Id = "19fc5d8f-709f-43bb-99f4-4302e6493ed5", Name = "Employee", ConcurrencyStamp = "19fc5d8f-709f-43bb-99f4-4302e6493ed5", NormalizedName = "EMPLOYEE" };

            modelBuilder.Entity<IdentityRole>().HasData(adminRole, employeeRole);
        }

        private void SeedUser(ModelBuilder modelBuilder)
        {
            PasswordHasher<CustomAspNetUsers> hasher = new PasswordHasher<CustomAspNetUsers>();
            var adminUser = new CustomAspNetUsers()
            {
                Id = "826d6171-a044-4f4c-b0b6-2979e0bb53ad",
                UserName = "admin@admin.com",
                NormalizedUserName = "admin@admin.com".ToUpper(),
                Email = "admin@admin.com",
                NormalizedEmail = "admin@admin.com".ToUpper(),
                PhoneNumber = "1234567890",
                LockoutEnabled = false,
                EmailConfirmed = true,
                SecurityStamp = "826d6171-a044-4f4c-b0b6-2979e0bb53ae",
                ConcurrencyStamp = "826d6171-a044-4f4c-b0b6-2979e0bb53af",
                PhoneNumberConfirmed = true
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin@123");

            var employeeUser = new CustomAspNetUsers()
            {
                Id = "95119256-753e-4d5c-a1bf-b307200b64b4",
                UserName = "employee@employee.com",
                NormalizedUserName = "employee@employee.com".ToUpper(),
                Email = "employee@employee.com",
                NormalizedEmail = "employee@employee.com".ToUpper(),
                PhoneNumber = "1234567890",
                LockoutEnabled = false,
                EmailConfirmed = true,
                SecurityStamp = "95119256-753e-4d5c-a1bf-b307200b64b5",
                ConcurrencyStamp = "95119256-753e-4d5c-a1bf-b307200b64b6",
                PhoneNumberConfirmed = true
            };
            employeeUser.PasswordHash = hasher.HashPassword(employeeUser, "Employee@123");

            modelBuilder.Entity<CustomAspNetUsers>().HasData(adminUser, employeeUser);
        }

        private void SeedUserRoles(ModelBuilder modelBuilder)
        {
            var adminUserRole = new IdentityUserRole<string>()
            {
                RoleId = "721841da-b446-45e1-988c-29234d26e562",
                UserId = "826d6171-a044-4f4c-b0b6-2979e0bb53ad"
            };
            var employeeUserRole = new IdentityUserRole<string>()
            {
                RoleId = "19fc5d8f-709f-43bb-99f4-4302e6493ed5",
                UserId = "95119256-753e-4d5c-a1bf-b307200b64b4"
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(adminUserRole, employeeUserRole);
        }
    }
}