using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFNetMSMQClient
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueServiceReference.QueueServiceClient serviceClient = new QueueServiceReference.QueueServiceClient();
            serviceClient.GetData(5677);
        }
    }
}
