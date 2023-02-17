using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      Console.WriteLine("How much would you like to convert?");
      string amount = Console.ReadLine();
      double numAmount = Convert.ToDouble(amount);

      Console.WriteLine($"{numAmount} is equal to...");

      int gold = 10;
      int silver = 5;

      double goldCoins = Math.Floor(numAmount / gold);
      double goldRemainder = numAmount % gold;

      double silverCoins = Math.Floor(goldRemainder / silver); 

      double remainder = silverCoins % silver;

      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");

    }
  }
}