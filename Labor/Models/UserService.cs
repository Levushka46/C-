using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UserService
    {
        public List<User> Users = new List<User>
        {
            new User {login="Levushka", password="qwerty", fullname="Lev", birthday="09/08/2000"},
            new User {login="Lelik", password="qwerty1234", fullname="Elena", birthday="15/06/2000"},
            new User {login="Olegik", password="qweasdzxc", fullname="Oleg", birthday="28/04/1992"}
        };
        public bool F = false;
        public bool CheckCredentials(string login, string password)
        {
            bool F = Users.Any(u=>u.login==login && u.password==password);
            return F;
        }
    }
}
