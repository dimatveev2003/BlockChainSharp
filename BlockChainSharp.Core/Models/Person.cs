using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainSharp.Core.Models
{
    public class Person
    {
        private double money;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AccountNumber { get; set; }
        public string Password { get; set; }
        public double Money => money;

        public Person()
        {
            //Количество валюты при регистрации
            money = 10;
        }

        public void IncreaseMoney(double count)
        {
            money += count;
        }

        public void DecreaseMoney(double count)
        {
            money -= count;
        }

        public override string ToString()
        {
            return $"({Name}:{Surname}:{AccountNumber})";
        }
    }
}