using System;
using System.Collections.Generic;
using System.Text;

namespace CrmEntity
{
    public class Category
    {
        public int Id { get; set; }
        public string tür { get; set; }
        public List<CompanyCategory> CompanyCategories { get; set; }

    }
}
