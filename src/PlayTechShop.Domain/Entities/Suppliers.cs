using PlayTechShop.Domain.Entities.Base;

namespace PlayTechShop.Domain.Entities;

public class Suppliers : EntityBase
{
    public string Nome { get; set; }

    // Endereço do fornecedor
    public string Address { get; set; } = string.Empty;

    // Telefone de contato do fornecedor
    public string ContactNumber { get; set; } = string.Empty;

    // E-mail de contato do fornecedor
    public string Email { get; set; } = string.Empty;

    // Pessoa de contato principal do fornecedor
    public string ContactPerson { get; set; } = string.Empty;


    // Relacionamente com a classe Product
    public virtual ICollection<Product> Products { get; set; }
}

