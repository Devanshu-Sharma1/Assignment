using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DemoController : ApiController
    {

        // GET: Demo


        static List<string> mystrings = new List<string> { "Value0", "Value1", "Value2", "Value3" };
        public IEnumerable<string> Get()
        {
            return mystrings;
        }



        public string Get(int id)
        {
            return mystrings[id];
        }

        //public IEnumerable<string> Post([FromUri] ClassA val)
        //{
        //    mystrings.Add(val.name);
        //    return mystrings;
        //}

        //Post
        //public IEnumerable<string> Post([FromBody] string val)
        //{
        //  mystrings.Add(val);
        //return mystrings;
        //}

        public IEnumerable<string> Put(int id,[FromUri] string val)
        {
            mystrings[id -1] =val;
            return mystrings;
        }



    }
}