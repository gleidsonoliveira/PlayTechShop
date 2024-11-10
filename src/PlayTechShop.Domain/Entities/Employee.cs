using PlayTechShop.Domain.Entities.Base;

namespace PlayTechShop.Domain.Entities;

public class Employee : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public string Cpf { get; set; }

    /// <summary>
    /// data nascimento
    /// </summary>
    public DateTime DateBirth { get; set; }
    public string Address { get; set; }
    public string Number { get; set; }
    public string Complement { get; set; }
    public string Neighborhood { get; set; }
    public string ZipCode { get; set; }
    public string PhoneFirst { get; set; }
    public string PhoneSecond { get; set; }
    public string Email { get; set; }

    /// <summary>
    /// data de contratacao
    /// </summary>
    public string HireDate { get; set; }

    /// <summary>
    /// Cargo
    /// </summary>
    public string JobPosition { get; set; }

    //Relacionamento

    public virtual ICollection<Client> Clients { get; set; }
    public long CityId { get; set; }
    public City City { get; set; }
}
