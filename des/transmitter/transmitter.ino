#include <SPI.h>
#include <MCP2515.h>

//receivre
 
int ldr=A0;
int delaynr=500;
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
  //MODE == 1
  //transmitter
  int value = analogRead(ldr)/4;
  msg.adrsValue = 0x7df;
  msg.isExtendedAdrs = false;
  msg.rtr = false;
  msg.dataLength = 1;
  msg.data[0] = value;
  can.transmitCANMessage(msg, 1000);

  Serial.println(value);

  delay(delaynr);
}
