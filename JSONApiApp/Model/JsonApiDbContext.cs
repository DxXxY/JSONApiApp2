using JSONApiApp.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace JSONApiApp.Model
{
    public class JsonApiDbContext:DbContext
    {
        public DbSet<KnowHost> KnowHosts { get; set; }
        public DbSet<Request> MyRequests { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // получаем файл конфигурации
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            // устанавливаем для контекста строку подключения

            optionsBuilder.UseNpgsql(configuration.GetConnectionString("CloudDbConnectionString"));
        }
    }
}
