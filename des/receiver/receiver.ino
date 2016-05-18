#include <SPI.h>
#include <MCP2515.h>

//receivre
 

 

int delaynr=500;
String s = "";
int datatransmitter1=0;
int datatransmitter2=0;

CANMSG msg;
MCP2515 can;


void setup()
{
 

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



void readincoming()
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
      String message ="datatransmitter2 "+String(datatransmitter2);
      Serial.println(message); 
      message ="datatransmitter1 "+String(datatransmitter1);
      Serial.println(message);
    }   
    //////////////////
    s="";
  }
}
void loop()
{
 
  //receiver
  int i = can.receiveCANMessage(&msg, 1000);
  if(i&&msg.adrsValue==0x7d1)
  { 
    /*
    Serial.print(msg.data[0]);
     Serial.print(" ");
    Serial.println("data receivedd");*/
    datatransmitter1=msg.data[0];
  }
  else if(i&&msg.adrsValue==0x7d2)
  {
    /*
    Serial.print(msg.data[0]);
     Serial.print(" ");
    Serial.println("data receivedd");*/
    datatransmitter2=msg.data[0];
  }
 
  readincoming();
 
  delay(delaynr);
}
