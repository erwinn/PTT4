#include <SPI.h>
#include <MCP2515.h>

#define SENSOR_1 0x7d1
#define SENSOR_2 0x7d2
#define TREIN 0x7d3
#define SPOORWEGOVERGANG 0x7d4
#define SPOORWISSEL 0x7d5
#include <SoftwareSerial.h>

int delaynr=5;
String s = "";
int datatransmitter1=120;
int datatransmitter2=120;

CANMSG readmsg;
MCP2515 can;
CANMSG sendmsg;

SoftwareSerial mySerial(5, 6);

void setup()
{
  
  mySerial.begin(9600);
  mySerial.println("-----------------------------------------");
  mySerial.println("-----------------------------------------");
  mySerial.println("-----------------------------------------");
  mySerial.println("-----------------------------------------"); 
 
  
  pinMode(8, OUTPUT);
  pinMode(7, OUTPUT);

  Serial.begin(9600); 
  while(!Serial);
  Serial.println("Go...");
  SPI.setClockDivider(SPI_CLOCK_DIV8);
  if(can.initCAN(CAN_BAUD_100K) == 0)
  {
    Serial.println("initCAN() failed");
    while(1);
  }
  if(can.setCANNormalMode(LOW) == 0) //normal mode non single shot
  {
    Serial.println("setCANNormalMode() failed");
    while(1);
  }
  
  sendmsg.isExtendedAdrs = false;
  sendmsg.rtr = false;
  sendmsg.dataLength=8;
}

void readCsharp()
{
  if (Serial.available() > 0) 
  {
    while ((Serial.available() > 0))
    {
      s = s + (char)Serial.read();
      delay(1);
    }
    //////////////
    if(s=="datarequest")
    {
      String message ="datatransmitterA "+String(datatransmitter1);
      Serial.println(message); 
      message ="datatransmitterB "+String(datatransmitter2);
      Serial.println(message);
    }   
    else if(s=="turnon")
    {
      turnon();
    }
    else if(Startwith(s, "ArduinoSwitchTrackA"))
    {
      //mySerial.println(s);
      sendmsg.data[0]=extractintfromstring(s);
      sendmsg.data[1]=1;
      sendcanmsg(SPOORWISSEL);
    }
    else if(Startwith(s, "ArduinoSwitchTrackB"))
    {
    //  mySerial.println(s);
      sendmsg.data[0]=extractintfromstring(s);
      sendmsg.data[1]=2;
      sendcanmsg(SPOORWISSEL);
    }
    else if(Startwith(s, "ArduinoStopTrainA"))
    {
    //  mySerial.println(s);
      sendmsg.data[0]=0;
      sendmsg.data[1]=1;
      sendcanmsg(TREIN);
     
    }
    else if(Startwith(s, "ArduinoStopTrainB"))
    {
     // mySerial.println(s);
      sendmsg.data[0]=0;
      sendmsg.data[1]=1;
      sendcanmsg(TREIN);
    }
    else if(Startwith(s, "ArduinoSetSpeedA"))
    {
      
      sendmsg.data[0]=extractintfromstring(s);
    //  mySerial.println(String(sendmsg.data[0]));
      sendmsg.data[1]=1;
      sendcanmsg(TREIN);
    
    }
    else if(Startwith(s, "ArduinoSetSpeedB"))
    {
      sendmsg.data[0]=extractintfromstring(s);
    //  mySerial.println(String(sendmsg.data[0]));
      sendmsg.data[1]=1;
      sendcanmsg(TREIN);
    }
    else if(s!="")
    {
      mySerial.println(s);
    }
    /////////////////////////////////////////
    ///////////////////////////////////
    s="";
  }
}
void sendcanmsg(int adress)
{
  sendmsg.adrsValue = adress;
  can.transmitCANMessage(sendmsg, 1000);
}

void turnon()
{
  digitalWrite(8,HIGH);
  digitalWrite(7,HIGH);
  delay(1500);
  digitalWrite(8,LOW);
  digitalWrite(7,LOW);
}
/*
bool Startwith(String s, String search)
{
int max =search.length(); // the searchstring has to fit in the other one  
for (int i=0; i<= max; i++) 
{
  
if (s.substring(0,i) == search) return true;  // or i
}
return false;  //or -1
}
*/
void loop()
{
 
  //receiver
  int i = can.receiveCANMessage(&readmsg, 1000);
  if(i&&readmsg.adrsValue==SENSOR_1)
  { 
     
    datatransmitter1=readmsg.data[0];
  }
  else if(i&&readmsg.adrsValue==SENSOR_2)
  {
    datatransmitter2=readmsg.data[0];
  }
  readCsharp();
  //delay(delaynr);
}
int extractintfromstring(String msg)
{
  String tempstring="";
  for(int i=0;i<msg.length();i++)
  {
    if(isdigit(msg[i])!=0)
    {
      tempstring+=msg[i];
    }
  } 
  return tempstring.toInt();
}



bool Startwith(String s, String search)
        {
            int total = s.length() - search.length();
            for (int i = 0; i < total+1; i++)
            {
                                
                if (s.substring(i, i+search.length()) == search)
                 {

                     return true;
                 }
            }
            return false;
        }

 
 
