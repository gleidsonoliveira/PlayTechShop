using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayTechShop.Domain.Entities;

namespace PlayTechShop.Data.Mappings;
public class StateMap : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.ToTable("State");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Uf).IsRequired().HasMaxLength(2);

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

        builder.HasMany(c => c.Cities).WithOne(c => c.State).HasForeignKey(c => c.StateId);
    }
}
