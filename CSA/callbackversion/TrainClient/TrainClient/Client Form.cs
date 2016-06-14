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
            cbSwitchState.Items.Add(Switch.Left);
            cbSwitchState.Items.Add(Switch.Right);
            cbSwitchState.SelectedIndex = 0;
            cbSwitchID.SelectedIndex = 0;
        }

        private void btnSwitchTrack_Click(object sender, EventArgs e)
        {
            client.SetSwitch(Convert.ToInt32(cbSwitchID.SelectedItem), (Switch)cbSwitchState.SelectedItem);
        }

        private void btnStopTrain_Click(object sender, EventArgs e)
        {
            client.StopTrain();
        }

        private void btnWriteActuator_Click_1(object sender, EventArgs e)
        {
            string message = client.SetTrainSpeed((int)numSpeed.Value);
            MessageBox.Show(message);
        }

        private void LdrReadClock_Tick(object sender, EventArgs e)
        {
            int valueLdr = client.ReadSensorState(1);

            if (valueLdr == 1)
            {
                tbDanger.Text = "Danger!";
            }
            else if (valueLdr == 0)
            {
                tbDanger.Text = "safe";
            }
            tbRPM.Text = client.ReadSensorState(2).ToString();
        }

        private void subscribebtn_Click(object sender, EventArgs e)
        {
            unsubscribebtn.Enabled = true;
            subscribebtn.Enabled = false;
            client.Subscribe();    
        }

        private void unsubscribebtn_Click(object sender, EventArgs e)
        {
            unsubscribebtn.Enabled = false;
            subscribebtn.Enabled = true;
            client.Unsubscribe();    
        }

        
    }
}
