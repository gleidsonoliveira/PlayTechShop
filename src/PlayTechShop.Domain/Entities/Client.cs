
using PlayTechShop.Domain.Entities.Base;
using PlayTechShop.Domain.Enum;

namespace PlayTechShop.Domain.Entities;
/// <summary>
/// Clientes
/// </summary>
public class Client : EntityBase
{
    public string Name { get; set; }
    public string Cpf { get; set; }
    public string Address { get; set; }
    public string Number { get; set; }
    public string Complement { get; set; }
    public string ZipCode { get; set; }
    public string PhoneFirst { get; set; }
    public string Email { get; set; }

    //Relacionamento
    public long CityId { get; set; }
    public City City { get; set; }
}
