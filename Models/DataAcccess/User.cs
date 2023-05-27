using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterlySales.Models.DataAcccess
{
    public class User : IdentityUser
    {
        [NotMapped]
        public IList<string> UserRoles { get; set; }
    }
}
