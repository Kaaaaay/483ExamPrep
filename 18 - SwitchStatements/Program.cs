using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _18___SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trader Type App");

            Console.Write("Years in Industry: \t");
            int yearsIn = int.Parse(Console.ReadLine());
            Console.Clear();
            #region Trading Calculation App
            /*
           Console.WriteLine("Trader Type App");
           Console.Write("Trades Won: \t\t");
           int tradesWon = int.Parse(Console.ReadLine());
           Console.Clear();

           Console.WriteLine("Trader Type App");
           Console.Write("Trades Lost: \t\t");
           int tradesLost = int.Parse(Console.ReadLine());
           Console.Clear();

           Console.WriteLine("Trader Type App");
           Console.Write("Average % Loss Per Trade: \t");
           int percentageLossPerTrade = int.Parse(Console.ReadLine());
           Console.Clear();

           Console.WriteLine("Trader Type App");
           Console.Write("Average % Win per Trade: \t");
           int percentageWinPerTrade = int.Parse(Console.ReadLine());
           Console.Clear();

           Console.WriteLine("Trader Type App");
           Console.Write("Equity: \t\t");
           int equity = int.Parse(Console.ReadLine());
           Console.Clear();


           double totalTrades = tradesWon + tradesLost;
           double percentageWon = (tradesWon/ totalTrades)  *100 ;
           double percentageLost = ((totalTrades-tradesWon)/totalTrades*100);
           double accuracy  = ((percentageWinPerTrade*tradesWon) - (percentageLossPerTrade*tradesLost) / (percentageWinPerTrade * tradesWon) + (percentageLossPerTrade * tradesLost));

           Console.WriteLine("Trader Type App");

           Console.WriteLine("Equity: \t\t\t{0:C}",equity);
           Console.WriteLine("Trades Won: \t\t\t{0}",tradesWon);
           Console.WriteLine("Trades Lost: \t\t\t{0}",tradesLost);
           Console.WriteLine("% of Trades Won: \t\t{0:P}", percentageWon);
           Console.WriteLine("% of Trades Lost: \t\t{0:P}", percentageLost);
           Console.WriteLine("Average % Loss Per Trade: \t{0:P}",percentageLossPerTrade);
           Console.WriteLine("Average % Win per Trade: \t{0:P}",percentageWinPerTrade);
           Console.WriteLine("Accuracy: \t\t\t{0:P}",accuracy);

           //Console.WriteLine("\nAccuracy: \t\t{0:P}",accuracy);

           */
            #endregion


            switch (yearsIn)
            {
                case 1:
                    {
                        Console.WriteLine("Level: \t\t\t\tNovice");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Level: \t\t\t\tAdvanced Beginner");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Level: \t\t\t\tCompetent");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Level: \t\t\t\tProficient");
                        break;
                    }

                default:
                    Console.WriteLine("Level: \t\t\t\tExpert");
                    break;
            }


            Console.ReadLine();
        }
    }
}
