using System;
using System.Collections.Generic;
using System.Text;
using Laborator10___Exercitiu_1.Interfaces;
using Laborator10___Exercitiu_1.Classes;

namespace Laborator10___Exercitiu_1.Classes
{
    class CashRegister : POS
    {
        int value;
        public void Scan(int quantity)
        {
        }
        public void PayCash(int cost)
        {
            Console.WriteLine("Please introduce a cash amount you want to pay.");
            int payAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("The register is open!");
            if (payAmount <= 0)
            {
                Console.WriteLine("Invalid action: Please input a number higher than 0.");
            }
            else
            {
                payAmount -= cost;
                payAmount = value;
                Console.WriteLine($"The amount: {payAmount} was introduced in the register.");
            }
            Console.WriteLine("The register is closed!");
            Console.WriteLine("Print Receipt!");
            Console.WriteLine($"Total amount left to pay is: {cost}.");
        }
        public int GetReceipt
        {
            get { return value; }
            set { }
        }

        public void GetPos(POS pos)
        {
        }
    }
}
