using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetails_CRUD_Using_EF.Model
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=PUN-NB-LE3B6L9\MSSQLSERVER01;Initial Catalog=Employee;Integrated Security=True");
            base.OnConfiguring(optionsBuilder); 
        }

    }
}
