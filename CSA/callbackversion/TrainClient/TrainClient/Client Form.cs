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
            tbSensorValue.Text = client.ReadSensorState(Convert.ToInt32(tbSensorId.Text)).ToString();
        }

        private void btnWriteActuator_Click_1(object sender, EventArgs e)
        {
            string message = client.WriteActuatorValue(Convert.ToInt32(tbActuatorId.Text), Convert.ToInt32(numSpeed.Text) * 10);
            MessageBox.Show(message);
        }

        private void LdrReadClock_Tick(object sender, EventArgs e)
        {
            int valueLdr = client.ReadSensorState(1);
            tbReadTimeLdr.Text = valueLdr.ToString();

            if (valueLdr == 1)
            {
                tbDanger.Text = "Danger!";
            }
            else if (valueLdr == 0)
            {
                tbDanger.Text = "safe";
            }
        }

        private void subscribebtn_Click(object sender, EventArgs e)
        {
            client.Subscribe();    
        }

        private void unsubscribebtn_Click(object sender, EventArgs e)
        {
            client.Unsubscribe();    
        }

        
    }
}
