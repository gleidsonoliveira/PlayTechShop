using PlayTechShop.Data.Context;
using PlayTechShop.Data.Repository.Base;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Repository;

namespace PlayTechShop.Data.Repository;
public class InventoryRepository : BaseRepository<Inventory>, IInventoryRepository
{
    public InventoryRepository(PlayTechContext pPlayTechContext) : base(pPlayTechContext)
    {
    }

    public Task<ICollection<Inventory>> GetAllInventoryOfId(long InventoryId)
    {
        throw new NotImplementedException();
    }
}
