using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayTechShop.Domain.Entities;

namespace PlayTechShop.Data.Mappings;
public class CompanyMap : IEntityTypeConfiguration<Company> {
    public void Configure(EntityTypeBuilder<Company> builder) {

        builder.ToTable("Company");

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

        builder.Property(u => u.ReasonSocial).HasMaxLength(50).IsRequired();

        builder.Property(u => u.Cnpj).HasMaxLength(18).IsRequired();

        builder.Property(u => u.Adress).HasMaxLength(50).IsRequired();  

        builder.Property(u => u.AdressNeighborhood).HasMaxLength(50);
        
        builder.Property(u => u.AdressNumber).HasMaxLength(5).IsRequired();

        builder.Property(u => u.Complement).HasMaxLength(10);

        builder.Property(u => u.Telephone).HasMaxLength(15);

        builder.Property(u => u.CellPhone).HasMaxLength(15).IsRequired();

        builder.Property(u => u.Email).HasMaxLength(80).IsRequired();

        builder.Property(u => u.StateRegistration).HasMaxLength(50);

        builder.Property(u => u.LegalResponsible).HasMaxLength(10).IsRequired();

        builder.Property(u => u.NumberOfEmployees).HasMaxLength(5).IsRequired();

        builder.Property(u => u.Observation).HasMaxLength(100);

        //Relacionamento
        builder.HasOne(o => o.City).WithMany(c => c.Companies).HasForeignKey(c => c.CityId);


    }
}

