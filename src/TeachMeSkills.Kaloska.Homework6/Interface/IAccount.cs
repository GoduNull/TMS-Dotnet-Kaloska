namespace TeachMeSkills.Kaloska.Homework6.Interface
{
    internal interface IAccount
    {
        void Put(decimal sum);

        void PutOnThePhone(decimal sum, string phone);

        void Withdraw(decimal sum);
    }
}