using CrmEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmData.Abstract
{
    public interface ICompanyRepository:IRepository<Company>
    {
        Company getCompanyNote(int companyId);
        Company getCompanyByCategory(int id);
        List<Company> CategoryListesi(string category);
        Company DetayString(string name);
        List<Company> Search(string q);
        Company getCalisan(string name);
    }
}
