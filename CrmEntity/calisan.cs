using System;
using System.Collections.Generic;
using System.Text;

namespace CrmEntity
{
    public class calisan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Soyad { get; set; }
        public string Prim { get; set; }
        public string picture { get; set; }
        public DateTime iseGiris { get; set; } = DateTime.Now;
        public string Kanun { get; set; }
        public int companyId { get; set; }
        public Company company { get; set; }
        public List<Gorev> Gorev { get; set; }
        public notify Notify { get; set; }
       
        

    }
}
