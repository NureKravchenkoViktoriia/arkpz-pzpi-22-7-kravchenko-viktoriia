using System.Collections.Generic;
using System.Data.Entity;
using AquaTrack.Data.Models;

namespace AquaTrack.Data
{
    public class AppDbContext : DbContext
    {
        // Конструктор з підключенням до бази даних
        public AppDbContext() : base("name=DefaultConnection")
        {
        }

        // Таблиці
        public DbSet<User> Users { get; set; }
        public DbSet<IoTDevice> IoTDevices { get; set; }
        public DbSet<Limit> Limits { get; set; }
        public DbSet<WaterUsage> WaterUsages { get; set; }
    }
}
