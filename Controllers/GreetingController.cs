using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01458860Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// this method will output message to greet number of people
        /// </summary>
        /// <param name="id">integer input</param>
        /// <returns>message to greet number of people based on integer input</returns>
        /// <example>
        /// GET localhost/Greeting/3 -> "Greetings to 3 people!"
        /// </example>
        //GET api/Greeting/id
        public string Get(int id)//question 4
        {
            return "Greetings to " + id+ " people!";
        }

        /// <summary>
        /// return message of Hello World!
        /// </summary>
        /// <returns>message of Hello World!</returns>
        /// <example>
        /// POST localhost/Greeting  -> "Hello World!"
        /// </example>
        //POST api/Greeting
        public string Post()//question 3
        {
            return "Hello World!";
        }

    }
}
