namespace Microsoft.EntityFrameworkCore.AutoLoad.Usage
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class EntityMap : IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> builder)
        {
            builder.HasKey(c => c.Id);
        }
    }
}
