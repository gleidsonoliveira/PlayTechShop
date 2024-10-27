using PlayTechShop.Data.Context;
using PlayTechShop.Data.Repository.Base;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Repository;

namespace PlayTechShop.Data.Repository;
public class CityRepository : BaseRepository<City>, ICityRepository
{
    public CityRepository(PlayTechContext pPlayTechContext) : base(pPlayTechContext)
    {
    }

    public Task<ICollection<City>> GetAllCitiesofStateId(long StateId)
    {
        throw new NotImplementedException();
    }
}
