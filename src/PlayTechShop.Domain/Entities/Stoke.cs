using PlayTechShop.Domain.Entities.Base;

namespace PlayTechShop.Domain.Entities;

/// <summary>
/// Estoque
/// </summary>
public class Stoke : EntityBase
{
    public string Description { get; set; }
    /// <summary>
    /// Peso
    /// </summary>
    public decimal Weight { get; set; }
    /// <summary>
    /// Quantidade de Peças
    /// </summary>
    public int QuantityOfPieces { get; set; }
    /// <summary>
    /// Quantidade Minima
    /// </summary>
    public int MinimumQuantity { get; set; }
    /// <summary>
    /// Quantidade Maxima
    /// </summary>
    public int MaximumQuantity { get; set; }
    /// <summary>
    /// Quantidade Atual
    /// </summary>
    public int CurrentQuantity { get; set; }
    /// <summary>
    /// Data Entrada
    /// </summary>
    public DateTime EntryDate { get; set; }
    public string Category { get; set; }
    public string Status { get; set; }
    public string Observation { get; set; }

    //Relacionamento futuro
    //public Produto IdProduto { get; set; }
}
