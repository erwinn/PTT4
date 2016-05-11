#include <PID_v1.h>

#define MotorPWR 3
#define MotorDir 12
#define SpeedSensorPin A5

double Output;

long TimePassed;
double RPM;
double Setpoint = 160;
  
PID myPID(&RPM, &Output, &Setpoint, 0.6, 0.5, 0.1, DIRECT);

void setup() {
  // put your setup code here, to run once:
  pinMode(SpeedSensorPin, INPUT);
  pinMode(MotorPWR, OUTPUT);
  pinMode(MotorDir, OUTPUT);
  digitalWrite(MotorDir, LOW);
  
  Serial.begin(9600);

  myPID.SetMode(AUTOMATIC);
}

void loop()
{
  RefreshRPM();
  if ((millis() - TimePassed) > 1000)
  {
    Serial.print("RPM: ");
    Serial.println(RPM);
    TimePassed = millis();
  }
  myPID.Compute();
  analogWrite(MotorPWR, Output);
}
