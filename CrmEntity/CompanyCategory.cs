using System;
using System.Collections.Generic;
using System.Text;

namespace CrmEntity
{
    public class CompanyCategory
    {
        public int companyId { get; set; }
        public Company Company { get; set; }
        public int categoryId { get; set; }
        public Category Category { get; set; }
    }
}
