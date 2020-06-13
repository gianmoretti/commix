namespace Commix.Databases
{
    using System.Data.Entity;

    public partial class GeneralModel : DbContext
    {
        public GeneralModel()
            : base("name=ReportModel")
        {
        }

        public virtual DbSet<LocalTestTable> LocalTestTables { get; set; }
        public virtual DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocalTestTable>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<LocalTestTable>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Report>()
                .Property(e => e.stato)
                .IsUnicode(false);
        }
    }
}
