using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CalculatorApi
{
    public partial class CalcDBModel : DbContext
    {
        public CalcDBModel()
            : base("name=CalcDBModel")
        {
        }

        public virtual DbSet<CalcTable> CalcTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CalcTable>()
                .Property(e => e.LoggingString)
                .IsUnicode(false);
        }
    }
}
