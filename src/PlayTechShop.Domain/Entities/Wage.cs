using PlayTechShop.Domain.Entities.Base;

namespace PlayTechShop.Domain.Entities;
/// <summary>
/// Salário Líquido
/// </summary>
public class Wage : EntityBase
{
    public decimal NetSalary { get; set; }
    /// <summary>
    /// Desconto
    /// </summary>
    public decimal Discount { get; set; }
    /// <summary>
    /// Salario Bruto
    /// </summary>
    public decimal GrossSalary { get; set; }

    /// <summary>
    /// Relacionamento entre Wage e Employee
    /// </summary>
    public long EmployeeId { get; set; }
    public Employee Employee { get; set; }
}