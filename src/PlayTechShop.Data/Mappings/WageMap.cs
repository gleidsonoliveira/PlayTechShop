using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayTechShop.Domain.Entities;

namespace PlayTechShop.Data.Mappings;
public class WageMap : IEntityTypeConfiguration<Wage> {
    public void Configure(EntityTypeBuilder<Wage> builder) {

        builder.ToTable("Wage");

        #region Default

        builder.Property(u => u.DateCreated);
        builder.Property(u => u.UserIdCreated).HasMaxLength(50);

        builder.Property(u => u.DateModified);
        builder.Property(u => u.UserIdModified).HasMaxLength(50);

        builder.Property(u => u.DateDeleted);
        builder.Property(u => u.UserIdDeleted).HasMaxLength(50);

        //Enum
        builder.Property(u => u.Situation).IsRequired().HasDefaultValueSql("0");

        #endregion Default

        builder.Property(u => u.NetSalary).IsRequired();

        builder.Property(u => u.Discount);

        builder.Property(u => u.GrossSalary).IsRequired();
    }
}