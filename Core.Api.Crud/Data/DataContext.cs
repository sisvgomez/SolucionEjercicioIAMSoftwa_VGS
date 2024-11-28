using Core.Api.Crud.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Api.Crud.Data
{
    public class DataContext:DbContext
    {
        protected readonly IConfiguration configuration;

        public DataContext(IConfiguration _configuration)
        {
            configuration = _configuration;


        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(configuration.GetConnectionString("ConexApiDatabase"));
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
