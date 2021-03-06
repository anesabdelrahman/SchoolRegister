﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SchoolRegister.Models.BusinessModels;

namespace SchoolRegister.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<EmergencyContact> EmergencyContacts { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamResults> ExamResultses { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}