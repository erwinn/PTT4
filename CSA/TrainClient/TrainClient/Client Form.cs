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
            client.SwitchTrack(Convert.ToInt32(tbTrain.Text), Convert.ToInt32(tbState));
        }

        private void btnStopTrain_Click(object sender, EventArgs e)
        {
            client.StopTrain(Convert.ToInt32(tbTrainID2.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartTrain_Click(object sender, EventArgs e)
        {
            client.Run(Convert.ToInt32(tbTrainID2.Text));
        }

        private void btnReadSensor_Click(object sender, EventArgs e)
        {
            int readSensor = client.ReadSensorState(Convert.ToInt32(tbSensorId));
            tbSensorValue.Text = readSensor.ToString();
        }

        private void btnWriteActuator_Click_1(object sender, EventArgs e)
        {
            bool writeActuator = client.WriteActuatorValue(Convert.ToInt32(numSpeed) * 10, Convert.ToInt32(tbActuatorId));
        }
    }
}
