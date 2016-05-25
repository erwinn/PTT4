bool PrevValue = false;
int MeasurementsDone = 0;
long TimeOfLastMeasurement = 0;

void RefreshRPM()
{
  int Val = analogRead(SpeedSensorPin);
  bool isBlocked;
  if (Val > 700) isBlocked = true;
  else if (Val < 200)isBlocked = false;
  else isBlocked = PrevValue;

  if (isBlocked != PrevValue)
  {
    PrevValue = isBlocked;
    MeasurementsDone++;
    if (MeasurementsDone >= 10)
    {
      double Time = millis() - TimeOfLastMeasurement;
      TimeOfLastMeasurement = millis();
      Time = 1 / (Time * 4);
      Time *= 60000;
      RPM = Time;

      MeasurementsDone = 0;
    }
  }
  if (RPM != 0 && millis() - TimeOfLastMeasurement > 1000)
  {
    RPM = 0;
  }
}
