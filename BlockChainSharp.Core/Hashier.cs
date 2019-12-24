using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BlockChainSharp.Core.Models;

namespace BlockChainSharp.Core
{
    class Hashier
    {
        public static string GetHash(HashAlgorithm hashAlgorithm, int index, DateTime timeStamp, BlockDataModel data, string previousHash, int nonce)
        {
            byte[] byteData = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(index.ToString() + previousHash + data.ToString() + timeStamp.ToString() + nonce.ToString()));

            var sBuilder = new StringBuilder();

            for (int i = 0; i < byteData.Length; i++)
            {
                sBuilder.Append(byteData[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
