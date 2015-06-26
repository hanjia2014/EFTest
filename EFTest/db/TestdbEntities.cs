namespace EFTest.db
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class TestdbEntities : DbContext
    {
        public TestdbEntities()
            : base("name=testdbEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Child> Children { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
    }
}