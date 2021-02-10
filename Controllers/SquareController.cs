using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01458860Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// calculate the square of the integer input
        /// </summary>
        /// <param name="id">integer input</param>
        /// <returns>return the square of input</returns>
        /// <example>
        /// GET localhost/Square/2 -> 4
        /// </example>
        //GET api/Square/id
        public int Get(int id)
        {
            return id * id;
        }
    }
}
