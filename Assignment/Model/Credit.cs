using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace CreditAPI.Model
{
    public class Credit
    {
        [Required] [Range(1, int.MaxValue, ErrorMessage = "Please enter valid Credit Amoubt")] public int creditAmount { get; set; }
        [Required] public int Termforpayment { get; set; }
        [Required] [Range(1, int.MaxValue, ErrorMessage = "Please enter valid Pre existing Credit Amount")] public int currentPreExistingamount { get; set; }
    }
    public class CreditDecisionandInterest
    {
        public string Decision { get; set; }
        public int Interest { get; set; }
    }
}