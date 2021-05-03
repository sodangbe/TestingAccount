using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;


namespace TestingAccount
{
    [TestClass]
    public class UnitTest1
    {
        private double epsilon = 1e-6;
        //private double beginningBalance = 11.99;
        //private double amount = -100.00;

        [Test]
        public void AccountCannotHaveNegativeOverdraftLimit()
        {
            Account account = new Account(-20);


            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, account.OverdraftLimit, epsilon);
        }

        [Test]
        public void AccountCannotHaveNegativeDeposit()
        {

            Account account = new Account(20);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(false, account.Deposit(-20));

        }

        public void AccountCannotHaveNegativeWithdraw()
        {

            Account account = new Account(20);

            NUnit.Framework.Assert.AreEqual(false, account.Withdraw(-20));

        }
    }
}
