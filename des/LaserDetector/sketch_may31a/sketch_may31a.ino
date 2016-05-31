void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}
double Array[5];
double i = 0;
void loop() {
  // put your main code here, to run repeatedly:
  AddValue(Array, 5, i);
  Serial.println(CalculateAverage(Array, 5));
  delay(500);
  i++;
}

double CalculateAverage(double Array[], int Count)
{
  double total = 0;
  for (int i = 0; i < Count; i++)
  {
    total += Array[i];
  }
  return total / Count;
}

void AddValue(double Array[], int Count, double value)
{
  double total = 0;
  for (int i = 0; i < Count - 1; i++)
  {
    Array[i] = Array[i + 1];
  }
  Array[Count - 1] = value;
}
