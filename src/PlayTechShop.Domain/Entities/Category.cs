using PlayTechShop.Domain.Entities.Base;

namespace PlayTechShop.Domain.Entities;

/// <summary>
/// Entidade Categoria
/// </summary>
public class Category : EntityBase
{
    public string Description { get; set; }
    public virtual ICollection<Product> Products { get; set; }
    //public virtual ICollection<SubCategory> SubCategories { get; set; }
}
