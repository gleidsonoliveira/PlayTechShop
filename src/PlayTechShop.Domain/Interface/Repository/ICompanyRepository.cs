﻿using PlayTechShop.Domain.Entities;
using PlayTechShop.Domain.Interface.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTechShop.Domain.Interface.Repository
{
    public interface ICompanyRepository : IRepositoryBase<Company>
    {
        Task<ICollection<Company>> GetAllCompanyofId(long CompanyId);
    }
}
