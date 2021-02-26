using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventEmail.Models
{
    public class Email
    {
        public string address { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Body { get; set; }
    }
}
