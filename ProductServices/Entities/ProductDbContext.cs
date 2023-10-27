using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using ProductServices.ViewModel;
using System;

namespace ProductServices.Entities
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> dbContextOptions) : base(dbContextOptions)
        {
            try {
                var createDatabase = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (createDatabase != null) {
                    if (!createDatabase.CanConnect())
                    {
                        createDatabase.Create();
                    }
                    if (!createDatabase.HasTables())
                    {
                        createDatabase.CreateTables();
                    }
                }
            }
            catch(Exception ex) { 
                throw new Exception(ex.Message, ex);
            }
        }

        public DbSet<ProductViewModel> Products { get; set; }
    }
}
