using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01458860Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Use 4 mathematical operations to calculate the output from the integer input. 
        /// </summary>
        /// <param name="id">Integer input</param>
        /// <returns>result after applying 4 mathematical operations to input</returns>
        /// <example>
        /// GET api/NumberMachine/10 -> 99
        /// </example>
        //GET api/NumberMachine/id
        public int Get(int id)
        {
            return (id+10)*10/2-1;
        }
    }
}
