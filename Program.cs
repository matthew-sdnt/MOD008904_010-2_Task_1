using Task_1.Classes;

namespace Task_1
{
    internal class Program
    {
        static int input_int(string p_prompt) //Method to input integers. For this program, this is only here to provide function to the range restricted overload of this method.
        {
            //Variables
            int num;

            //Logic
            Console.Write(p_prompt); //Prompt user.
            while (!int.TryParse(Console.ReadLine(), out num)) //Takes input, loops if not a double.
            {
                Console.Clear();
                Console.WriteLine("Please input an integer."); //Error.
                Console.Write(p_prompt); //Reprompt user.
            }

            return num;
        }
        static int input_greater_than_zero_int(string p_prompt)
        {
            //Variables
            int num;
            int min = 1;

            //Logic
            do
            {
                num = input_int(p_prompt);
                if (num < min)
                {
                    Console.Clear();
                    Console.WriteLine($"Please input a number more than {min}.");
                }
            } while (num < min);

            return num;
        }
        static double input_double(string p_prompt) //Method to input doubles, this exists as a method of abstracting this logic from the main function.
        {
            //Variables
            double num;

            //Logic
            Console.Write(p_prompt); //Prompt user.
            while (!double.TryParse(Console.ReadLine(), out num)) //Takes input, loops if not a double..
            {
                Console.Clear();
                Console.WriteLine("Please input a decimal number or integer."); //Error.
                Console.Write(p_prompt); //Reprompt user.
            }

            return num;
        }
        static void Main(string[] args)
        {
            //MOD008904 010-2 Task 1 - Mean Number Calculator
            //Variables
            MeanCalculator calculator; //Uninitialised as it will be reinitialised on every loop start.
            int number_of_inputs; //Uninitialised as it will be reinitialised on every loop start.

            //Logic
            Console.WriteLine("Mean Calculator");

            while (true) //Program will reloop after an average has been calculated indefinitely, meaning multiple sets can have their mean calculated in one session.
            {
                calculator = new MeanCalculator(); //Setup the calculator instance.
                number_of_inputs = input_greater_than_zero_int("How long is the list of numbers you are calculating the mean of?\nLength: ");
                Console.Clear();
                for (int i = 0; i < number_of_inputs; i++) //Loop until all inputs are taken.
                {
                    calculator.add_entry(input_double($"Number {i + 1}: ")); //Using the behaviour of the MeanCalculator class to ensure everything goes correctly within the class.
                }
                Console.Clear();

                Console.WriteLine($"Thank you, you have inputted the following numbers, with mean of {calculator.get_mean()}:");
                calculator.display_entries();
                calculator = null; //Reset calculator.

                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

}
