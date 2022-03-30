using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace creditAPI.Logic
{
  public  interface ICreditLogic
    {
        string GetDecision(int CreditAmount);

        int GetInterestRate(int CreditAmount, int ExistingCreditAmount);
    }
}
