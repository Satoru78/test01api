using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test01api.Models.Dto.Requests
{
    public class AuthUserDto
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}