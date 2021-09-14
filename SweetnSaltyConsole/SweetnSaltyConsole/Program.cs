using System;

namespace SweetnSaltyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
          int sweetCount = 0;
          int saltyCount = 0;
          int sweetnSaltyCount = 0;
          for(int i = 1; i <= 1000; i++){
            //Sweet and Salty Conditional
            if(i % 3 == 0 && i % 5 == 0){
              Console.Write("sweet’nSalty ");
              sweetnSaltyCount++;
            }
            //Sweet Conditional
            else if(i % 3 == 0){
              Console.Write("sweet ");
              sweetCount++;
            }
            //Salty Conditional
            else if(i % 5 == 0){
              Console.Write("salty ");
              saltyCount++;
            }
            else{
              Console.Write(i+" ");
            }
            if(i % 10 == 0){
              Console.WriteLine();
            }
          }
          Console.Write($"Sweet: {sweetCount}\nSalty: {saltyCount}\nSweet'nSalty: {sweetnSaltyCount}");
        }
    }
}
