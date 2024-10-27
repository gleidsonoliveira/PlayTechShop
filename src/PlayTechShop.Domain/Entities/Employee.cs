using PlayTechShop.Domain.Entities.Base;

namespace PlayTechShop.Domain.Entities;

public class Employee : EntityBase
{
    public string Name { get; set; } = string.Empty;

    //Relacionamento
    public long CityId { get; set; }
    public City City { get; set; }
}
