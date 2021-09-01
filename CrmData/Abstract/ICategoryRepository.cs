using CrmEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmData.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Category CategoryByCompany(int categoryId);
    }
}
