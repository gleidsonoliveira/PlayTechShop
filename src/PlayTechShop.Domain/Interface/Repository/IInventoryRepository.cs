using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace PlayTechShop.Domain.Interface.Repository
{
    public interface IInventoryRepository : IRepositoryBase<Inventory>
    {
        Task<ICollection<Inventory>> GetAllInventoryOfId(long InventoryId);
    }
}
