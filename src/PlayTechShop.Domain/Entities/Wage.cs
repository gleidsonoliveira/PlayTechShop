using PlayTechShop.Domain.Entities.Base;
using PlayTechShop.Domain.Enum;

namespace PlayTechShop.Domain.Entities;

public class Wage : EntityBase
{
    /// <summary>
    /// Salário Líquido
    /// </summary>
    public double NetSalary { get; set; }
    /// <summary>
    /// Desconto
    /// </summary>
    public double Discount { get; set; }
    /// <summary>
    /// Salario Bruto
    /// </summary>
    public double GrossSalary { get; set; }

    /// <summary>
    /// Relacionamento entre Wage e Employee
    /// </summary>
    public long EmployeeId { get; set; }
    public Employee Employee { get; set; }
}