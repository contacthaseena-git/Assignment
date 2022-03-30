using CreditAPI.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditAPI.Model;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace CreditAPI.Controller
{

    public class CreditController : ControllerBase
    {
        private readonly ICreditLogic logic;
        public CreditController(ICreditLogic logic)
        {
            this.logic = logic;
        }
        [HttpGet]

        [Route("Decision")]
        [AllowAnonymous]
        public IActionResult creditDecision( int creditAmount,  int currentPreExistingamount,  int term)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }


            CreditDecisionandInterest credit = new CreditDecisionandInterest()
            {
                Decision = logic.GetDecision(creditAmount),
                Interest = logic.GetInterestRate(creditAmount, currentPreExistingamount)
            };
            string JSONString = JsonConvert.SerializeObject(credit);
            return Ok(JSONString);

        }



    }
}
