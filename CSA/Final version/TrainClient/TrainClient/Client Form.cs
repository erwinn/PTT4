using System;
using System.Diagnostics;
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
            cbSwitchState.Items.Add(SIGN.GO);
            cbSwitchState.Items.Add(SIGN.STOP);
            cbSwitchState.SelectedIndex = 0;
            if(client.connectionState)
            {
                lblNoConnection.Visible = false;
            }
        }

        private void btnSwitchTrack_Click(object sender, EventArgs e)
        {
            client.SetSwitch((SIGN)cbSwitchState.SelectedItem);
        }

        private void btnStopTrain_Click(object sender, EventArgs e)
        {
            client.StopTrain();
        }

        private void btnWriteActuator_Click_1(object sender, EventArgs e)
        {
            try
            {
                string message = client.SetTrainSpeed((int)numSpeed.Value);
                MessageBox.Show(message);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Couldn't write to server!");
            }
            catch (System.ServiceModel.CommunicationException)
            {
                lblNoConnection.Visible = true;
            }
}

        private void LdrReadClock_Tick(object sender, EventArgs e)
        {
            int valueLdr = client.ReadSensorState(1);

            if(!client.connectionState)
            {
                tbDanger.Text = "No connection";
                return;
            }
            lblNoConnection.Visible = false;
            if (valueLdr == 1)
            {
                tbDanger.Text = "DANGER!";
            }
            else if (valueLdr == 0)
            {
                tbDanger.Text = "Safe";
            }
            tbRPM.Text = client.ReadSensorState(2).ToString();
        }

        private void subscribebtn_Click(object sender, EventArgs e)
        {
            if(client.Subscribe())
            {
                lblNoConnection.Visible = false;
                subscribebtn.Enabled = false;
                unsubscribebtn.Enabled = true;
            }    
        }

        private void unsubscribebtn_Click(object sender, EventArgs e)
        {
            if(client.Unsubscribe())
            {
                lblNoConnection.Visible = false;
                unsubscribebtn.Enabled = false;
                subscribebtn.Enabled = true;
            }   
        }
    }
}
