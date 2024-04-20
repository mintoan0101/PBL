using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl
{
    public class List_User
    {
        private List<user> ds_user;
        public List_User( )
        {
            ds_user = new List<user>();
        }
        public void AddUser(user x)
        {
            ds_user.Add( x );
        }
        public Boolean IsUserExist(user person)
        {
           foreach(user x in ds_user)
            {
                if(x.IsEqual(person)) return true;
            }
            return false;
        }
    }
}
