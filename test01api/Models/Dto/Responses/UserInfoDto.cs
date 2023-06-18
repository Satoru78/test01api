using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test01api.Models.Dto.Responses
{
    public class UserInfoDto
    {
        public UserInfoDto(User user)
        {
            ID = user.ID;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Patronymic = user.Patronymic;
            Login = user.Login;
            Password = user.Password;
            IDRole = user.IDRole;

        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int IDRole { get; set; }
    }
}