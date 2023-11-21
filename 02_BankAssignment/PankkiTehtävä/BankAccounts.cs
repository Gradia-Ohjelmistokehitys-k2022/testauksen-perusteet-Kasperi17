using System;

namespace BankAccountNS
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class BankAccount
    {
        
        private double m_balance;
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public  int m_accountNumber { get;  set; }
        private int m_nextNumber = 1;


        
        public BankAccount() 
        {
            m_accountNumber = m_nextNumber;
            m_nextNumber++;

        }
        public BankAccount(double balance)
        {
            m_balance = balance;
           
            
        }
        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);

            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Cant withdraw negative amounts", amount, DebitAmountLessThanZeroMessage);
            }

            m_balance -= amount;
            //lähtötili
        }
        
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
            //kohdetili
        }
        public static void TransferMoney(BankAccount sourceAccount, BankAccount destinationAccount, double maara)
        {
            if (maara > sourceAccount.Balance)
            {
                throw new ArgumentException("Debit amount exceeds balance");
            }
            sourceAccount.Debit(maara);
            destinationAccount.Credit(maara);
            

        }

        public static void Main()
        {
            BankAccount ba = new BankAccount(11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            BankCustomer nimi = new BankCustomer("moi");
        }
    }
}