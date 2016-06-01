#include <PID_v1.h>
#include <SPI.h>
#include <MCP2515.h>
#include <SoftwareSerial.h>
#include <serLCD.h>

#define TREIN 0x7d3

CANMSG msg;
MCP2515 can;

//Define used Pins
#define MotorPWR 3
#define MotorDir 12
#define SpeedSensorPin A5
#define LCDPin 6

//Motor Constants
#define MotorPowerMin 30      //the motor does not run under this value, it will stop
#define MotorPowerMax 255     //the motor will show strange behaviour if this number is exceeded

//The Wanted Accuracy (>0). the higher the number, the longer the test runs, and the more accurate the result is
//Default = 5, a full circle = 20
#define SpeedSensorAccuracy 5

//Smoothing of SpeedData (>0)
#define ItemsInArray 5

//PID constants (0.1, 0.5, 0.0)
#define Kp 0.1
#define Ki 0.5
#define Kd 0.0

//PID Variables
double Output;
double AverageRPM;
double Setpoint = 0;

//Speed Sensor Data Array
double RPM[ItemsInArray];

//for measuring time in the code
long TimePassed;

//Setup PID Controller using above specified Variables
PID myPID(&AverageRPM, &Output, &Setpoint, Kp, Ki, Kd, DIRECT);

//Define SerialLCD Display
serLCD lcd(LCDPin);

void setup()
{
  //init Display
  lcd.setBrightness(30);
  lcd.clear();
  lcd.print("Speedometer");

  //Set PinMode
  pinMode(SpeedSensorPin, INPUT);
  pinMode(MotorPWR, OUTPUT);
  pinMode(MotorDir, OUTPUT);

  //set the motor in the correct Direction
  digitalWrite(MotorDir, LOW);

  //Turn the PID Controller ON:
  myPID.SetMode(HIGH);

  //Time between each PID calculation:
  myPID.SetSampleTime(200);

  //set limits to the output, in this case the motor
  myPID.SetOutputLimits(MotorPowerMin, MotorPowerMax);

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
    Setpoint = msg.data[0];
  }
  //MotorControl
  RefreshRPM(SpeedSensorAccuracy);

  //Display Sensor Data
  if (millis() - TimePassed > 2000)
  {
    TimePassed = millis();
    
    //clear the data line:
    lcd.selectLine(2);
    lcd.clearLine(2);

    //print the Current RPM, add padding 0 if neccesary:
    lcd.print("RPM:          ");
    if (AverageRPM < 100)  lcd.print('0');
    if (AverageRPM < 10)  lcd.print('0');
    lcd.print(AverageRPM);

    //print the Current Output, add padding 0 if neccesary:
    lcd.print("Output:       ");
    if (Output < 100)  lcd.print('0');
    if (Output < 10)  lcd.print('0');
    lcd.print(Output);

    //print the Current Setpoint, add padding 0 if neccesary:
    lcd.print("Setpoint:     ");
    if (Setpoint < 100)  lcd.print('0');
    if (Setpoint < 10)  lcd.print('0');
    lcd.print(Setpoint);
  }
}
