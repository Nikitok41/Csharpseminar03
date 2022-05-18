/* 
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
23432 -> да
12821 -> да

*/

/*
int GetNumber(string msg)
{
while(true)
{
    Console.WriteLine(msg);
    string valueFromConsole = Console.ReadLine();

    if(int.TryParse(valueFromConsole, out int number))
    {
        if(number != 0)  
            return number;
        else
        {
            Console.WriteLine("Число должно отличаться от 0. Введите другое число");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля.");
    }
}
}

string messageX = "Введите число х: ";


int x = GetNumber(messageX);


int quater = GetQuarter(x);

Console.WriteLine($"");
*/






int GetNumber(string msg) { 
while(true){ 
    Console.WriteLine(msg); 
    string valueFromConsole = Console.ReadLine(); 
    if(int.TryParse(valueFromConsole, out int number)) { 
        if(number > 10000 && number < 100000) 
            return number; 
        else{ 
            Console.WriteLine("Число должно быть пятизначным"); 
        }   
    } 
    else{Console.WriteLine("Вы ввели не число. Нужно ввести пятизначное число");
    } 
    } 
} 
 
bool IsPalindrome(string number) { 
 for (int i =0; i < number.Length / 2; ++i) 
 { 
       if (number[i] != number[number.Length -1 - i]) 
   return false; 
  }   
  return true; 
} 
string message = "Введите пятизначное число: "; 
 
 
int x = GetNumber(message); 
bool result = IsPalindrome(true); 
Console.WriteLine(result);