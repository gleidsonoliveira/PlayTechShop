using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayTechShop.Domain.Entities;

namespace PlayTechShop.Data.Mappings {
    public class ClientMap : IEntityTypeConfiguration<Client> {
        public void Configure(EntityTypeBuilder<Client> builder) {
            builder.ToTable("Client");

            builder.HasKey(u => u.Id);

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

            builder.Property(u => u.Cpf).HasMaxLength(18).IsRequired();

            builder.Property(u => u.Address).HasMaxLength(50).IsRequired();

            builder.Property(u => u.Number).HasMaxLength(5).IsRequired();

            builder.Property(u => u.Complement).HasMaxLength(20);

            builder.Property(u => u.ZipCode).HasMaxLength(9).IsRequired();

            builder.Property(u => u.PhoneFirst).HasMaxLength(14).IsRequired();

            builder.Property(u => u.Email).HasMaxLength(320).IsRequired();

            //Relacionamento| Uma Cidade pode ter varios clientes, numero do ID da cidade
            builder.HasOne(o => o.City).WithMany(c => c.Clients).HasForeignKey(c => c.CityId);

        }
    }
}
