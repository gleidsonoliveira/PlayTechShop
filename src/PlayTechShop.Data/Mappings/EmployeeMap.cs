using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayTechShop.Domain.Entities;

namespace PlayTechShop.Data.Mappings;
public class EmployeeMap : IEntityTypeConfiguration<Employee> {
    public void Configure(EntityTypeBuilder<Employee> builder) {

        builder.ToTable("Employee");

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

        builder.Property(u => u.Name).HasMaxLength(50).IsRequired();

        builder.Property(u => u.Cpf).HasMaxLength(11).IsRequired();

        builder.Property(u => u.DateBirth).IsRequired();

        builder.Property(u => u.Address).HasMaxLength(50).IsRequired();

        builder.Property(u => u.Number).HasMaxLength(4).IsRequired();

        builder.Property(u => u.Complement).HasMaxLength(20).IsRequired();

        builder.Property(u => u.Neighborhood).HasMaxLength(20).IsRequired();

        builder.Property(u => u.ZipCode).HasMaxLength(9).IsRequired();

        builder.Property(u => u.PhoneFirst).HasMaxLength(14).IsRequired();

        builder.Property(u => u.PhoneSecond).HasMaxLength(14).IsRequired();

        builder.Property(u => u.Email).HasMaxLength(100).IsRequired();

        builder.Property(u => u.HireDate).HasMaxLength(8).IsRequired();

        builder.Property(u => u.JobPosition).HasMaxLength(15).IsRequired();

        builder.Property(u => u.Neighborhood).HasMaxLength(20).IsRequired();

        //Relacionamento

        builder.HasOne(o => o.City).WithMany(c => c.Employees).HasForeignKey(c => c.CityId);


    }
}

