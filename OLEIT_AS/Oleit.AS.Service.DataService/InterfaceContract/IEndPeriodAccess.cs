﻿using System;
using Oleit.AS.Service.DataObject;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Oleit.AS.Service.DataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEndPeriodAccess" in both code and config file together.
    [ServiceContract]
    public interface IEndPeriodAccess
    {
        [OperationContract]
        EndPeriodCollection Query(EndPeriod endPeriod);

        [OperationContract]
        void Insert(EndPeriod endPeriod);


    }
}
