/*int number = 120;
int firstNumber = number/100;
int lastNumber = number%10;
Console.WriteLine(firstNumber*10+lastNumber);

int a = 5;
int b = 3;
if (a % b == 0){
	Console.WriteLine("Yes");
}
else {
	Console.WriteLine("No. R = " + a % b);
}
*/

int number = 43154;
int therd = 0;
for (int i = 1 ; i<4; i++){
	therd = number%10;
	number = number / 10;	
}
if (therd > 0){
	Console.WriteLine(therd);
}
else{
	Console.WriteLine("Число не трехзначное!");
}