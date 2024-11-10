using PlayTechShop.Data.Context;
using PlayTechShop.Data.Repository.Base;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Repository;

namespace PlayTechShop.Data.Repository;
public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
{
    public CompanyRepository(PlayTechContext pPlayTechContext) : base(pPlayTechContext)
    {
    }

    public Task<ICollection<Company>> GetAllCompanyofId(long CompanyId)
    {
        throw new NotImplementedException();
    }
}
