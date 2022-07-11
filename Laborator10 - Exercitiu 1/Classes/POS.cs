using Laborator10___Exercitiu_1.Interfaces;
using System;

namespace Laborator10___Exercitiu_1.Classes
{
    class POS : IContactFullPay, IContactlessPay, IReceipt
    {
        int cost = 0;
        public void ReceiptDescription(int quantity, int cost)
        {
            Console.WriteLine($"You have purchased {quantity} items and the total cost will be {cost}.");
        }
        void IContactFullPay.InsertCard()
        {
        }
        void IContactFullPay.ProcessPayment()
        {
        }
        void IContactFullPay.ExtractCard()
        {
        }
        void IContactlessPay.TouchSensor()
        {
        }
        void IContactlessPay.ProcessPayment()
        {
        }
        public int GetPosReceipt { get ; set; }

        public void PayContactFull(int cost,IContactFullPay contactFull)
        {
        }
        public void PayContactLess(int cost,IContactlessPay contactLess)
        {
        }
    }
}
