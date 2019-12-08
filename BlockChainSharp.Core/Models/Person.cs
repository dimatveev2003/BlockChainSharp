using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainSharp.Core.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AccountNumber { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"({Name}:{Surname}:{AccountNumber}:{Password})";
        }
    }
}
