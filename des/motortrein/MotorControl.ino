//Calculates the speed of the motor
//
//int Accuracy,     the number wich defines how accurate the measurement is, the higher, the better
void RefreshRPM(int Accuracy)
{
  //if the wanted speed is 0, set RPM and Motor PWR to 0, else run the RPM measurement
  if (Setpoint <= 0)
  {
    //set RPM and motorspeed to 0
    analogWrite(MotorPWR, 0);
    AddValue(RPM, ItemsInArray, 0);
    CalculateAverage(RPM, ItemsInArray);
  }
  else
  {
    //Declaring Temporary Values
    int MeasurementsDone = 0;
    bool PrevValue = false;
    long TimeOfLastMeasurement = millis();

    //Measure the time over the rotation of a quarter of the full circle
    while (MeasurementsDone < (Accuracy * 2) && (millis() - TimeOfLastMeasurement) < (Accuracy * 100))
    {
      //Read if the IR sensor is Blocked Or Not
      int Val = analogRead(SpeedSensorPin);
      bool isBlocked = PrevValue;
      if (Val > 700) isBlocked = true;
      else if (Val < 200)isBlocked = false;

      //if the state changes, Proceed with the next measurement
      if (isBlocked != PrevValue)
      {
        PrevValue = isBlocked;
        MeasurementsDone++;
      }
    }

    //if the measurement timed out, set RPM to 0
    if ((millis() - TimeOfLastMeasurement) > (Accuracy * 90))
    {
      AddValue(RPM, ItemsInArray, 0);
    }

    //if the measurement was succesfull, set the RPM to the actual RPM
    else
    {
      double MeasuredTime = millis() - TimeOfLastMeasurement;
      double TimeTensSeconds = MeasuredTime / 100;
      AddValue(RPM, ItemsInArray, (30 * Accuracy) / TimeTensSeconds);
    }

    //Compute the new values for speed
    CalculateAverage(RPM, ItemsInArray);
    myPID.Compute();

    //the motor needs a little help starting up, so if the motors starts turning
    //briefly power the motor a bit harder then necessary
    if (AverageRPM == 0)
    {
      analogWrite(MotorPWR, 80);
      delay(50);
    }

    //Power the motor with the calculated Amount
    analogWrite(MotorPWR, Output);
  }
}

//Calculates the average nuber inside the array
//
//double Array[],   The array in wich all the data is stored
//int Count,        The number of items inside the Array
//
//Returns The calculated average inside the array
double CalculateAverage(double Array[], int Count)
{
  //declare local Variables
  double total = 0;
  int UsableValues = 0;

  //Look inside every value inside the array
  for (int i = 0; i < Count; i++)
  {
    //only select valid data, no timeout data
    if (Array[i] > 0)
    {
      UsableValues++;
      total += Array[i];
    }
  }

  //if there is no valid data, set AverageRPM to 0
  if (UsableValues <= 0) AverageRPM = 0;
  else AverageRPM = total / UsableValues;

  //return the AverageRPM
  return AverageRPM;
}

//Moves all values inside the array forward by one, then inserts the new value in the last index
//
//double Array[],   The array in wich all the data is stored
//int Count,        The number of items inside the Array
//double value,     The value that needs to be placed inside the array
void AddValue(double Array[], int Count, double value)
{
  //move every value forward by one
  for (int i = 0; i < Count - 1; i++)
  {
    Array[i] = Array[i + 1];
  }

  //insert a new value at the last index of the array
  Array[Count - 1] = value;
}
