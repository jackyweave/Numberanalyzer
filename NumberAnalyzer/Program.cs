



    
    
        int number;

        Console.WriteLine("Hello! Enter a number between 1 and 100: ");
        number = Convert.ToInt32(Console.ReadLine());

     if (number % 2 != 0 && number < 60)
        {
            Console.WriteLine($"{number} - Odd and less than 60.");
        }
      else if (number % 2 == 0 && number >= 2 && number <= 24)
        {
            Console.WriteLine("Even and less than 25.");
        }
        else if (number % 2 == 0 && number >= 26 && number <= 60)
        {
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        }
      else if (number % 2 == 0 && number > 60)
        {
            Console.WriteLine($"{number} - Even and greater than 60.");
        }
      else if (number % 2 != 0 && number > 60)
        {
            Console.WriteLine($"{number} - Odd and greater than 60.");
        }

if (number <= 0) {
    Console.WriteLine("Invalid Input (must be between 1 and 100) :/ try again");
} 
    

   




