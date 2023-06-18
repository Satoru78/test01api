using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test01api.Models.Dto.Requests
{
    public class UserAddDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int IDRole { get; set; }
    }
}