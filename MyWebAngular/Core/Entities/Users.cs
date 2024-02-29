using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MyWebAngular.Core.Entities
{
    public class Users : IdentityUser
    {
        public string DisplayName { get; set; }
        public Address Address { get; set; }
    }
}
