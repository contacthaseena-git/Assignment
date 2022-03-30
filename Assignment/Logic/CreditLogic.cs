using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditAPI.Logic
{
    public class CreditLogic:ICreditLogic
    {
        public string GetDecision(int CreditAmount)
        {
            string decision = null;
            if (CreditAmount < 2000)
            {
                decision = "No";
            }
            else if (CreditAmount >= 2000 && CreditAmount <= 69000)
            {
                decision = "Yes";
            }
            else if (CreditAmount > 69000)
            {
                decision = "No";
            }
            return decision;
        }
        public int GetInterestRate(int CreditAmount, int ExisitingCreditAmount)
        {
            int InterestRate = 0;
            double futuredebt = CreditAmount + ExisitingCreditAmount;
            if (futuredebt < 20000)
            {
                InterestRate = 3;
            }
            else if (futuredebt >= 20000 && futuredebt <= 39000)
            {
                InterestRate = 4;
            }
            else if (futuredebt >= 40000 && futuredebt <= 59000)
            {
                InterestRate = 5;
            }
            else if (futuredebt >= 60000)
            {
                InterestRate = 6;
            }
            return InterestRate;
        }
    }
}