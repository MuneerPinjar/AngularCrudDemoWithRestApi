using AngularCrudDemoWithRestApi.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AngularCrudDemoWithRestApi.Repository
{
    public class APIDbContext : DbContext
    {

        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }
        public DbSet<Department> Departments
        {
            get;
            set;
        }
        public DbSet<Employee> Employees
        {
            get;
            set;
        }
    }
}
