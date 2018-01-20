Here is a simple program that calculates 41 prime numbers in a row starting with 41. It is all written in the Main method. Break it into appropriate methods. The main should do nothing but call the starting method.

    static void Main(string[] args)
        {
            
            int number = 0;
            Console.WriteLine("Please enter an integer between 1 and 41");
            bool isInt = int.TryParse(Console.ReadLine(), out number);
            if (!isInt)
            {
                Console.WriteLine("Please enter a valid integer");
                Console.ReadKey();
                return;
            }
            if (number < 1 || number > 41)
            {
                Console.WriteLine
                  ("Please enter a valid integer between 1 and 41");
                Console.ReadKey();
                return;
            }

            int prime = number * number - number + 41;

            Console.WriteLine("The prime number is {0}", prime);

            Console.ReadKey();


        }
