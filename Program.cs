using System;
using static System.Convert;


namespace Study_console_1
{
    class Program
    {
        /*которое запрашивает у пользователя два числа в диапазоне от 0 до 255, а затем делит первое на второе. Вывод показан ниже:
          Enter a number between 0 and 255: 100
          Enter another number between 0 and 255: 8
          100 divided by 8 is 12
          Реализуйте обработчики исключений, перехватывающие любые произошедшие ошибки:
          Enter a number between 0 and 255: apples
          Enter another number between 0 and 255: bananas
          FormatException: Input string was not in a correct format.
        */

        
        static void Main(string[] args)                                                                    
        {
            bool BoolControl = false;
            double[] NumberArray= new double[2];
            for (int x = 0; x < 2; x++)
            {
                NumberArray[x] = ConvertArea();
                if (NumberArray[0] <= 255 && NumberArray[0] >= 0 )                                          // First value range check
                {
                    if(NumberArray[1] <= 255 && NumberArray[1] >= 0)                                        // Second value range check
                    {
                        BoolControl = true; 
                        continue;
                    }
                    else
                    {
                        BoolControl = false;
                        break;
                    }
                }
                else
                {
                    break; 
                } 
            }
            if (BoolControl == true)
            {
                Console.WriteLine($"{NumberArray[0] / NumberArray[1]}");
            } 
        }                                                                                                   
        static double ConvertArea()                                                                         //---------------------------------                            
        {                                                                                                   
            double Number;                                       
            try                                                                                             // Check format
            {
                string EnterValue;
                Console.WriteLine("Enter number between 0 to 255: ");
                EnterValue = Console.ReadLine();                                                            // Enter value from 0 to 255 and convert double
                Number = Convert.ToDouble(EnterValue);
                return Number;
            }
            catch(FormatException)
            {
                Console.WriteLine(" FormatException: Input string was not in a correct format.");           // If format error return invalid value
                return 256;
            }                                                                                               //--------
        }
    }
}

