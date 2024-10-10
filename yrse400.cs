using System;
Class Program{
    static void Main{
        Console.WriteLine("Enter a year");
        int year = int.Parse(Console.ReadLine());
        if ((year % 4 == 0 && year % 100 != 100) || (year % 400 ==0) ){

            Console.WriteLine("Leap Year")
        }
        else {
            Console.WriteLine("Not a Leap Year")
        }
    }
}