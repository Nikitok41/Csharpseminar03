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
        if(number > 10000 && number < 100000) 
            return number; 
 
        else   
        { 
            Console.WriteLine("Число должно быть пятизначным"); 
 
        }   
 
    } 
    else 
    { 
        Console.WriteLine("Вы ввели не число. Нужно ввести пятизначное число"); 
 
    } 
 
} 
} 

string messageX= "Введите число х:"; 
 
int x = GetNumber(messageX); 

bool result = IsPalindrome(number); 

Console.WriteLine("");
*/

//shift+alt+f

int GetNumber(string msg) 
{ 
while(true) 
{ 
    Console.WriteLine(msg); 
    string valueFromConsole = Console.ReadLine(); 
 
    if(int.TryParse(valueFromConsole, out int number)) 
    { 
        if(number > 10000 && number < 100000) 
            return number; 
 
        else   
        { 
            Console.WriteLine("Число должно быть пятизначным"); 
 
        }   
 
    } 
    else 
    { 
        Console.WriteLine("Вы ввели не число. Нужно ввести пятизначное число"); 
 
    } 
 
} 
} 

string messageV= "Введите число v:";
int V = GetNumber(messageV); 
var V =  Console.ReadLine();
var s = V.ToString();
if (s.Reverse().SequenceEqual(s)) Console.WriteLine("Палиндром!");

bool IsPalindrome(string s)
{
    for (int i = 0; i < s.Length / 2; ++i)
        if (s[i] != s[s.Length - 1 - i]) return false;
    return true;
}