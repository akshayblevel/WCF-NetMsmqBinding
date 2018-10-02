using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFNetMSMQ
{
    public class QueueService : IQueueService
    {
        public void GetData(int value)
        {
            System.Diagnostics.Trace.Write(string.Format("You entered: {0}", value));
        }
    }
}
