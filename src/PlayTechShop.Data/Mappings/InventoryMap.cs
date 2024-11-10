using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayTechShop.Domain.Entities;

namespace PlayTechShop.Data.Mappings; 
    public class InventoryMap : IEntityTypeConfiguration<Inventory> {
        public void Configure(EntityTypeBuilder<Inventory> builder) {

        builder.ToTable("Inventory");

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

        builder.Property(u => u.Description).HasMaxLength(50).IsRequired();

        builder.Property(u => u.Weight).HasMaxLength(10);

        builder.Property(u => u.QuantityOfPieces).HasMaxLength(5).IsRequired();

        builder.Property(u => u.MaximumQuantity).HasMaxLength(5).IsRequired();

        builder.Property(u => u.MinimumQuantity).HasMaxLength(5).IsRequired();

        builder.Property(u => u.CurrentQuantity).HasMaxLength(5).IsRequired();

        builder.Property(u => u.Category).HasMaxLength(10).IsRequired();

        builder.Property(u => u.Status).HasMaxLength(8).IsRequired();

        builder.Property(u => u.Observation).HasMaxLength(10);

        builder.Property(u => u.EntryDate).IsRequired();


    }
}

