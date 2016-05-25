#include <SPI.h>
#include <MCP2515.h>
#define SENSOR_1 0x7d1
#define SENSOR_2 0x7d2
#define TREIN 0x7d3
#define SPOORWEGOVERGANG 0x7d4
#define SPOORWISSEL 0x7d5
 
//
int delaynr=5;
String s = "";
int datatransmitter1=0;
int datatransmitter2=0;

CANMSG readmsg;
MCP2515 can;
CANMSG sendmsg;

void setup()
{



  
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
    if(s=="turnon")
    {
      turnon();
    }
    if(Startwith(s, "ArduinoSwitchTrackA"))
    {
      sendmsg.data[0]=extractintfromstring(s);
      sendmsg.data[1]=1;
      sendcanmsg(SPOORWISSEL);
    }
    if(Startwith(s, "ArduinoSwitchTrackB"))
    {
      sendmsg.data[0]=extractintfromstring(s);
      sendmsg.data[1]=2;
      sendcanmsg(SPOORWISSEL);
    }
    if(Startwith(s, "ArduinoStopTrainA"))
    {
      sendmsg.data[0]=0;
      sendmsg.data[1]=1;
      sendcanmsg(TREIN);
      Serial.println(s);
    }
    if(Startwith(s, "ArduinoStopTrainB"))
    {
      sendmsg.data[0]=0;
      sendmsg.data[1]=1;
      sendcanmsg(TREIN);
    }
    if(Startwith(s, "ArduinoSetSpeedA"))
    {
      sendmsg.data[0]=extractintfromstring(s);
   
      sendmsg.data[1]=1;
      sendcanmsg(TREIN);
      Serial.println(s);
    }
    if(Startwith(s, "ArduinoSetSpeedB"))
    {
      sendmsg.data[0]=extractintfromstring(s);
      sendmsg.data[1]=1;
      sendcanmsg(TREIN);
      Serial.println(s);
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
bool Startwith(String s, String search)
{
int max =search.length(); // the searchstring has to fit in the other one  
for (int i=0; i<= max; i++) 
{
  
if (s.substring(0,i) == search) return true;  // or i
}
return false;  //or -1
}

void loop()
{
 
  //receiver
  int i = can.receiveCANMessage(&readmsg, 1000);
  if(i&&readmsg.adrsValue==SENSOR_1)
  { 
    /*
    Serial.print(msg.data[0]);
     Serial.print(" ");
    Serial.println(msg.adrsValue);*/
    datatransmitter1=readmsg.data[0];
  }
  else if(i&&readmsg.adrsValue==SENSOR_2)
  {
/*
    Serial.print(msg.data[0]);
     Serial.print(" ");
    Serial.println(msg.adrsValue);*/
    datatransmitter2=readmsg.data[0];
  }
  readCsharp();
  delay(delaynr);
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
