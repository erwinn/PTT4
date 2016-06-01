#include <SPI.h>
#include <MCP2515.h>
#include <SoftwareSerial.h>
#include <serLCD.h>

//define Pins
#define LDR1 A0
#define LDR2 A1
#define LCDPin 6

//if The Sensors are Blocked
bool Block1;
bool Block2;

//for measuring time in the code
long TimePassed;

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
  if (millis() - TimePassed > 250)
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
  }
}
