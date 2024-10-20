using PlayTechShop.Domain.Enum;

namespace PlayTechShop.Domain.Entities.Base;
public class EntityBase
{
    public long Id { get; set; }
    public Situation Situation { get; set; } = Situation.Active;
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public string UserIdCreated { get; set; } = string.Empty;
    public DateTime? DateModified { get; set; }
    public string UserIdModified { get; set; } = string.Empty;
    public DateTime? DateDeleted { get; set; }
    public string UserIdDeleted { get; set; } = string.Empty;

}
