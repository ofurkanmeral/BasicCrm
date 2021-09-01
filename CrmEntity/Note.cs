using System;
using System.Collections.Generic;
using System.Text;

namespace CrmEntity
{
    public class Note
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int companyId { get; set; }
        public Company company { get; set; }
    }
}
