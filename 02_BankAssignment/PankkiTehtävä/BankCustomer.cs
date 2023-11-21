using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS
{
   public class BankCustomer
   {
        public List<BankAccount> m_bankAccounts = new List<BankAccount>();
        private readonly string m_customerName;


        public BankCustomer(string customerName) 
        {
            m_customerName = customerName;

        }
        public string CustomerName
        {
            get { return m_customerName; }
        }
        
        public void AddBankAccount() 
        {

            BankAccount newAccount = new BankAccount();
            m_bankAccounts.Add(newAccount);
            

        }
        public void RemoveBankAccount(int accountNumber) 
        {
            m_bankAccounts.RemoveAll(account => account.m_accountNumber == accountNumber);
            
        }
        public List<BankAccount> GetBankAccounts()
        {
            return m_bankAccounts;
        }



    }

}
