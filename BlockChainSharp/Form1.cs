using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlockChainSharp.Core;

namespace BlockChainSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MineButton_Click(object sender, EventArgs e)
        {
            mainingLabel.Text = "maining";
            Chain chain = new Chain();
            Block block = Miner.GetBlock(chain.GetLastBlock());
            if (chain.IsValidNewBlock(block, chain.GetLastBlock()))
            {
                mainingLabel.Text = "Success";
                chain.AddBlock(block);
            }
        }
    }
}
