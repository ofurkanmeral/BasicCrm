using System;
using System.Collections.Generic;
using System.Text;

namespace CrmEntity
{
    public class Gorev
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Zaman { get; set; } = DateTime.Now;
        public int calisanId { get; set; }
        public calisan calisan { get; set; } 
        
    }
}
