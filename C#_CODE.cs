#include <SoftwareSerial.h>
SoftwareSerial BTSerial(2,3); //RX / TX
 
const int FLEX_PIN1 = A0;
const int FLEX_PIN2 = A1;
const int FLEX_PIN3 = A2;
const int FLEX_PIN4 = A3;
const int FLEX_PIN5 = A4;
const int xpin = A5;
const int ypin =A6;
 
const float VCC1 = 5;
const float VCC2 = 5;
const float VCC3 = 5;
const float VCC4 = 5;
const float VCC5 = 5;
 
const float R_DIV1 = 10000.0;
const float R_DIV2 = 10000.0;
const float R_DIV3 = 10000.0;
const float R_DIV4 = 10000.0;
const float R_DIV5 = 10000.0;
 
const float flatResistance1 = 25000.0;
const float flatResistance2 = 25000.0;
const float flatResistance3 = 25000.0;
const float flatResistance4 = 25000.0;
const float flatResistance5 = 25000.0;
 
const float bendResistance1 = 100000.0;
const float bendResistance2 = 100000.0;
const float bendResistance3 = 100000.0;
const float bendResistance4 = 100000.0;
const float bendResistance5 = 100000.0;
 
void setup() {
  Serial.begin(9600);
  pinMode(FLEX_PIN1, INPUT);
  pinMode(FLEX_PIN2, INPUT);
  pinMode(FLEX_PIN3, INPUT);
  pinMode(FLEX_PIN4, INPUT);
  pinMode(FLEX_PIN5, INPUT);
  pinMode(xpin, INPUT);
  pinMode(ypin, INPUT);  
 
  BTSerial.begin(9600);
}
 
 
void loop() {
 
  if (BTSerial.available())
    Serial.write(BTSerial.read());
    
  if (Serial.available())
    BTSerial.write(Serial.read());
  
  int flexADC1 = analogRead(FLEX_PIN1);
  float Vflex1 = flexADC1 * VCC1 / 1023.0;
  float Rflex1 = R_DIV1 * (VCC1 / Vflex1 - 1.0);
  //Serial.println("Resistance: " + String(Rflex1) + " ohms");
 
  float angle1 = map(Rflex1, flatResistance1, bendResistance1, 0, 90.0);
  //Serial.println("Bend: " + String(angle1) + " degrees");
  //Serial.println();
 
  int flexADC2 = analogRead(FLEX_PIN2);
  float Vflex2 = flexADC2 * VCC2 / 1023.0;
  float Rflex2 = R_DIV2 * (VCC2 / Vflex2 - 1.0);
  //Serial.println("Resistance: " + String(Rflex2) + " ohms");
 
  float angle2 = map(Rflex2, flatResistance2, bendResistance2, 0, 90.0);
  //Serial.println("Bend: " + String(angle2) + " degrees");
  //Serial.println();
  
  int flexADC3 = analogRead(FLEX_PIN3);
  float Vflex3 = flexADC3 * VCC3 / 1023.0;
  float Rflex3 = R_DIV3 * (VCC3 / Vflex3 - 1.0);
  //Serial.println("Resistance: " + String(Rflex3) + " ohms");
 
  float angle3 = map(Rflex3, flatResistance3, bendResistance3, 0, 90.0);
  //Serial.println("Bend: " + String(angle3) + " degrees");
  //Serial.println();
 
  int flexADC4 = analogRead(FLEX_PIN4);
  float Vflex4 = flexADC4 * VCC4 / 1023.0;
  float Rflex4 = R_DIV4 * (VCC4 / Vflex4 - 1.0);
  //Serial.println("Resistance: " + String(Rflex4) + " ohms");
 
  float angle4 = map(Rflex4, flatResistance4, bendResistance4, 0, 90.0);
  //Serial.println("Bend: " + String(angle4) + " degrees");
  //Serial.println();
  
  int flexADC5 = analogRead(FLEX_PIN5);
  float Vflex5 = flexADC5 * VCC5 / 1023.0;
  float Rflex5 = R_DIV5 * (VCC5 / Vflex5 - 1.0);
  //Serial.println("Resistance: " + String(Rflex5) + " ohms");
  
  float angle5 = map(Rflex5, flatResistance5, bendResistance5, 0, 90.0);
  //Serial.println("Bend: " + String(angle5) + " degrees");
  //Serial.println();
 
  int xadc = analogRead(xpin);
  int yadc = analogRead(ypin);
 
if(((angle1>=70)&&(angle1<=82))&&((angle2>=77)&&(angle2<=90))&&((angle3>=70)&&(angle3<=86))&&((angle4>=73)&&(angle4<=85))&&((angle5>=0)&&(angle5<=45)))
Serial.println('A');
if(((angle1>=0)&&(angle1<=10))&&((angle2>=0)&&(angle2<=10))&&((angle3>=0)&&(angle3<=12))&&((angle4>=0)&&(angle4<=10))&&((angle5>=65)&&(angle5<=80)))
Serial.println('B');
if(((angle1>=40)&&(angle1<=72))&&((angle2>=50)&&(angle2<=90))&&((angle3>=51)&&(angle3<=75))&&((angle4>=42)&&(angle4<=66))&&((angle5>=34)&&(angle5<=50)))
Serial.println('C');
if(((angle1>=50)&&(angle1<=72))&&((angle2>=45)&&(angle2<=90))&&((angle3>=35)&&(angle3<=75))&&((angle4>=0)&&(angle4<=10))&&((angle5>=45)&&(angle5<=80))&&!(((xadc>=412)&&(xadc<=418))&&((yadc>=340)&&(yadc<=360))))
Serial.println('D');
if(((angle1>=68)&&(angle1<=88))&&((angle2>=68)&&(angle2<=90))&&((angle3>=50)&&(angle3<=80))&&((angle4>=54)&&(angle4<=80))&&((angle5>=58)&&(angle5<=88)))
Serial.println('E');
if(((angle1>=0)&&(angle1<=10))&&((angle2>=0)&&(angle2<=10))&&((angle3>=0)&&(angle3<=10))&&((angle4>=15)&&(angle4<=45))&&((angle5>=34)&&(angle5<=65)))
Serial.println('F');
if(((angle1>=75)&&(angle1<=90))&&((angle2>=75)&&(angle2<=90))&&((angle3>=65)&&(angle3<=90))&&((angle4>=0)&&(angle4<=15))&&((angle5>=0)&&(angle5<=30))&&(((xadc>=400)&&(xadc<=420))&&((yadc>=340)&&(yadc<=360))))
Serial.println('G');
if(((angle1>=70)&&(angle1<=85))&&((angle2>=75)&&(angle2<=90))&&((angle3>=0)&&(angle3<=10))&&((angle4>=0)&&(angle4<=10))&&((angle5>=50)&&(angle5<=65))&&!(((xadc>=410)&&(xadc<=420))&&((yadc>=368)&&(yadc<=380))))
Serial.println('H');
if(((angle1>=0)&&(angle1<=10))&&((angle2>=50)&&(angle2<=70))&&((angle3>=50)&&(angle3<=70))&&((angle4>=50)&&(angle4<=70))&&((angle5>=50)&&(angle5<=85)&&((xadc>=410)&&(xadc<=420))&&((yadc>=330)&&(yadc<=370))))
Serial.println('I');
if(((angle1>=0)&&(angle1<=10))&&((angle2>=50)&&(angle2<=70))&&((angle3>=50)&&(angle3<=70))&&((angle4>=50)&&(angle4<=70))&&((angle5>=50)&&(angle5<=85))&&(!((xadc>=410)&&(xadc<=420))&&((yadc>=355)&&(yadc<=370))))
Serial.println('J');
if(((angle1>=60)&&(angle1<=75))&&((angle2>=60)&&(angle2<=85))&&((angle3>=0)&&(angle3<=10))&&((angle4>=0)&&(angle4<=15))&&((angle5>=30)&&(angle5<=55))&&(((xadc>=404)&&(xadc<=415))&&((yadc>=368)&&(yadc<=380))))
Serial.println('K');
if(((angle1>=75)&&(angle1<=90))&&((angle2>=75)&&(angle2<=90))&&((angle3>=70)&&(angle3<=90))&&((angle4>=0)&&(angle4<=15))&&((angle5>=0)&&(angle5<=30))&&(((xadc>=390)&&(xadc<=405))&&((yadc>=360)&&(yadc<=380)))&&!((xadc>=270)&&(xadc<=300))&&((yadc>=360)&&(yadc<=390)))
Serial.println('L');
if(((angle1>=40)&&(angle1<=61))&&((angle2>=72)&&(angle2<=84))&&((angle3>=45)&&(angle3<=65))&&((angle4>=62)&&(angle4<=75))&&((angle5>=65)&&(angle5<=86)))
Serial.println('M');
if(((angle1>=54)&&(angle1<=70))&&((angle2>=50)&&(angle2<=61))&&((angle3>=48)&&(angle3<=66))&&((angle4>=60)&&(angle4<=76))&&((angle5>=50)&&(angle5<=65))&&(((xadc>=400)&&(xadc<=435))&&((yadc>=350)&&(yadc<=390))))
Serial.println('N');
if(((angle1>=68)&&(angle1<=88))&&((angle2>=68)&&(angle2<=90))&&((angle3>=50)&&(angle3<=80))&&((angle4>=54)&&(angle4<=80))&&((angle5>=0)&&(angle5<=30)))
Serial.println('O');
if(((angle1>=60)&&(angle1<=75))&&((angle2>=60)&&(angle2<=85))&&((angle3>=0)&&(angle3<=10))&&((angle4>=0)&&(angle4<=15))&&((angle5>=30)&&(angle5<=55))&&(((xadc>=270)&&(xadc<=290))&&((yadc>=360)&&(yadc<=380))))
Serial.println('P');
if(((angle1>=75)&&(angle1<=90))&&((angle2>=75)&&(angle2<=90))&&((angle3>=65)&&(angle3<=90))&&((angle4>=0)&&(angle4<=15))&&((angle5>=0)&&(angle5<=30))&&(((xadc>=270)&&(xadc<=300))&&((yadc>=360)&&(yadc<=390))))
Serial.println('Q');
if(((angle1>=40)&&(angle1<=72))&&((angle2>=45)&&(angle2<=90))&&((angle3>=20)&&(angle3<=45))&&((angle4>=0)&&(angle4<=10))&&((angle5>=45)&&(angle5<=80))&&(((xadc>=412)&&(xadc<=418))&&((yadc>=340)&&(yadc<=360))))
Serial.println('R');
if(((angle1>=70)&&(angle1<=90))&&((angle2>=80)&&(angle2<=90))&&((angle3>=80)&&(angle3<=90))&&((angle4>=80)&&(angle4<=90))&&((angle5>=60)&&(angle5<=80)))
Serial.println('S');
if(((angle1>=40)&&(angle1<=61))&&((angle2>=72)&&(angle2<=84))&&((angle3>=45)&&(angle3<=65))&&((angle4>=44)&&(angle4<=63))&&((angle5>=65)&&(angle5<=86))&&(digitalRead(6)==HIGH))
Serial.println('T');
if(((angle1>=70)&&(angle1<=90))&&((angle2>=80)&&(angle2<=90))&&((angle3>=0)&&(angle3<=10))&&((angle4>=0)&&(angle4<=10))&&((angle5>=60)&&(angle5<=80)))
Serial.println('U');
if(((angle1>=70)&&(angle1<=90))&&((angle2>=80)&&(angle2<=90))&&((angle3>=0)&&(angle3<=10))&&((angle4>=0)&&(angle4<=10))&&((angle5>=60)&&(angle5<=80))&&(digitalRead(6)==HIGH)) 
Serial.println('V');
if(((angle1>=70)&&(angle1<=90))&&((angle2>=0)&&(angle2<=10))&&((angle3>=0)&&(angle3<=10))&&((angle4>=0)&&(angle4<=10))&&((angle5>=60)&&(angle5<=80)))
Serial.println('W');
if(((angle1>=50)&&(angle1<=72))&&((angle2>=45)&&(angle2<=90))&&((angle3>=35)&&(angle3<=75))&&((angle4>=80)&&(angle4<=89))&&((angle5>=45)&&(angle5<=80)))//&&!(((xadc>=412)&&(xadc<=418))&&((yadc>=340)&&(yadc<=360))))
Serial.println('X');
if(((angle1>=0)&&(angle1<=10))&&((angle2>=70)&&(angle2<=90))&&((angle3>=60)&&(angle3<=80))&&((angle4>=80)&&(angle4<=90))&&((angle5>=15)&&(angle5<=35)))
Serial.println('Y');
if(((angle1>=50)&&(angle1<=72))&&((angle2>=45)&&(angle2<=90))&&((angle3>=35)&&(angle3<=75))&&((angle4>=0)&&(angle4<=10))&&((angle5>=45)&&(angle5<=80))&&(((xadc>=412)&&(xadc<=418))&&((yadc>=340)&&(yadc<=360))))
Serial.println('Z');
 
 
delay (10000);
 
}
 
[/code]
