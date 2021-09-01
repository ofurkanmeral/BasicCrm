using System;
using System.Collections.Generic;
using System.Text;

namespace CrmEntity
{
    public class notify
    {
        public int Id { get; set; }
        public string text { get; set; }
        public DateTime zaman { get; set; } = DateTime.Now;
        public int calisanId { get; set; }
        public calisan calisan { get; set; }
    }
}
