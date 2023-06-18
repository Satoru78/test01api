using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using test01api.Models;
using test01api.Models.Dto.Requests;
using test01api.Models.Dto.Responses;

namespace test01api.Controllers
{
    public class UsersController : ApiController
    {
        private dbStirkaEntities db = new dbStirkaEntities();

        // GET: api/Users
        public IEnumerable<UserInfoDto> GetUser()
        {
            return db.User.ToList().Select(item => new UserInfoDto(item)).ToList();
        }

        // GET: api/Users/5

        public IHttpActionResult GetUser(int id)
        {
            var users = db.User.ToList().Select(item => new UserInfoDto(item)).ToList();
            var user = users.Find(item => item.ID == id);
            if (user == null)
            {
                return Ok(new ResponseErrorDto() { Error = "Пользователя не сущетсвует" });
            }

            return Ok(user);
        }

        [HttpPost]
        public IHttpActionResult AddUser(UserAddDto userDto)
        {
            User user = new User
            {

                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Patronymic = userDto.Patronymic,
                Login = userDto.Login,
                Password = userDto.Password,
                IDRole = userDto.IDRole,
            };
            db.User.Add(user);
            db.SaveChanges();
            return CreatedAtRoute(nameof(GetUser), user.ID, user);
        }
    }
}