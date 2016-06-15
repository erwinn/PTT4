#include <SPI.h>
#include <MCP2515.h>
#include <SoftwareSerial.h>
#include <serLCD.h>

//Set Pinmode
#define Ledpin1 7
#define Ledpin2 8
#define LCDPin 6

//define Adresses
#define SENSOR_LASER 0x7d1            //Sensor for the laser unit
#define SENSOR_RPM 0x7d2
#define TREIN 0x7d3
#define SPOORLIGHT_1 0x7d4
#define SPOORLIGHT_2 0x7d5

//global variable for reading incoming serial messages
String s = "";

//the current state of the laser array (0/1)
int LaserBlocked = 0;

//The RPM of the train (>0)
int CurrentRPM = 120;

//for measuring time in the code
long TimePassed;

//can variables:
CANMSG readmsg;
MCP2515 can;
CANMSG sendmsg;


//Define SerialLCD Display
serLCD lcd(LCDPin);

void setup()
{
  //init Display
  lcd.setBrightness(10);
  lcd.setType(5);
  lcd.clear();
  lcd.print("CAN Controller");

  //Define Pinmode
  pinMode(Ledpin1, OUTPUT);
  pinMode(Ledpin2, OUTPUT);

  //start serial communication with the pc
  Serial.begin(9600);
  while (!Serial);
  Serial.println("Go...");

  //Start Can
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

  //define standart values for sending can messages
  sendmsg.isExtendedAdrs = false;
  sendmsg.rtr = false;
  sendmsg.dataLength = 8;
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
    //a reqeust for data from the pc
    if (s == "datarequest")
    {
      String message = "datatransmitterA " + String(LaserBlocked);
      Serial.println(message);
      message = "datatransmitterB " + String(CurrentRPM);
      Serial.println(message);
    }
    //turn on the leds for a certain time
    else if (s == "turnon")
    {
      turnon();
    }

    //switch a railswitch A To Selected Track. 0 is left, 1 is right
    else if (Contains(s, "ArduinoSwitchSignA"))
    {
      sendmsg.data[0] = extractintfromstring(s);
      sendmsg.data[1] = 1;
      sendcanmsg(SPOORLIGHT_1);
    }

    //switch a railswitch B To Selected Track. 0 is left, 1 is right
    else if (Contains(s, "ArduinoSwitchSignB"))
    {
      sendmsg.data[0] = extractintfromstring(s);
      sendmsg.data[1] = 1;
      sendcanmsg(SPOORLIGHT_2);
    }

    //Stop Train A
    else if (Contains(s, "ArduinoStopTrainA"))
    {
      sendmsg.data[0] = 0;
      sendmsg.data[1] = 1;
      sendcanmsg(TREIN);

    }

    //Set the speed of the train
    else if (Contains(s, "ArduinoSetSpeedA"))
    {

      sendmsg.data[0] = extractintfromstring(s);
      sendmsg.data[1] = 1;
      sendcanmsg(TREIN);

    }
    else if (s != "")
    {
      //mySerial.println(s);
    }
    s = "";
  }
}
void sendcanmsg(int adress)
{
  sendmsg.adrsValue = adress;
  can.transmitCANMessage(sendmsg, 1000);
}

void turnon()
{
  digitalWrite(Ledpin1, HIGH);
  digitalWrite(Ledpin2, HIGH);
  delay(1500);
  digitalWrite(Ledpin1, LOW);
  digitalWrite(Ledpin2, LOW);
}

void loop()
{

  //receiver
  int i = can.receiveCANMessage(&readmsg, 1000);
  if (i && readmsg.adrsValue == SENSOR_LASER)
  {
    LaserBlocked = readmsg.data[0];
  }
  else if (i && readmsg.adrsValue == SENSOR_RPM)
  {
    CurrentRPM = readmsg.data[0];
  }
  readCsharp();

  //Display Sensor Data
  if (millis() - TimePassed > 500)
  {
    TimePassed = millis();

    //clear the data line:
    lcd.selectLine(2);
    lcd.clearLine(2);

    //print the Current RPM, add padding 0 if neccesary:
    lcd.print("RPM:             ");
    if (CurrentRPM < 100)  lcd.print(' ');
    if (CurrentRPM < 10)  lcd.print(' ');
    lcd.print(CurrentRPM);


    //Print the data of the led array:
    lcd.print("Laser Array:       ");
    lcd.print(LaserBlocked);


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



bool Contains(String s, String search)
{
  int total = s.length() - search.length();
  for (int i = 0; i < total + 1; i++)
  {

    if (s.substring(i, i + search.length()) == search)
    {

      return true;
    }
  }
  return false;
}



