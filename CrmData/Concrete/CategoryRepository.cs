using CrmData.Abstract;
using CrmEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrmData.Concrete
{
    public class CategoryRepository : GenericRepository<Category, DataContext>, ICategoryRepository
    {
        public Category CategoryByCompany(int categoryId)
        {
            using (var context = new DataContext())
            {
                return context.categories
                                    .Where(x => x.Id == categoryId)
                                    .Include(x => x.CompanyCategories)
                                    .ThenInclude(x => x.Company)
                                    .FirstOrDefault();
            }
        }
    }
}
