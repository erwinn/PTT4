using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Timers;
namespace TrainService
{
    public class SerialClass
    {
        Timer timer1 = new Timer(15000);
        int[] sensorvalue = new int[2];
        bool blocktimer = false;
        SerialPort _serialPort = new SerialPort();
        //string[] ports = SerialPort.GetPortNames();

        public SerialClass()
        {
            Debug.WriteLine("constructor SerialClass() ");
            timer1.Elapsed += timer1_Tick;
            timer1.Enabled = true;
         
        }
        public SerialPort SerialPort
        {
            get { return _serialPort; }
           
        }
        
       
        public int getSensor_1()
        {
            return sensorvalue[1];
        }
        public int getSensor_2()
        {
            return sensorvalue[2];
        }

        public bool sendCmd(String cmd)
        {
            Debug.WriteLine("send");
            try
            {
                if (_serialPort!=null)
                {
                    if (_serialPort.IsOpen)
                    {
                   
                        blocktimer = true;
                        _serialPort.Write(cmd);
                        blocktimer = false;
                        return true;
                    }
                }

            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();
                

            }
            return false;
        }
        private void DataReceivedHandler(object sender,
                        SerialDataReceivedEventArgs e )
        {
            readarduino();
        }
        public void Connect()
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports == null || ports.Length==0)
            {
                return;
            }
            _serialPort.PortName = ports[0];

            _serialPort.BaudRate = 9600;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            _serialPort.Open();
            if (_serialPort.IsOpen)
            {
                Debug.WriteLine("open");
                sendCmd("datarequest");
                
                timer1.Enabled = true;

            }
            else
            {
                Debug.WriteLine("failed");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("ticck");
            if (!blocktimer)
            {
                Debug.WriteLine("aaaa");
                //readarduino();
                sendCmd("datarequest");
            }

        }
        private void extractnumbers(string test)
        {
            int pos = -1;
            int startpos = 0;
            int timeslooped = 0;
            while ((pos = test.IndexOf('\n', pos + 1)) != -1)
            {
                if (pos < test.Length)
                {
                    string text = test.Substring(startpos, pos - startpos);
                    sensorvalue[timeslooped] = Convert.ToInt32(Regex.Match(text, @"\d+").Value);
                    startpos = pos;
                    Console.WriteLine(sensorvalue[timeslooped]);

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
                        Debug.WriteLine(text);
                        extractnumbers(text);
                    }
                }
            }
        }
    }
}
