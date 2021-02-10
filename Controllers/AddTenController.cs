using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01458860Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Add 10 to integer input
        /// </summary>
        /// <param name="id">integer input</param>
        /// <returns>Total of input and 10</returns>
        /// <example>
        /// GET api/AddTen/10 -> 20
        /// </example>
        //GET api/AddTen/id
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
