using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainSharp.Core
{
    class Chain
    {
        private List<Block> blocks;

        public Chain()
        {
            var genesisBlock = new Block(0, DateTime.Now, "GenesisBlock", "816534932c2b7154836da6afc367695e6337db8a921823784c14378abed4f7d7");
            blocks = new List<Block>();
            blocks.Add(genesisBlock);
        }

        public void AddBlock(Block block)
        {
            if (IsValidNewBlock(block, blocks.Last()))
                blocks.Add(block);
        }

        public List<Block> GetChain()
        {
            return blocks;
        }

        public bool IsValidNewBlock(Block newBlock, Block prevBlock)
        {
            if (prevBlock.Index + 1 != newBlock.Index)
                return false;
            if (prevBlock.Hash != newBlock.PreviousHash)
                return false;
            if (Hashier.GetHash(SHA256.Create(), newBlock.Data) != newBlock.Hash)
                return false;
            return true;
        }
    }
}
