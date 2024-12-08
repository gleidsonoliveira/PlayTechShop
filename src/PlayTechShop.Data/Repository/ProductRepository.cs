using PlayTechShop.Data.Context;
using PlayTechShop.Data.Repository.Base;
using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Repository;

namespace PlayTechShop.Data.Repository;
public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    public ProductRepository(PlayTechContext pPlayTechContext) : base(pPlayTechContext)
    {
    }
}