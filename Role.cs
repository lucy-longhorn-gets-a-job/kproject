using System;
using System.Collections.Generic;

namespace sp19team5project.Models
{
    public class Role
    {
        public Int32 RoleID { get; set; }
        public String RoleName { get; set; }

        List<AppUser> AppUsers;
    }
}
