using System;

namespace SweetnSaltyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
          //Variables for counting the number of sweet, salty, and sweetnsalty printed to console
          int sweetCount = 0;
          int saltyCount = 0;
          int sweetnSaltyCount = 0;

          //Loop through the numbers 1 to 1000
          for(int i = 1; i <= 1000; i++){
            //Sweet and Salty Conditional: the current number has multiples of 3 and 5
            //Print sweet'nSalty to console and increment appropiate counter
            if(i % 3 == 0 && i % 5 == 0){
              Console.Write("sweet’nSalty ");
              sweetnSaltyCount++;
            }
            //Sweet Conditional: the current number has multiple of 3
            //Print sweet to console and increment appropriate counter
            else if(i % 3 == 0){
              Console.Write("sweet ");
              sweetCount++;
            }
            //Salty Conditional: the current number has multiple of 5
            //Print salty to console and increment appropriate counter
            else if(i % 5 == 0){
              Console.Write("salty ");
              saltyCount++;
            }
            //Current number does not have the multiple of 5 or 3
            //Print the current number
            else{
              Console.Write(i+" ");
            }
            //After 10 numbers have been printed, Make a line break
            if(i % 10 == 0){
              Console.WriteLine();
            }
          }
          //Print the total number of sweet's, salty's and sweetnsalty's printed
          Console.Write($"Sweet: {sweetCount}\nSalty: {saltyCount}\nSweet'nSalty: {sweetnSaltyCount}");
        }
    }
}
