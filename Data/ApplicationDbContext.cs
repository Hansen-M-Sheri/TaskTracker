using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tasks.Models;

namespace Tasks.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tasks.Models.Role> Role { get; set; }
        public DbSet<Tasks.Models.Priority> Priority { get; set; }
        public DbSet<Tasks.Models.Project> Project { get; set; }
        public DbSet<Tasks.Models.Status> Status { get; set; }
        public DbSet<Tasks.Models.Ticket> Ticket { get; set; }
        public DbSet<Tasks.Models.TicketType> TicketType { get; set; }
        public DbSet<Tasks.Models.User> User { get; set; }
    }
}
