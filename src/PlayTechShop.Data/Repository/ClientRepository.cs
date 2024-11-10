using PlayTechShop.Data.Context;
using PlayTechShop.Data.Repository.Base;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Repository;

namespace PlayTechShop.Data.Repository;
public class ClientRepository : BaseRepository<Client>, IClientRepository
{
    public ClientRepository(PlayTechContext pPlayTechContext) : base(pPlayTechContext)
    {
    }
}
