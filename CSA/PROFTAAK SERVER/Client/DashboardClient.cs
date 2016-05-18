using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyServiceContract;
using System.ServiceModel;

namespace Client
{
    public partial class DashboardClient : ClientBase<IDashboard>, IDashboard
    {
        public DashboardClient()
        {
 
        }

        public DashboardClient(string endpointConfigurationName, string remoteAddress)
            : base(endpointConfigurationName, remoteAddress)
        {
        }

        public DashboardClient(string endpointConfigurationName, EndpointAddress remoteAddress)
         : base(endpointConfigurationName, remoteAddress)
        {
        }

        public DashboardClient(System.ServiceModel.Channels.Binding binding, EndpointAddress remoteAddress)
         : base(binding, remoteAddress)
        {
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public void Run(bool state)
        {
            throw new NotImplementedException();
        }

        public bool SwitchTrack(int id, bool state)
        {
            throw new NotImplementedException();
        }

        public void StopTrain(int trainId)
        {
            
        }

        public bool WriteSensorState(bool state, int sensor)
        {
            throw new NotImplementedException();
        }

        public bool ReadSensorState(bool state, int sensor)
        {
            throw new NotImplementedException();
        }
    }
}
