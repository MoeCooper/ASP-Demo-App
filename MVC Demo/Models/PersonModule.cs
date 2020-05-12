using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public class PersonModule
    {
        public string firstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool isAlive { get; set; } = true; // default to true

    }
}