using System;
using System.Collections.Generic;
using System.Text;
using CreditAPI.Controller;
using CreditAPI.Logic;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
namespace CreditAPILogicTest
{
    public class CreditControllerTest
    {     
        [Fact]
        public void Get_NegativeCreditTest()
        {
            var logic = new Mock<ICreditLogic>();
            var controller = new CreditController(logic.Object);
            var creditamount = -5000;
            var exixtingcreditamount = -45000;
            var term = 4;
            var result = controller.creditDecision(creditamount, exixtingcreditamount, term);
            Assert.IsType<BadRequestResult>(result);
        }
        [Fact]
        public void Get_CreditDecisionTest()
        {
            var logic = new Mock<ICreditLogic>();
            var controller = new CreditController(logic.Object);
            var creditamount = 5000;
            var existingamount = 25000;
            var term = 3;
            var result = controller.creditDecision(creditamount, existingamount, term);
            Assert.IsType<OkObjectResult>(result);
        }
    }
}