using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumNumberCurrencyReturned
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter price of item: ");
      double price = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter payment made: ");
      double payment = Convert.ToDouble(Console.ReadLine());


      if (price > payment)
      {
        Console.WriteLine("Not enough money to purchase");
       return ;
      }

      Console.WriteLine(ReturnCurrency(payment, price));
    }

    public static string ReturnCurrency(double paymentAmount, double price)
    {
      

      double change = paymentAmount - price;
      double major = Math.Truncate(change);
      double minor = change - major;

      double numberOf75P = 0;
      double numberOf15P = 0;
      double numberOf3P = 0;
      double numberOf1P = 0;
      double numberOfHalf = 0;
      double numberOfQuarter = 0;

      double quotient = major / 75;

      numberOf75P = Math.Truncate(quotient);

      double remainderFrom75 = major % 75;
      if (remainderFrom75 != 0)
      {
        numberOf15P = Math.Truncate(remainderFrom75 / 15);
        double remainderFrom15 = remainderFrom75 % 15;

        if (remainderFrom15 != 0)
        {
          numberOf3P = Math.Truncate(remainderFrom15 / 3);
          double remainderFrom3 = remainderFrom15 % 3;

          if (remainderFrom3 != 0)
          {
            numberOf1P = remainderFrom3;
          }
        }
      }

      if (minor != 0)
      {

        if (0.5 < minor && minor < 0.99)
        {
          numberOfHalf = 1;
          numberOfQuarter = 1;
        }

        else if (0.5 <= minor && minor < 0.75)
        {
          numberOfHalf = 1;
        }

        else if (0.25 <= minor && minor < 0.5)
        {
          numberOfQuarter = 1;
        }

        else 
        {
          numberOfQuarter = 0;
          numberOfQuarter = 0;
        }

      }
      return "number of 75P: " + numberOf75P +
        " number of 15P: " + numberOf15P + " number of 3P: " + numberOf3P +
        " number of 1P: " + numberOf1P + " number of half p: " + numberOfHalf + " number of quarter p: " + numberOfQuarter;

    }
  }
}
