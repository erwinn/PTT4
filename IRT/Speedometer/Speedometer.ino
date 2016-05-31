#include <PID_v1.h>

//Define used Pins
#define MotorPWR 3
#define MotorDir 12
#define SpeedSensorPin A5

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
double Setpoint = 50;

//Speed Sensor Data Array
double RPM[ItemsInArray];

//for measuring time in the code
long TimePassed;

//Setup PID Controller using above specified Variables
PID myPID(&AverageRPM, &Output, &Setpoint, Kp, Ki, Kd, DIRECT);

void setup() {
  Serial.begin(9600);
  
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
}

void loop()
{
  //Measure The Speed of the motor, and adjust power to the motor accordingly
  RefreshRPM(SpeedSensorAccuracy);
  if (millis() - TimePassed > 2000)
  {
    TimePassed = millis();
    Serial.print("RPM: ");
    Serial.println(AverageRPM);
  }
}
