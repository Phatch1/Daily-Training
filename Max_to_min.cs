using System;
using System.Collections.Generic;
  class Hello 
  {
	 static void Main() {
		
    	List<int> numbers = new List<int>();
        string input;

        while(true)
        {
          input = Console.ReadLine().Trim();
           if(input.Equals("max", StringComparison.OrdinalIgnoreCase))

             {
              break;
             }
            try
              {
                int number = int.Parse(input);
                  numbers.Add(number);
              }
            catch(FormatException)
             {
                continue;
             }
        }

      numbers.Sort();
      numbers.Reverse();
      Console.WriteLine(string.Join(" ",numbers));
    
	}
}