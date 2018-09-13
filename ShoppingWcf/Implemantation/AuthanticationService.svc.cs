using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShoppingContract.Datacontract;
using ShoppingContract.Ef;
using ShoppingContract.ServiceInterface;
using ShoppingWcf.Business;

namespace ShoppingWcf.Implemantation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthanticationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuthanticationService.svc or AuthanticationService.svc.cs at the Solution Explorer and start debugging.
    public class AuthanticationService : IAuthanticationService
    {
        public void DoWork()
        {
           
        }

        public User GetUserByloginNamePassword(string loginName, string password)
        {

            BsAuthanticaion bsaut = new BsAuthanticaion();
            return bsaut.GetUserByloginNamePassword(loginName, password);
        }

        public void SaveUser(UserContract userData)
        {

            try
            {
                
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
