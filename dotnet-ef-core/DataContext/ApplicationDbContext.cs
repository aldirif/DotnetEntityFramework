using System;
using System.Security.Policy;

namespace dotnet_ef_core.DataContext
{
	public class ApplicationDbContext : DbContext
    {
		// injection
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			
		}
		public DbSet<CategoryEntity> CategoryEntities => Set<CategoryEntity>();
		public DbSet<AbsensiEntity> AbsensiEntities=> Set<AbsensiEntity>();
        public DbSet<CustomerEntity> CustomerEntities => Set<CustomerEntity>();
        public DbSet<EmployeeEntity> EmployeeEntities => Set<EmployeeEntity>();

    }
}

