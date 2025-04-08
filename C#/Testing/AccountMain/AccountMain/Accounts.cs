namespace AccountMain
{
    public class Accounts
    {
        string Acno;
        float Balance;

        public Accounts(string accno)
        {
            Acno = accno;
        }

        public void Deposit(float amount) 
        {
            Balance += amount;
        }

        public float GetBalance() 
        { 
            return Balance;
        }
        public void Withdraw(float amount) 
        {
            if (Balance > amount)
                Balance -= amount;
            else
                throw new Exception("Not Enough Funds to withdraw..");
        }
    }
}
