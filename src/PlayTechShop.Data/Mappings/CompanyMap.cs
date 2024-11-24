using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayTechShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTechShop.Data.Mappings;
public class CompanyMap : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
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
        builder.ToTable("Company");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
        builder.Property(u => u.ReasonSocial).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Cnpj).IsRequired().HasMaxLength(18);
        builder.Property(u => u.Address).IsRequired().HasMaxLength(60);
        builder.Property(u => u.AddressNeighborhood).IsRequired().HasMaxLength(60);
        builder.Property(u => u.AdressNumber).HasMaxLength(8);
        builder.Property(u => u.AddressComplement).HasMaxLength(60);
        builder.Property(u => u.AddressZipCode).HasMaxLength(9).IsRequired();
        builder.Property(u => u.CellPhone).HasMaxLength(14).IsRequired();
        builder.Property(u => u.Telephone).HasMaxLength(14);
        builder.Property(u => u.Email).HasMaxLength(80);
        builder.Property(u => u.StateRegistration).HasMaxLength(15);
        builder.Property(u => u.LegalResponsible).HasMaxLength(15);
        builder.Property(u => u.NumberOfEmployees).IsRequired();
        builder.Property(u => u.Observation).HasMaxLength(2000);


    }
}

