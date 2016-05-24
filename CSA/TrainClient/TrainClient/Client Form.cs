using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainClient
{
    public partial class Form1 : Form
    {
        private Client client;

        public Form1()
        {
            InitializeComponent();
            client = new Client();
        }

        private void btnSwitchTrack_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbTrain);
            int state = Convert.ToInt32(tbState);
            client.SwitchTrack(id, state);
        }

        private void btnStopTrain_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbTrainID2.Text);
            client.StopTrain(id);
        }

       // private void btnWriteSensor_Click(object sender, EventArgs e)
       // {
           // int state = Convert.ToInt32(tbState2);
           // int sensor = Convert.ToInt32(tbSensor);
          //  bool writesensor = client.WriteSensorState(state, sensor);
       // }
    }
}
