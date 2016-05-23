﻿using System;
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

        public void sendCmd(String cmd)
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                   
                    blocktimer = false;
                    _serialPort.Write(cmd);
                    blocktimer = true;
                }
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();

            }
        }
        public void Connect(string Portname,int Baudrate)
        {
            _serialPort.PortName = Portname;
            _serialPort.BaudRate = Baudrate;
            //_serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            _serialPort.Open();
            if (_serialPort.IsOpen)
            {
                Debug.WriteLine("open");
                sendCmd("datarequest");
                timer1.Elapsed += timer1_Tick;
                timer1.Enabled = true;

            }
            else
            {
                Debug.WriteLine("failed");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (blocktimer)
            {
                readarduino();
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
