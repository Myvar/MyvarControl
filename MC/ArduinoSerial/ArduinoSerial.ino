
int inbyte = 0;
void setup() {
  // put your setup code here, to run once:
  
  for(int i = 2; i < 14; i++)
  {
    pinMode(i, OUTPUT);
  }
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available() >0){
     inbyte = Serial.read();
     Serial.write(inbyte);

      if(inbyte < (14))
      {
         digitalWrite(inbyte, LOW);        
      }
      else
      {
        digitalWrite(inbyte / 2, HIGH); 
      }

  }
}
