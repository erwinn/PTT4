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

CANMSG msg;
MCP2515 can;


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
    //////////////////
    s="";
  }
}
void sendcanmsg(int adress,int value)
{
  CANMSG msg2;
  msg2.adrsValue = adress;
  msg2.isExtendedAdrs = false;
  msg2.rtr = false;
  msg2.dataLength = 1;
  msg2.data[0] = value;
  can.transmitCANMessage(msg2, 1000);
}

void turnon()
{
  digitalWrite(8,HIGH);
  digitalWrite(7,HIGH);

  delay(1500);
  digitalWrite(8,LOW);
  digitalWrite(7,LOW);
}


void loop()
{
 
  //receiver
  int i = can.receiveCANMessage(&msg, 1000);
  if(i&&msg.adrsValue==SENSOR_1)
  { 
    /*
    Serial.print(msg.data[0]);
     Serial.print(" ");
    Serial.println(msg.adrsValue);*/
    datatransmitter1=msg.data[0];
  }
  else if(i&&msg.adrsValue==SENSOR_2)
  {
/*
    Serial.print(msg.data[0]);
     Serial.print(" ");
    Serial.println(msg.adrsValue);*/
    datatransmitter2=msg.data[0];
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
