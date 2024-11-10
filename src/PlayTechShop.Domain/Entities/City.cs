using PlayTechShop.Domain.Entities.Base;

namespace PlayTechShop.Domain.Entities;

/// <summary>
/// Cidades
/// </summary>
public class City : EntityBase
{
    public string Name { get; set; }
    public string CodeCity { get; set; }

    //Relacionamento.
    public virtual ICollection<Client> Clients { get; set; }
    public virtual ICollection<Company> Companies { get; set; }
    public virtual ICollection<Employee> Employees { get; set; }

    public long StateId { get; set; }
    public State State { get; set; }
}
