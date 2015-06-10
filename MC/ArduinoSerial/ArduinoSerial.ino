
int inbyte = 0;
int varabyte = 0;
int varbbyte = 0;
int invarbyteloop = 0;
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
   //  Serial.write(inbyte);
      if(invarbyteloop == 0)
      {
        if(inbyte < (14))
        {
           digitalWrite(inbyte, LOW);        
        }
        if(inbyte < (14 * 2))
        {
          digitalWrite(inbyte / 2, HIGH); 
        }
        if(inbyte > (14 * 2) && inbyte < ((14 + 14) * 2))
        {     
          varabyte = (inbyte - 14) / 2;
          //Serial.write(varabyte);
          invarbyteloop = 1;
           //analogWrite(
        }
      }
      else
      {
        varbbyte = inbyte;
        analogWrite(varabyte, varbbyte);
      //  Serial.write(varabyte);
        Serial.write(varbbyte);
        invarbyteloop = 0;
      }

  }
}
