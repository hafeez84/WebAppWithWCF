using ShoppingContract.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingWcf.Business
{
    public class BsAuthanticaion
    {

        public User GetUserByloginNamePassword(string loginName, string password)
        {

            ShoppingData.MyDBEntities1 myDBEntities1 = new ShoppingData.MyDBEntities1();
            User oUser= myDBEntities1.Users.Where(x => x.Lname == loginName && x.Password == password).FirstOrDefault();

            if (oUser == null)
                throw new ApplicationException("kullanıcı bilgileri eksik veya hatalı");

            return oUser;
        }
    }
}