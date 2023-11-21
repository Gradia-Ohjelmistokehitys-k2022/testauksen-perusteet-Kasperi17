using BankAccountNS;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount(beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -1;
            BankAccount account = new BankAccount(beginningBalance);
            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountLessThanZeroMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }


        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {   // Arrange
            double beginningBalance = 20.55;
            double debitAmount = 30.99;

            BankAccount account = new BankAccount(beginningBalance);
            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
                
            }
            Assert.Fail("The expected exception was not thrown.");
        }
        [TestMethod]
        public void RemoveBankAccount_RemovesAccount_FromList()
        {   
              
            // Arrange
            BankCustomer customer = new BankCustomer("Mr milo");
            customer.AddBankAccount();
            int accountNumberToRemove = customer.GetBankAccounts()[0].m_accountNumber;

            // Act
            customer.RemoveBankAccount(accountNumberToRemove);

            // Assert
            Assert.AreEqual(0, customer.GetBankAccounts().Count);


        }
        [TestMethod]
        public void AddBankAccount_AddAccount_ToList()
        {   
            //Arrange
            BankCustomer customer = new BankCustomer("Jorma haavisto");

            // Act
            customer.AddBankAccount();

            // Assert
            Assert.AreEqual(1, customer.GetBankAccounts().Count);


        }
        [TestMethod]

        public void TransferMoney_TransferMoneyTo()
        {
            //Arrange
            BankAccount sourceAccount = new BankAccount(100.0);
            BankAccount destinationAccount = new BankAccount(50.0);

            // Act
            BankAccount.TransferMoney(sourceAccount, destinationAccount, 50.0); 

            // Assert
            Assert.AreEqual(50.0, sourceAccount.Balance, "SourceAccount 50.0");
            Assert.AreEqual(100.0, destinationAccount.Balance, "DestinationAccount 100.0");
        }

        
    } 
}