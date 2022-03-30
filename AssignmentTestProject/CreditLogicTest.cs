using CreditAPI.Logic;
using System;
using Xunit;

namespace CreditAPITest
{
    public class CreditLogicTest
    {
        [Fact]
        public void decision_less_than_two_thousand()
        {
            var logic = new CreditLogic();

            int CreditAmount = 1000;

            var result = logic.GetDecision(CreditAmount);

            Assert.Equal(result, "No");
        }

        [Fact()]
        public void decision_Equals_two_thousand()
        {
            var logic = new CreditLogic();

            int CreditAmount = 2000;

            var result = logic.GetDecision(CreditAmount);

            Assert.Equal(result, "Yes");
        }

        [Fact()]
        public void decision_greater_than_two_thousand()
        {
            var logic = new CreditLogic();

            int CreditAmount = 3000;

            var result = logic.GetDecision(CreditAmount);

            Assert.Equal(result, "Yes");
        }

        [Fact()]
        public void decision_equals_sixtynine_thousand()
        {
            var logic = new CreditLogic();

            int CreditAmount = 69000;

            var result = logic.GetDecision(CreditAmount);

            Assert.Equal(result, "Yes");
        }

        [Fact()]
        public void decision_greater_than_sixtynine_thousand()
        {
            var logic = new CreditLogic();

            int CreditAmount = 70000;

            var result = logic.GetDecision(CreditAmount);

            Assert.Equal(result, "No");
        }

        [Fact]
        public void interest_greater_than_twenty_thousand()
        {
            var logic = new CreditLogic();

            int CreditAmount = 1000;

            int existingcreditamount = 15000;

            var result = logic.GetInterestRate(CreditAmount, existingcreditamount);

            Assert.Equal(result, 3);
        }

        [Fact]
        public void interest_less_than_thirtynine_thousand()
        {
            var logic = new CreditLogic();

            int CreditAmount = 1000;

            int existingcreditamount = 25000;

            var result = logic.GetInterestRate(CreditAmount, existingcreditamount);

            Assert.Equal(result, 4);
        }

        [Fact]
        public void interest_less_than_fiftynine_Thousand()
        {
            var logic = new CreditLogic();

            int CreditAmount = 1000;

            int existingcreditamount = 45000;

            var result = logic.GetInterestRate(CreditAmount, existingcreditamount);

            Assert.Equal(result, 5);
        }

        [Fact]
        public void interest_less_than_sixty_thousand()
        {
            var logic = new CreditLogic();

            int CreditAmount = 1000;

            int existingcreditamount = 65000;

            var result = logic.GetInterestRate(CreditAmount, existingcreditamount);

            Assert.Equal(result, 6);
        }

    }
}
