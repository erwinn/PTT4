String s = "";
bool dangerstatus=false;
int waittime=5000;
unsigned long currenttime=0;
unsigned long oldtime=0;
unsigned long deltatime=0;
const int buttonPin = 2;
long counter=0;



void setup() {
   Serial.begin(9600);
   pinMode(buttonPin, INPUT);
}
void loop() 
{
  //ontvangen van berichten
   checkstate();
   
}
unsigned long getdeltatime()
{
  //public variable
  /*
  unsigned long currenttime=0;
unsigned long oldtime=0;
unsigned long deltatime=0;*/

     currenttime=millis();
     deltatime=currenttime-oldtime;
     oldtime=currenttime;
     return deltatime;
}

void checkstate()
{
    if(!dangerstatus)
    {
        if(digitalRead(buttonPin)==HIGH)
        {
           counter+=getdeltatime();
        }
        else
        {
          counter=0;
         
        }
        if(counter>waittime)
        {
          dangerstatus=true;
          Serial.println("send_message_danger");
        }
    }
    else
    {
      if(digitalRead(buttonPin)==LOW)
      {
          dangerstatus=false;
          Serial.println("send_message_no_danger");
      }
    }
}







void readincoming()
{
  if (Serial.available() > 0) 
  {
    while ((Serial.available() > 0))
    {
      s = s + (char)Serial.read();
      delay(1);
    }
    //////////////
    ///Serial.println("received");
    //////////////////
    s="";
  }
}


