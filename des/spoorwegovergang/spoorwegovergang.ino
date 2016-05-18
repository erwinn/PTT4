//NIET AF

#include <SPI.h>
#include <MCP2515.h>
#define SPOORWEGOVERGANG 0x7d4
  
int delaynr=5;
String s = "";

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


void loop()
{
 
  //receiver
  int i = can.receiveCANMessage(&msg, 1000);
  if(i&&msg.adrsValue==SPOORWEGOVERGANG)
  { 
     
     
  }
 
 
 
  delay(delaynr);
}
