using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoMigrations.Api.Db.Entities;

namespace TodoMigrations.Api.Db.Mappings
{
    public class TodosMap : IEntityTypeConfiguration<Todos>
    {
        public void Configure(EntityTypeBuilder<Todos> builder)
        {
            builder.ToTable("TodosTable");

            builder.HasKey(c => c.Id);
            builder.Property(c=> c.Description).HasMaxLength(150).IsRequired();
        }
    }
}
