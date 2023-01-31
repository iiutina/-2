//ДЗ ко второму семинару
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*int Digits (int number)
{
    int  dec = (number /10)%10;
    return (dec);
}
Console.WriteLine("Input 3digits number:");
int user_number = Convert.ToInt32 (Console.ReadLine());
int result;
if (user_number>99 && user_number<1000)
{
    result  = Digits (user_number);
    Console.WriteLine ($"The  digit is {result}");
}
else
{
   Console.WriteLine ($"Error, your number is not 3digits");
}

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

/*int Digits (int number)
{
    while (number>1000)
           number= number/10;  

    int sot= number%10;
    return(sot);
    
     
}
Console.WriteLine("Input  number:"); 
int user_number = Convert.ToInt32 (Console.ReadLine());
int result;
if (user_number>99)
{
    result  = Digits (user_number);
    Console.WriteLine ($"The  digit is {result}");
}
else
{
   Console.WriteLine ($"Error, your number is not 3digits");
}

 /*Задачв 15.Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*void Digit (int number)
{
    if (number >=1 && number <=5)
        Console.WriteLine ("нет");
    else
        if (number >=6 && number <=7)
            Console.WriteLine ("да"); 
        else
        Console.WriteLine ("not day of the week");    
       
}
Console.WriteLine("Input  number:"); 
int user_number = Convert.ToInt32 (Console.ReadLine());

Digit (user_number);

/* Семинар 2.
Задача 1.
Напишите программу, которая получает на вход двузначное число и показывает
 наибольшую цифру числа.*/
/*Console.WriteLine("Input 2digits number:");
int user_number = Convert.ToInt32 (Console.ReadLine());
if (user_number>9 && user_number<100)
{
    int ed = user_number % 10;
    int dec = user_number/10;

    if (ed>dec)
    {
        Console.WriteLine ($"The biggist digit is {ed}");
    }
    else 
    if (dec>ed)
    {    
        Console.WriteLine ($"The biggist digit is {dec}");
    }
    else
       Console.WriteLine ($"ed=dec, it is {ed}"); 
}
*/
// Решение с методом
/*int Digits (int number)
{
    int ed = number%10;
    int dec = number / 10;
    {
        if (ed>dec)
            return ed;
        else if (ed<dec)
                return dec;
            else
                return ed;
    }
}
Console.WriteLine("Input 2digits number:");
int user_number = Convert.ToInt32 (Console.ReadLine());
int result;
if (user_number>9 && user_number<100)
{
    result  = Digits (user_number);
    Console.WriteLine ($"The biggist digit is {result}");
}
else
{
   Console.WriteLine ($"Error, your number is not 2digits");
}*/
// Задача 2 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8 
/*int DigitRondom ()
{
    int randomNum = new Random().Next (10,100);//генерация 2-ого значения, (min,max+1)
    Console.WriteLine ("generaled number is" + randomNum);

    int ed = randomNum % 10;
    int dec = randomNum/10;
    if (ed>dec)
        return (ed);
        else 
            return (dec);    
}
Console.WriteLine ("The biggist digit is" + DigitRondom ());
*/
