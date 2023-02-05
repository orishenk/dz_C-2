
 // Напишите программу,
 // которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

/*
Console.Write("Введи трёхзначное число: ");
int twyDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(twyDigitNumber);
Console.WriteLine("вторая цифра этого числа "+stringNumber[1]);
*/

//Напишите программу, которая выводит третью цифру заданного числа
/*
Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
  Console.WriteLine("третья цифра " + numberText[2]);
}
else {
  Console.WriteLine("-1");
}
*/
 
//5: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным
/*
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber)
 {
  if (dayNumber == 6 || dayNumber == 7) 
  Console.WriteLine("этот день выходной ");
  
  else 
 Console.WriteLine("этот день не выходной ");
}

CheckingTheDayOfTheWeek(dayNumber);
*/