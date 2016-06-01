/*
  serLCD - Example
*/
#include <SoftwareSerial.h>
#include <serLCD.h>
 
// Set pin to the LCD's rxPin
int pin = 6;
 
serLCD lcd(pin);
 
void setup()
{
  lcd.clear();
  lcd.print("Hello, World!");
}
 
void loop() {}

