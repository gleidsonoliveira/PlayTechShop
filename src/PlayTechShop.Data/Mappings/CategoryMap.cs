using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayTechShop.Domain.Entities;

namespace PlayTechShop.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            #region Default
            builder.Property(u => u.DateCreated);
            builder.Property(u => u.UserIdCreated).HasMaxLength(50);

            builder.Property(u => u.DateModified);
            builder.Property(u => u.UserIdModified).HasMaxLength(50);

            builder.Property(u => u.DateDeleted);
            builder.Property(u => u.UserIdDeleted).HasMaxLength(50);

            //Enum
            builder.Property(u => u.Situation).IsRequired().HasDefaultValueSql("1");
            #endregion

            builder.Property(c => c.Description).HasMaxLength(100).IsRequired();

            //Relacionamento
            builder.HasMany(c => c.Products).WithOne(p => p.Category).HasForeignKey(c => c.CategoryId);
        }
    }
}