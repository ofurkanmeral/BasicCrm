using CrmEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmWebUi.Models
{
    public class CompanyList
    {
        public List<Company> Companies { get; set; }
        public List<Category> Categories { get; set; }
        public List<notify> notifies { get; set; }
    }
}
