#include <SPI.h>
#include <MCP2515.h>
#include <SoftwareSerial.h>
#include <serLCD.h>

//Adress of this arduino
#define SENSOR_ADRESS 0x7d1
#define SEIN_RICHTING 0x7d4
#define SEIN_OBJECT 0x7d5
#define TREIN 0x7d3

//define Pins
#define LDR1 A0
#define LDR2 A1
#define LCDPin 6

//if The Sensors are Blocked
bool Block1;
bool Block2;

bool IsAtEnd = false;
//for measuring time in the code
long TimePassed;
long SensorDelay;
long IsAtEndTimer;

//Define SerialLCD Display
serLCD lcd(LCDPin);

//Define Can interface
CANMSG msg;
MCP2515 can;

void setup() {
  //init Display
  lcd.setBrightness(30);
  lcd.clear();
  lcd.print("Traindetector");

  //Set PinMode
  pinMode(LDR1, INPUT);
  pinMode(LDR2, INPUT);

  SPI.setClockDivider(SPI_CLOCK_DIV8);
  if (can.initCAN(CAN_BAUD_100K) == 0)
  {
    lcd.clear();
    lcd.print("initCAN() failed");
    while (1);
  }
  if (can.setCANNormalMode(LOW) == 0) //normal mode non single shot
  {
    lcd.clear();
    lcd.print("setCANNormalMode() failed");
    while (1);
  }
}

void loop() {
  //Read the sensor 1:
  int Value1 = analogRead(LDR1);

  //set value to true or false, if needed
  if (Value1 > 800) Block1 = true;
  else if (Value1 < 600) Block1 = false;

  //Read the sensor 2:
  int Value2 = analogRead(LDR2);

  //set value to true or false, if needed
  if (Value2 > 800)   Block2 = true;
  else if (Value2 < 600) Block2 = false;

  //Display Sensor Data
  if (millis() - TimePassed > 200)
  {
    TimePassed = millis();

    //clear the data line:
    lcd.selectLine(2);
    //lcd.clearLine(2);

    //Print the data of sensor 1:
    lcd.print("SENSOR1: ");
    if (Block1) lcd.print("    Blocked");
    else        lcd.print("Not Blocked");

    //Print the data of sensor 2:
    lcd.print("SENSOR2: ");
    if (Block2) lcd.print("    Blocked");
    else        lcd.print("Not Blocked");
    SendMessage(Block1 || Block2, SENSOR_ADRESS);
    if (Block1)
    {
      SensorDelay = millis();
      SendMessage(1, SEIN_RICHTING);
      SendMessage(1, SEIN_OBJECT);
    }
    if (Block2)
    {
      SensorDelay = millis();
      SendMessage(0, SEIN_RICHTING);
      SendMessage(1, SEIN_OBJECT);
      IsAtEnd = true;
      IsAtEndTimer = millis();
    }
    if (IsAtEnd && (millis() - IsAtEndTimer) > 2000)
    {
      //sendmsg.data[0] = 0;
      //sendmsg.data[1] = 1;
      SendMessage(0, TREIN);
      IsAtEnd = false;
    }
  }
  if (millis() - SensorDelay > 5000)
  {
    SensorDelay = millis();
    SendMessage(0, SEIN_OBJECT);
  }
}

void SendMessage(int value, int adress)
{
  msg.adrsValue = adress;
  msg.isExtendedAdrs = false;
  msg.rtr = false;
  msg.dataLength = 1;
  msg.data[0] = value;
  can.transmitCANMessage(msg, 1000);
}
