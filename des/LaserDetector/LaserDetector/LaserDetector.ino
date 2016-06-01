int LDR1 = A0;
int LDR2 = A1;
int Value1 = 0;
int Value2 = 0;
bool Block1;
bool Block2;

void setup() {
  // put your setup code here, to run once:
   pinMode(LDR1, INPUT);
   pinMode(LDR2, INPUT);
   Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
 
  Value1 = analogRead(LDR1), Value2 = analogRead(LDR2);  
  if (Value1 > 800)
  {
      Block1 = true;
      //Serial.println("S1 is BLOCKED");
  }
  else{ 
    Block1 = false;
  }

  if (Value2 > 800)
  {
    Block1 = true;
    //Serial.println("S2 is BLOCKED");
  }
  else{
    Block2 = false;
  }
  delay(500);
}
