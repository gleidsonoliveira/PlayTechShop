using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Service.Base;

namespace PlayTechShop.Domain.Interface.Service;
public interface ICityService : IServiceBase<City>
{
    Task<ICollection<City>> GetAllCitiesofStateId(long StateId);
}
