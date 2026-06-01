namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Time to play with temperatures.");
            bool noPress = true;
            
            do
            {
                Console.WriteLine("Are we converting from Celsius or from Fahrenheit?");
                Console.WriteLine("\n1. Celsius\n2. Fahrenheit");

                var keyPress = Console.ReadKey();
                
                switch (keyPress.Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                    case ConsoleKey.C:
                        noPress = false;
                        Console.Clear();
                        Console.WriteLine("Alrighty, from Celsius it is.");
                        var userEntryC = false;
                        do
                        {
                            Console.WriteLine("Please enter in the degrees you wish to convert.");
                            userEntryC = Double.TryParse(Console.ReadLine(), out double userDegreeC);
                            if (userEntryC)
                            {
                                Console.Clear();
                                Console.WriteLine($"The converted temp is {TempConverter.CelsiusToFahrenheit(userDegreeC):F2}");
                            }
                            
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Something is wrong. Please try again.");

                            }
                        }while (!userEntryC);
                        
                        bool validRepeatC = false;
                        do
                        {
                            Console.WriteLine("Do you want to convert another temperature? y/n");
                            var userRepeat = Console.ReadKey();
                            if (userRepeat.Key != ConsoleKey.N && userRepeat.Key != ConsoleKey.Y)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter enter y or n.");
                                validRepeatC = false;
                            }
                            else if (userRepeat.Key == ConsoleKey.Y)
                            {
                                Console.Clear();
                                validRepeatC = true;
                                noPress = true;
                            }
                            else if (userRepeat.Key == ConsoleKey.N)
                            {
                                validRepeatC = true;
                                noPress = false;
                            }
                            
                        } while (!validRepeatC);

                        break;

                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                    case ConsoleKey.F:
                        noPress = false;
                        Console.Clear();
                        Console.WriteLine("Alrighty, from Fahrenheit it is.");
                        var userEntryF = false;
                        do
                        {
                            Console.WriteLine("Please enter in the degrees you wish to convert.");
                            userEntryF = Double.TryParse(Console.ReadLine(), out double userDegreeF);
                            if (userEntryF)
                            {
                                Console.Clear();
                                Console.WriteLine($"The converted temp is {TempConverter.FahrenheitToCelsius(userDegreeF):F2}");
                            }
                            
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Something is wrong. Please try again.");

                            }
                        }while (!userEntryF);
                        
                        bool validRepeatF = false;
                        do
                        {
                            Console.WriteLine("Do you want to convert another temperature? y/n");
                            var userRepeat = Console.ReadKey();
                            if (userRepeat.Key != ConsoleKey.N && userRepeat.Key != ConsoleKey.Y)
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter enter y or n.");
                                validRepeatF = false;
                            }
                            else if (userRepeat.Key == ConsoleKey.Y)
                            {
                                Console.Clear();
                                validRepeatF = true;
                                noPress = true;
                            }
                            else if (userRepeat.Key == ConsoleKey.N)
                            {
                                validRepeatF = true;
                                noPress = false;
                            }
                            
                        } while (!validRepeatF);

                        break;
                    
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        noPress = true;
                        break;
                }
                
            } while (noPress);



        }
    }
}
