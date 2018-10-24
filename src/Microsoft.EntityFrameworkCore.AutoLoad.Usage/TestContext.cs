namespace Microsoft.EntityFrameworkCore.AutoLoad.Usage
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddFromAssembly(typeof(TestContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
