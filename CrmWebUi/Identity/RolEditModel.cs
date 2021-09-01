using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmWebUi.Identity
{
    public class RolEditModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }
}
