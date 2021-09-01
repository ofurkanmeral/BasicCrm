using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmWebUi.Identity
{
    public class RoleModel
    {
        public string Name { get; set; }
    }
    public class roleDetail
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<IdentityUser> Members { get; set; }
        public IEnumerable<IdentityUser> nonMembers { get; set; }
    }
}
