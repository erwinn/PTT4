void setup() {
  // put your setup code here, to run once:
   pinMode(A0, INPUT);
   pinMode(A1, INPUT);
   Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.print("Sensor 1: ");
  Serial.print(analogRead(A0));
  Serial.print(", Sensor2: ");
  Serial.println(analogRead(A1));
  delay(500);
}
