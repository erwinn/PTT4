//CODE for Spoorwissel 2

#include <SPI.h>
#include <MCP2515.h>
#define SPOORWISSEL_2 0x7d5

//define led pins
#define TrackLeft 2
#define TrackRight 3

int delaynr = 5;
String s = "";

//Switch Status, false equals Left, True equals Right
bool State = false;

CANMSG msg;
MCP2515 can;


void setup()
{
  SPI.setClockDivider(SPI_CLOCK_DIV8);
  if (can.initCAN(CAN_BAUD_100K) == 0)
  {
    //initCAN() failed
    while (1)
    {
      digitalWrite(7, HIGH);
      delay(200);
      digitalWrite(7, LOW);
      delay(200);
    }
  }
  if (can.setCANNormalMode(LOW) == 0) //normal mode non single shot
  {
    while (1)
    {
      //setCANNormalMode() failed      digitalWrite(8, HIGH);
      delay(200);
      digitalWrite(8, LOW);
      delay(200);
    }
  }
}


void loop()
{
  //receive can Messages
  int i = can.receiveCANMessage(&msg, 1000);
  if (i && msg.adrsValue == SPOORWISSEL_2)
  {    
    State = (msg.data[0] > 0);
  }
  delay(delaynr);

  //Update State Status
  digitalWrite(TrackLeft, !State);
  digitalWrite(TrackRight, State);
}

int extractintfromstring(String msg)
{
  String tempstring = "";
  for (int i = 0; i < msg.length(); i++)
  {
    if (isdigit(msg[i]) != 0)
    {
      tempstring += msg[i];
    }
  }
  return tempstring.toInt();
}
