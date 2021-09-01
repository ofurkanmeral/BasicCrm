using System;
using System.Collections.Generic;
using System.Text;

namespace CrmEntity
{
    public class customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int companyId { get; set; }
        public Company company { get; set; }
        
    }
}
