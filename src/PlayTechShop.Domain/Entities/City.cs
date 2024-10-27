using PlayTechShop.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    public long StateId { get; set; }
    public State State { get; set; }
}
