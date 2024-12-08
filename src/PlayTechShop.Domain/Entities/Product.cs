using PlayTechShop.Domain.Entities.Base;

namespace PlayTechShop.Domain.Entities;
/// <summary>
/// Entidate Produto
/// </summary>
public class Product : EntityBase
{
    //Todo - Adicionar novas propriedades na entidade produto.
    public string Description { get; set; }
    public decimal Price { get; set; }

    //relacionamento
    public long CategoryId { get; set; }
    public virtual Category Category { get; set; }
}