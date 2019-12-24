using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainSharp.Core
{
    public class Miner
    {
        //Генерирует блоки до тех пор, пока полученный хеш блока не будет соответствовать доказательству выполнения работы
        //доказательство выполнения работы - хеш полученного блока содержит в начале три нуля
        private static bool CheckHashRule(string hash)
        {
            return hash[0] == '0' && hash[1] == '0' && hash[2] == '0';
        }

        public static Block GetBlock(Block prevBlock)
        {
            int nonce = 0;
            Block block = new Block(prevBlock.Index + 1, prevBlock.TimeStamp, prevBlock.Data, prevBlock.Hash, nonce);
            while (!CheckHashRule(block.Hash))
            {
                nonce++;
                block = new Block(prevBlock.Index + 1, prevBlock.TimeStamp, prevBlock.Data, prevBlock.Hash, nonce);
            }
            return block;
        }
    }
}
