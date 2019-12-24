using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BlockChainSharp.Core.Serialization
{
    public class CustomJsonSerializer<T> : ISerializer<T>, IDisposable
    {
        public void SerializeToFile(T obj, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                string temp = JsonConvert.SerializeObject(obj, Formatting.Indented);
                sw.Write(temp);
            }
        }

        public string SerializeToString(T obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        public T DeserializeFromFile(string fileName)
        {
            string temp;
            using (StreamReader sr = File.OpenText(fileName))
            {
                temp = sr.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<T>(temp);
        }

        public void Dispose()
        {}

    }
}
