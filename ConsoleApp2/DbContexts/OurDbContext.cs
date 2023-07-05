﻿using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DbContexts
{
    public class OurDbContext : DbContext
    {
        //comment test

        //     private readonly string connectionString = "Data Source=(local);Initial Catalog=Crm-2023;" +
        //        "User Id=sa; Password=passw0rd;TrustServerCertificate=True;";

        private readonly string connectionString = "Data Source=(local);Initial Catalog=FundRaiser-2023;" +
        " Integrated security=true;TrustServerCertificate=True;";


        public DbSet<Backer> Backers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProjectCreator> ProjectCreators { get; set; }
        public DbSet<ProjectFunding> ProjectFundings { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<RewardPackage> RewardPackages { get; set; }
        public DbSet<ProjectPhotos> ProjectPhotos { get; set; }
        public DbSet<ProjectVideos> ProjectVideos { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
