using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainSharp.Core.Models
{
    public class BlockDataModel
    {
        public  DateTime TransactionTime { get; set; }
        public Person FromPerson { get; set; }
        public Person ToPerson { get; set; }
        public double Amount { get; set; }

        public override string ToString()
        {
            return $"{TransactionTime}:{FromPerson}:{ToPerson}:{Amount}";
        }
    }
}
