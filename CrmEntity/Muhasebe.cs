using System;
using System.Collections.Generic;
using System.Text;

namespace CrmEntity
{
    public class Muhasebe
    {
        public int Id { get; set; }
        public int alacak { get; set; }
        public int verecek { get; set; }

        public int companyId { get; set; }
        public Company Company { get; set; }
    }
}
