using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infra.Data.Context
{
    public class UniversityDbContext: DbContext
    {
        public UniversityDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}
