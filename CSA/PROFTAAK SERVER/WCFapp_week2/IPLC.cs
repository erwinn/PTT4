using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MyServiceContract
{
    [ServiceContract(Namespace = "MyServiceContract")]
    public interface IPLC
    {
        [OperationContract]
        string SendMessage(string message);
        [OperationContract]
        string RecieveMessage();
    }
}
