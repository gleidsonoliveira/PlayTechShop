using PlayTechShop.Data.Context;
using PlayTechShop.Data.Repository.Base;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Repository;

namespace PlayTechShop.Data.Repository;
public class StokeRepository : BaseRepository<Stoke>, IStokeRepository
{
    public StokeRepository(PlayTechContext pPlayTechContext) : base(pPlayTechContext)
    {
    }

    public Task<ICollection<Stoke>> GetAllStokeOfId(long StokeId)
    {
        throw new NotImplementedException();
    }
}
