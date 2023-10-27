using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class UserModelcs
    {
        Userdao userDao = new Userdao();

        public bool LoginUser(string user, string pass)
        {
            return userDao.loguin( user,  pass);
        }
    }

    
}
