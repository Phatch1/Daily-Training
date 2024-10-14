using System;

class Hello 
{
    static void Main()
    {
        string input = Console.ReadLine();
        string decodedMessage = Decode(input);

        Console.WriteLine(decodedMessage);
    }
    static string Decode(string encodedMessage)
    {
        string[] words = encodedMessage.Split(' ');
        Array.Reverse(words);
        string decodedMessage = string.Join(" ", words);
        return decodedMessage;
    }
}