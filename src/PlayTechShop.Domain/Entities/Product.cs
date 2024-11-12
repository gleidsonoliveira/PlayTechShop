using PlayTechShop.Domain.Entities.Base;

namespace PlayTechShop.Domain.Entities;

public class Product : EntityBase
{
    public string Description { get; set; }=string.Empty;
    public DateTime ValidadeDoProduto { get; set; }

    //Preco
    public decimal Price { get; set; }

    // Quantidade disponível em estoque
    public int Quantity { get; set; }

    // Código único do produto
    public string ProductCode { get; set; } = string.Empty;

    //Expiracao do produto
    public DateTime ExpirationDate { get; set; }

    //Relacionamentocom a classe Suppliers
    public Suppliers SupplierId { get; set; }


}
