using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace serialtestclass{
    
    public partial class Form1 : Form{
        SerialPort _serialPort=new SerialPort();
        public Form1(){
            InitializeComponent();
            for (int i = 0; i < 10;i++ ){
                comboBox1.Items.Add("COM"+i);
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            _serialPort.PortName = comboBox1.Text;
            _serialPort.BaudRate = 9600;
            //_serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            _serialPort.Open();
            if (_serialPort.IsOpen){
                label1.Text = "open";
                timer1.Enabled = true;
                timer2.Enabled = true;
         
            }
            else {
                label1.Text = "failed";
            }
        }
        
        public void sendCmd(String cmd)
        {
            try{
                if (_serialPort.IsOpen){
                    //hier t command
                    _serialPort.Write(cmd);
                }         
            }
            catch (NullReferenceException){
                throw new NullReferenceException();
               
            }
        }
        private void readarduino()
        {
            if (_serialPort != null)
            {
                if (_serialPort.IsOpen)
                {
                    if (_serialPort.BytesToRead > 0)
                    {
                        string text = _serialPort.ReadExisting();
                        Console.WriteLine(text);
                        label1.Text = text;
                    }
                }
            }
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            readarduino();

        }
        private void label1_Click(object sender, EventArgs e){}
        private void Form1_Load(object sender, EventArgs e){}

        private void timer2_Tick(object sender, EventArgs e)
        {
            sendCmd("datarequest");
        }
        /*/
        private void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
        {
            string indata = _serialPort.ReadExisting();

            Console.Write(indata);  
        }
       /*/
    }
}
