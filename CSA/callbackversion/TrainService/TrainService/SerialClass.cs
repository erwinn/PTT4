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
        TrainService trainService;

        Timer timer1 = new Timer(750);
        Timer timer2 = new Timer(3000);

        int[] sensorarray = new int[2];
        bool blocktimer = false;
        
        SerialPort _serialPort = new SerialPort();
        string[] ports = SerialPort.GetPortNames();

        public SerialClass(TrainService trainService)
        {
            this.trainService = trainService;
            Debug.WriteLine("constructor SerialClass() ");
            timer1.Elapsed += timer1_Tick;
            timer1.Enabled = true;
            timer2.Elapsed += timer2_Tick;
            timer2.Enabled = false;
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
            _serialPort.PortName = ports[0];
            _serialPort.Open();
            if (_serialPort.IsOpen){
                Debug.WriteLine("open");
                sendCmd("datarequest");
                timer1.Enabled = true;
            }
            else{
                Debug.WriteLine("failed");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!blocktimer)
            {
                sendCmd("datarequest");               
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            sendCmd("ArduinoStopTrainA");

            trainService.Callback();
        }
     
        private void extractnumbers(string word)
        {
              
            if(!word.Any(c => char.IsDigit(c)))
            {
                return;
            }
            string resultString = Regex.Match(word, @"\d+").Value;
            if (word.Contains("datatransmitterA"))
            {
                sensorarray[0] = Convert.ToInt32(resultString);
                
            }
            else if (word.Contains("datatransmitterB"))
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

                        if (sensorarray[0]==1||sensorarray[1]==1)
                        {
                            timer2.Enabled = true;
                        }
                        else
                        {
                            timer2.Enabled = false;
                        }
                    }
                }
        }
    }
}