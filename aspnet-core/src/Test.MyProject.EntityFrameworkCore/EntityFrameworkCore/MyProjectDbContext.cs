using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Test.MyProject.Authorization.Roles;
using Test.MyProject.Authorization.Users;
using Test.MyProject.MultiTenancy;
using Test.MyProject.Products;

namespace Test.MyProject.EntityFrameworkCore
{
    public class MyProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjectDbContext>
    {
        public DbSet<Product> Products { get; set; }
        /* Define a DbSet for each entity of the application */
        
        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options)
            : base(options)
        {
        }
    }
}
