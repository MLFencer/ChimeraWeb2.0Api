using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChimeraApi.Models
{
    public class Login
    {
        public string UserOrEmail { get; set; }
        public string PasswordAsBase64 { get; set; }
    }
}
