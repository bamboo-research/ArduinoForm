String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
bool f=false;

int Pin2 = 2;     
int Pin3 = 3; 
int tns=460;
int maxspeed=180;//
   
void setup() {
  // initialize serial:
  Serial.begin(9600);
  // reserve 200 bytes for the inputString:
  inputString.reserve(200);
   pinMode(Pin2, OUTPUT); 
 pinMode(Pin3, OUTPUT);
}

void loop() {
  // print the string when a newline arrives:
  if (stringComplete) { 
     Serial.println(inputString);
     String cmdstr=""; 
     String vstr="";
     bool split=false;
     for(int i=0;i<inputString.length();i++)
     {  
       if(inputString[i]== ' ')
         {
           split=true;
           continue;
          }
        if(!split)
         cmdstr+=inputString[i];
         else
         vstr+=inputString[i];
     }
       //Serial.println(cmd);
       int v=vstr.toInt();
       int cmd=cmdstr.toInt();
      
      switch(cmd)
      {
        case 0:
           {
           // Serial.println(v); 
            digitalWrite(Pin3, HIGH);
            DJ(v);
          }
        break;
        case 1:  
          {
           // Serial.println(v); 
            digitalWrite(Pin3, LOW);
            DJ(v);
          }
        break;

        case 9:
          {
            tns=v;
            
            Serial.println("The start speed:"+(String)v);
          }
        default:break;
        }

    // clear the string:
    inputString = ""; 
    stringComplete = false;
  }
   
  
}


void serialEvent() {
  while (Serial.available()) {
    if(stringComplete){Serial.read();}
    else
    {
         // get the new byte:
            char inChar = (char)Serial.read();
            // add it to the inputString:
            inputString += inChar;
            // if the incoming character is a newline, set a flag
            // so the main loop can do something about it:
            if (inChar == '\n') {
              stringComplete = true;
              
            }
      }
  }
}

void DJ(int d)
{
    int a=0;
    while(a<d)
    {
      int b=0;
          while(b<10)
              { 
                //int rv=digitalRead(Pin9);
                
                //if(rv==1)
                //{
                 // sc=sc-100;
                 // break;
                 // }
                
              delayMicroseconds(tns);  
              digitalWrite(Pin2, HIGH);   
              delayMicroseconds(tns); 
              digitalWrite(Pin2, LOW);
              b++; 
                } 
                a++; 
                //Serial.println(a);
      } 
             
  }



