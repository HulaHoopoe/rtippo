using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsList
{
    internal class User
    {
        private int userID;
        private string login;
        private string password;
        public Role roleUser;
        public Organization organization;

        User()
        {
        }

        public User Authorization()
        {
            return this;
        }
    }

    internal class Role
    {
        private int roleID;
        public string roleName;

        public Role() { }
    }
}

