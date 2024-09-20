
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

using BaseLibrary.Entities;

namespace ServerLibrary.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> employees { get; set; }
        public DbSet<GeneralDepartment> generalDepartments { get; set; }   
        public DbSet<Department> departments { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<Town> towns { get; set; }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<SystemRole> systemRoles { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
        public DbSet<RefreshTokenInfo> refreshTokenInfos { get; set; }
    }
}
