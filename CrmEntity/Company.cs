using System;
using System.Collections.Generic;
using System.Text;

namespace CrmEntity
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string picture { get; set; }
        public string Adress { get; set; }
        public string Number { get; set; }

        public List<calisan> calisanlar { get; set; } 
        public Muhasebe muhasebe { get; set; }
        
        public List<Note> notes { get; set; }
        public customer customer { get; set; }
        public List<CompanyCategory> CompanyCategories { get; set; }
    }
}
