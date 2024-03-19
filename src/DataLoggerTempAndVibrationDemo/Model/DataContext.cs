using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataLoggerTempAndVibrationDemo.Model
{
    public class DataContext : DbContext
    {
        [NotMapped]
        public DbSet<MasterData> masterDatas { set; get; }
        private const string connectionString = @"Data Source=LAPTOP-T9451PPV\MSSQLSERVER01;
                                                Initial Catalog=EFDBDataLogger01;
                                                Integrated Security=True;
                                                Encrypt=True;
                                                TrustServerCertificate=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
