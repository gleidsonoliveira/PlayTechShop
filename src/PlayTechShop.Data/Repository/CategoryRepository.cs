using PlayTechShop.Data.Context;
using PlayTechShop.Data.Repository.Base;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Repository;

namespace PlayTechShop.Data.Repository;
public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(PlayTechContext pPlayTechContext) : base(pPlayTechContext)
    {
    }
}