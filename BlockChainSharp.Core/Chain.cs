﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BlockChainSharp.Core.Models;

namespace BlockChainSharp.Core
{
    [Serializable]
    public class Chain
    {
        private List<Block> blocks;

        public List<Block> Blocks => blocks;

        public Chain()
        {
            var fromPerson = new Person()
            {
                Name = "GenesisFrom",
                Surname = "GenesisFromSur",
                Password = "GenesisFromPassword",
                AccountNumber = "GenesisFromNumber"
            };

            var toPerson = new Person()
            {
                Name = "GenesisTo",
                Surname = "GenesisToSur",
                Password = "GenesisToPassword",
                AccountNumber = "GenesisToNumber"
            };

            var genesisData = new BlockDataModel()
            {
                TransactionTime = DateTime.Now,
                FromPerson = fromPerson,
                ToPerson = toPerson,
                Amount = 0
            };
            var genesisBlock = new Block(0, DateTime.Now, genesisData,
                "816534932c2b7154836da6afc367695e6337db8a921823784c14378abed4f7d7", 0);
            blocks = new List<Block> {genesisBlock};
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

        public Block GetLastBlock()
        {
            return blocks.Last();
        }

        public bool IsValidNewBlock(Block newBlock, Block prevBlock)
        {
            if (prevBlock.Index + 1 != newBlock.Index)
                return false;
            if (prevBlock.Hash != newBlock.PreviousHash)
                return false;
            if (Hashier.GetHash(SHA256.Create(), newBlock.Index, newBlock.TimeStamp, newBlock.Data, newBlock.PreviousHash, newBlock.Nonce) != newBlock.Hash)
                return false;
            return true;
        }
    }
}