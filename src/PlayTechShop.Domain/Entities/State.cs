using PlayTechShop.Domain.Entities.Base;

namespace PlayTechShop.Domain.Entities;
/// <summary>
/// Estado
/// </summary>
public class State : EntityBase
{
    public string Name { get; set; }
    public string Uf { get; set; }

    public virtual ICollection<City> Cities { get; set; }
}
