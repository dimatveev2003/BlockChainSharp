using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using BlockChainSharp.Core.Models;

namespace BlockChainSharp.Core
{
    [Serializable]
    public class Block
    {
        private readonly int index;
        private readonly DateTime timeStamp;
        private readonly string hash;
        private readonly BlockDataModel data;
        private readonly string previousHash;
        private readonly int nonce;

        public BlockDataModel Data => data;
        public string Hash => hash;
        public int Index => index;
        public string PreviousHash => previousHash;
        public DateTime TimeStamp => timeStamp;
        public int Nonce => nonce;

        public Block(int index, DateTime timeStamp, BlockDataModel data, string previousHash, int nonce)
        {
            this.index = index;
            this.timeStamp = timeStamp;
            this.previousHash = previousHash;
            this.data = data;
            this.nonce = nonce;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                hash = Hashier.GetHash(sha256Hash, index, timeStamp, data, previousHash, nonce);
            }
        }
    }
}
