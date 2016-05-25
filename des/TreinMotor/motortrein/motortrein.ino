//NIET AF

#include <PID_v1.h>
#include <SPI.h>
#include <MCP2515.h>

#define TREIN 0x7d3

#define MotorPWR 3
#define MotorDir 12
#define SpeedSensorPin A5

int delaynr = 5;
String s = "";

CANMSG msg;
MCP2515 can;

double Output;
long TimePassed;
double RPM;
double Setpoint = 160;

PID myPID(&RPM, &Output, &Setpoint, 0.6, 0.5, 0.1, DIRECT);


void setup()
{
  pinMode(SpeedSensorPin, INPUT);
  pinMode(MotorPWR, OUTPUT);
  pinMode(MotorDir, OUTPUT);
  digitalWrite(MotorDir, LOW);

  myPID.SetMode(AUTOMATIC);

  Serial.begin(9600);
  while (!Serial);
  Serial.println("Go...");
  SPI.setClockDivider(SPI_CLOCK_DIV8);
  if (can.initCAN(CAN_BAUD_100K) == 0)
  {
    Serial.println("initCAN() failed");
    while (1);
  }
  if (can.setCANNormalMode(LOW) == 0) //normal mode non single shot
  {
    Serial.println("setCANNormalMode() failed");
    while (1);
  }

}


void loop()
{

  //receiver
  int i = can.receiveCANMessage(&msg, 1000);
  if (i && msg.adrsValue == TREIN)
  {
    int treinid = msg.data[1];

    //MotorControl
    RefreshRPM();
    myPID.Compute();
    analogWrite(MotorPWR, Output);
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

