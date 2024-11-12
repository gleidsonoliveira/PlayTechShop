using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayTechShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTechShop.Data.Mappings;
public class StokeMap : IEntityTypeConfiguration<Inventory>
{
    public void Configure(EntityTypeBuilder<Inventory> builder)
    {
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

        builder.ToTable("Inventory");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Description).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Weight).IsRequired().HasMaxLength(20);
        builder.Property(u => u.QuantityOfPieces).IsRequired().HasMaxLength(20);
        builder.Property(u => u.MinimumQuantity).IsRequired().HasMaxLength(20);
        builder.Property(u => u.MaximumQuantity).IsRequired().HasMaxLength(20);
        builder.Property(u => u.CurrentQuantity).IsRequired().HasMaxLength(20);
        builder.Property(u => u.Category).IsRequired().HasMaxLength(15);
        builder.Property(u => u.Status).IsRequired().HasMaxLength(15);
        builder.Property(u => u.Observation).HasMaxLength(100);

    }
}
