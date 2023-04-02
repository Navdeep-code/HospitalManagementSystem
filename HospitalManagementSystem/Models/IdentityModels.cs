﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Services.Description;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HospitalManagementSystem.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
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
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }


        //Add a department entity to our system
        public DbSet<Department> Departments { get; set; }      // department is the entity name as singular, where departments is the table name plural , to differentiate

        //Add a location entity to our system
        public DbSet<Location> Locations { get; set; }

        //Add a service entity to our system
        public DbSet<Service> Services { get; set; }

        //Add a career entity to our system
        public DbSet<Career> Careers { get; set; }

        //Add a Doctor entity to our system
        public DbSet<Doctor> Doctors { get; set; }

        //Add a Apointment entity to our system
        public DbSet<Appointment> Appointments { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}