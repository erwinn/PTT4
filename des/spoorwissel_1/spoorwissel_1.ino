//CODE for Spoorwissel 1

#include <SPI.h>
#include <MCP2515.h>
#define SPOORWISSEL_ADRESS 0x7d4

//define led pins
#define TrackLeft A0
#define TrackRight A1

int delaynr = 5;
String s = "";

//Switch Status, false equals Left, True equals Right
bool State = false;

CANMSG msg;
MCP2515 can;


void setup()
{
  pinMode(TrackLeft, OUTPUT);
  pinMode(TrackRight, OUTPUT);
  digitalWrite(TrackLeft, LOW);
  digitalWrite(TrackRight, LOW);
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
  if (can.receiveCANMessage(&msg, 1000) && msg.adrsValue == SPOORWISSEL_ADRESS)
  {
    State = (msg.data[0] > 0);
  }

  //Update State Status
  SwitchTrack(State);

  //wait before reading again
  delay(delaynr);


}

//Update Track Status
int SwitchTrack(bool Track)
{
  if (Track)
  {
    digitalWrite(TrackLeft, LOW);
    digitalWrite(TrackRight, HIGH);
    digitalWrite(7, LOW);
    digitalWrite(8, HIGH);
  }
  else
  {
    digitalWrite(TrackLeft, HIGH);
    digitalWrite(TrackRight, LOW);
    digitalWrite(7, HIGH);
    digitalWrite(8, LOW);
  }
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
