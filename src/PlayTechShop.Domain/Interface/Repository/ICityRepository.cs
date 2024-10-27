using PlayTechShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTechShop.Domain.Interface.Repository;
public interface ICityRepository
{
    Task<ICollection<City>> GetAllCities();
}
