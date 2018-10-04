using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversions


            Money m = new Money(5.0M);
            decimal d1 = m;
            int x = (int)m;

            Console.WriteLine(x);
            Console.ReadLine();
        }

    }

    class Money
    {

        public Money(decimal amount)
        {

            this.Amount = amount;

        }
        public decimal Amount { get; set; }

        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }

        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }
    }
}
