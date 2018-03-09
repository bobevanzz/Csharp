using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeWebApiProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base() { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Customer> Customers { get; set; }
    //    public DbSet<Order> Orders { get; set; }
    }
}