const int SpeedSensor = A0;
long TimePassed;
double RPM;

void setup() {
  // put your setup code here, to run once:
  pinMode(SpeedSensor, INPUT);
  Serial.begin(9600);
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
}

