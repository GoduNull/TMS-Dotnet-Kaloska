using System;
using TeachMeSkills.Kaloska.Homework6.Interface;

namespace TeachMeSkills.Kaloska.Homework6.Models
{
    internal class Account : IAccount
    {
        public Action<string> MyHandler;

        private static int count = default;
        public int Id { get; private set; }
        public decimal Sum { get; private set; }

        public Account(decimal sum)
        {
            Id = ++count;
            this.Sum = sum;
        }

        public void Put(decimal sum)
        {
            Sum += sum;
            MyHandler?.Invoke($"Receipt to the account: {sum}\n" +
                $"Account balance: {Sum}");
        }

        //Todo реалзовать отправку денег на телефон через атм
        public void PutOnThePhone(decimal sum, string phone)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                MyHandler?.Invoke($"Withdrawal from the account: {sum}\n" +
                    $"Top up phone account: {phone}\n" +
                    $"Account balance: {Sum}");
            }
            else
                MyHandler?.Invoke($"No money: {sum}\n" +
                    $"Account balance: {Sum}");
        }

        public void Withdraw(decimal sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                MyHandler?.Invoke($"Withdrawal from the account: {sum}\n" +
                    $"Account balance: {Sum}");
            }
            else
                MyHandler?.Invoke($"No money: {sum}\n" +
                    $"Account balance: {Sum}");
        }
    }
}