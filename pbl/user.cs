using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl
{
    public class user
    {
        private string username { get; set; }
        private string password { get; set; }
        public user() { }
        public user(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public Boolean IsEqual(user person)
        {
            if(username == person.username && password == person.password)
            {
                return true;
            }
            return false;
        }
    }
}
