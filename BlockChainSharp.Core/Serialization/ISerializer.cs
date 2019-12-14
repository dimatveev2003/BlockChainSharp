using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainSharp.Core.Serialization
{
    interface ISerializer<T>
    {
        void SerializeToFile(T obj, string fileName);
        string SerializeToString(T obj);

        T DeserializeFromFile(string fileName);
    }
}
