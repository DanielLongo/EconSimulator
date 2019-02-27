using System;
using System.Security.Cryptography;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double startAmount = 1000;
            double[] amountsAdded = new Double[] {100, 200, 50, 250};
            double[] yearlyReturns = new double[] {.07, .04, -.05, .2};
            Console.WriteLine(calcReturn(startAmount, amountsAdded, yearlyReturns));
            Console.WriteLine((getRandomReturn()));
        }
   

    public static double calcReturn(double startAmount, double[] amountsAdded, double[] yearlyReturns)
        {
            double curReturn;
            double curAmountAdded;
            double curAmount = startAmount;
            float sum = 0;
            for (int i = 0; i < yearlyReturns.Length; i++)
            {
                curReturn = yearlyReturns[i];
                curAmountAdded = amountsAdded[i];
                curAmount = (curReturn + 1) * curAmount;
                curAmount += curAmountAdded;
            }
            return curAmount;
        }

        public static double getRandomReturn()
        {
            Random rndn = new Random();
            double posOrNeg = rndn.NextDouble();
            double delta = rndn.NextDouble();
            if (posOrNeg >= .4) return delta * .25;
            //Otherwise negative
            return delta * -.15;
        }
    }
}