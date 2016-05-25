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
        Timer timer1 = new Timer(3000);
        int[] sensorarray = new int[2];
        bool blocktimer = false;
        SerialPort _serialPort = new SerialPort();
        //string[] ports = SerialPort.GetPortNames();

        public SerialClass()
        {
            Debug.WriteLine("constructor SerialClass() ");
            timer1.Elapsed += timer1_Tick;
            timer1.Enabled = true;
            _serialPort.BaudRate = 9600;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }
        
       
        public int[] getSensorArray(){return sensorarray;}
      

        public bool sendCmd(String cmd)
        {
            try{
                if (_serialPort!=null){
                    if (_serialPort.IsOpen){
                   
                        blocktimer = true;
                        _serialPort.Write(cmd);
                        blocktimer = false;
                        return true;
                    }
                }
            }
            catch (NullReferenceException){
                throw new NullReferenceException();
    
            }
            return false;
        }
        private void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e ){
            readarduino();
        }
        public void Connect()
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports == null || ports.Length==0){
                return;
            }
            //_serialPort.PortName = ports[0];
            _serialPort.PortName = "COM9";
            _serialPort.Open();
            if (_serialPort.IsOpen){
                Debug.WriteLine("open");
                //sendCmd("datarequest");
                timer1.Enabled = true;
            }
            else{
                Debug.WriteLine("failed");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!blocktimer){
         
                sendCmd("datarequest");
            }
        }
     
        private void extractnumbers(string word)
        {
            if(!word.Any(c => char.IsDigit(c)))
            {
                return;
            }
            string resultString = Regex.Match(word, @"\d+").Value;
            if (word.Contains("SENSORA"))
            {
                sensorarray[0] = Convert.ToInt32(resultString);
            }
            else if (word.Contains("SENSORB"))
            {
                sensorarray[1] = Convert.ToInt32(resultString);
            }
        }
        private void readarduino()
        {
            if (_serialPort.IsOpen)
                {
                    if (_serialPort.BytesToRead > 0)
                    {
                        string text = _serialPort.ReadLine();
                        extractnumbers(text);
                        Debug.WriteLine(text);
                    }
                }
        }
    }
}
/*
     int pos = -1;
     int startpos = 0;
     int timeslooped = 0;
     while ((pos = word.IndexOf('\n', pos + 1)) != -1)
     {
         if (pos < word.Length)
         {
             string text = word.Substring(startpos, pos - startpos);
             sensorvalue[timeslooped] = Convert.ToInt32(Regex.Match(text, @"\d+").Value);
             startpos = pos;
             Console.WriteLine(sensorvalue[timeslooped]);
             timeslooped++;
         }
     }*/