using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MyServiceContract
{
    [ServiceContract(Namespace = "MyServiceContract")]
    public interface IDashboard
    {
        [OperationContract]
        void Refresh();
        [OperationContract]
        void Run(bool state);
        [OperationContract]
        bool SwitchTrack(int id, bool state);
        [OperationContract]
        void StopTrain(int trainId);
        [OperationContract]
        bool WriteSensorState(bool state, int sensor);
        [OperationContract]
        bool ReadSensorState(bool state, int sensor);
    }
}
