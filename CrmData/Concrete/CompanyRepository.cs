using CrmData.Abstract;
using CrmEntity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmData.Concrete
{
    public class CompanyRepository : GenericRepository<Company, DataContext>, ICompanyRepository
    {
        public List<Company> CategoryListesi(string category)
        {
            using (var context = new DataContext())
            {
                if (string.IsNullOrEmpty(category))
                {
                    return context.Companies.ToList();
                }
                else
                {
                    var company = context.Companies

                 .Include(x => x.CompanyCategories)
                 .ThenInclude(x => x.Category)
                 .Where(x => x.CompanyCategories.Any(a => a.Category.tür.ToLower() == category.ToLower()));


                    return company.ToList();
                }
            
            }
            //   if (!string.IsNullOrEmpty(category))
            //    {
            //        company
            //        .Include(x => x.CompanyCategories)
            //        .ThenInclude(x => x.Category)
            //        .Where(x => x.CompanyCategories.Any(a => a.Category.tür.ToLower() == category.ToLower()));
            //    }

            //   return company.ToList();
            //}
        }

        public Company DetayString(string name)
        {
            using (var context = new DataContext())
            {
                
                return context.Companies.Where(x => x.Name.ToUpper() == name.ToUpper()).FirstOrDefault();
                
            }
        }

        public Company getCalisan(string name)
        {
            using(var context=new DataContext())
            {
                return context.Companies
                    .Where(x => x.Name == name)
                    .Include(x => x.calisanlar)
                    .Include(x => x.notes)
                    .FirstOrDefault();
            }
        }

        public Company getCompanyByCategory(int id)
        {
            using (var context = new DataContext())
            {
                return context.Companies
                                .Where(x => x.Id == id)
                                .Include(x => x.CompanyCategories)
                                .ThenInclude(x => x.Category)
                                .FirstOrDefault();
            }
        }

        public Company getCompanyNote(int companyId)
        {
            using (var db = new DataContext())
            {
                return db.Companies
                    .Where(x => x.Id == companyId)
                    .Include(x => x.notes)

                    .FirstOrDefault();
            }
        }

        public List<Company> Search(string q)
        {
            using (var context = new DataContext())
            {
                return context.Companies.Where(x => x.Name.ToLower().Contains(q.ToLower())||x.Adress.ToLower().Contains(q.ToLower())).ToList();
            }
        }
    }
}
