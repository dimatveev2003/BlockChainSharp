using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainSharp.Core
{
    class Hashier
    {
        public static string GetHash(HashAlgorithm hashAlgorithm, string data)
        {
            byte[] byteData = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(data));

            var sBuilder = new StringBuilder();

            for (int i = 0; i < byteData.Length; i++)
            {
                sBuilder.Append(byteData[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
