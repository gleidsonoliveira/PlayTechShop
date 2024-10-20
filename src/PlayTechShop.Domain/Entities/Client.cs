
using PlayTechShop.Domain.Entities.Base;
using PlayTechShop.Domain.Enum;

namespace PlayTechShop.Domain.Entities;
/// <summary>
/// Clientes
/// </summary>
public class Client : EntityBase
{
    public long CityId { get; set; }
    public City City { get; set; }
}
