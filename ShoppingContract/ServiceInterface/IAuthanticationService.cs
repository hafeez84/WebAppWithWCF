﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ShoppingContract.ServiceInterface
{
   

    [ServiceContract]
    public interface IAuthanticationService
    {
        [OperationContract]
        void DoWork();
    }
}