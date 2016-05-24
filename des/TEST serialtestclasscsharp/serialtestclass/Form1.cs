using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace serialtestclass{
  
    public partial class Form1 : Form{
        int[] value = new int[2];
        bool blocktimer = false;
        SerialPort _serialPort=new SerialPort();
        public Form1(){
            extractnumbers("a");
            InitializeComponent();
            for (int i = 0; i < 10;i++ ){
                comboBox1.Items.Add("COM"+i);
            }
            _serialPort.BaudRate = 9600;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void extractnumbers(string test)
        {

            test = "aaaaa222\n";
            int pos = -1;
            int startpos = 0;
            int timeslooped=0;
            while ((pos = test.IndexOf('\n', pos + 1)) != -1)
            {
                if (pos < test.Length)
                {
                    string text = test.Substring(startpos, pos - startpos);
                    value[timeslooped] = Convert.ToInt32(Regex.Match(text, @"\d+").Value);
                    startpos = pos;
                    Console.WriteLine(value[timeslooped]);

                    timeslooped++;
                }
                
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
        
        private void connect_Click(object sender, EventArgs e)
        {
            _serialPort.Close();
            _serialPort.PortName = comboBox1.Text;
            //
            _serialPort.Open();
            if (_serialPort.IsOpen){                label1.Text = "open";
                timer1.Enabled = true;
                timer2.Enabled = true;
         
            }
            else 
            {
                label1.Text = "failed";
            }
        }
        
        public bool sendCmd(String cmd)
        {
            bool success = true;
                 try
                 {
                     if (_serialPort.IsOpen)
                     {
                         //hier t command
                         _serialPort.Write(cmd);

                     }
                     else
                     {
                         Debug.WriteLine("a");
                     }
                 }
                 catch (Exception ex)
                 {
                    
                     success = false;
                 }
                 return success;
     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (blocktimer)
            {       
           // sendCmd("datarequest");
            }

        }
        private void label1_Click(object sender, EventArgs e){}
        private void Form1_Load(object sender, EventArgs e){}

       
        private void button1_Click(object sender, EventArgs e)
        {
                blocktimer = true;
                sendCmd("turnon");
                blocktimer = false;
        }
  
        private void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
        {
            string indata = _serialPort.ReadExisting();

            Console.Write(indata);  
        }
     
    }
}
