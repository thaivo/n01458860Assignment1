using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01458860Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Calculate the total hosting cost basing on the number of days which has elapsed since the beginning of the hosting.
        /// And output 3 strings which describe the total hosting cost.
        /// </summary>
        /// <param name="id">Number of days</param>
        /// <returns>3 strings which describe the total hosting cost</returns>
        /// <example>
        /// GET api/HostingCost/0
        /// -> "1 fortnights at $5.50/FN = $5.50 CAD”
        ///     "HST 13% = $0.72 CAD"
        ///     "Total = $6.22 CAD"
        /// </example>
        //GET api/HostingCost/id
        public IEnumerable<string> Get(int id)
        {
            string []totalHostingCost = new string[3];
            int numberOfFortnights = id / 13 + 1;
            double priceBeforeTax = ((float)5.5 * numberOfFortnights);
            double tax = Math.Round((double)priceBeforeTax * 0.13,2);
            double total = tax + priceBeforeTax;
            totalHostingCost[0] = numberOfFortnights + " fortnights at $5.50/FN = $"+ priceBeforeTax +" CAD";
            totalHostingCost[1] = "HST 13% = $" + tax + " CAD";
            totalHostingCost[2] = "Total = $"+ total +" CAD”";
            return totalHostingCost;
        }
    }
}
