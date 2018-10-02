using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFNetMSMQ
{
    [ServiceContract]
    public interface IQueueService
    {
        [OperationContract(IsOneWay=true)]
        void GetData(int value);
    }
}
