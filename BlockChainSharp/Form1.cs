using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BlockChainSharp.Core;
using BlockChainSharp.Core.Models;
using BlockChainSharp.Core.Serialization;

namespace BlockChainSharp
{
    public partial class Form1 : Form
    {
        public Chain Chain;
        public Person currentPerson;
        private const string usersFile = @"users.json";
        private const string folderUsersData = @"blocks_info";

        public Form1()
        {
            InitializeComponent();

        }

        private void MineButton_Click(object sender, EventArgs e)
        {
            mainingLabel.Text = "Mining";
            Block block = Miner.GetBlock(Chain.GetLastBlock());
            if (Chain.IsValidNewBlock(block, Chain.GetLastBlock()))
            {
                mainingLabel.Text = "Success";
                Chain.AddBlock(block);
            }
            UpdateChainInfo();
        }

        private void UpdateChainInfo()
        {
            var files = Directory.GetFiles(folderUsersData);

            foreach (var file in files)
            {
                using (CustomJsonSerializer<Chain> serializer = new CustomJsonSerializer<Chain>())
                {
                    serializer.SerializeToFile(Chain, file);
                }
            }
        }

        private string ChainFilePattern()
        {
            return $"{currentPerson.AccountNumber}_chain.json";
        }

        private void InitializeChainFromStore()
        {
            var path = Path.Combine(folderUsersData, ChainFilePattern());

            using (CustomJsonSerializer<Chain> serializer = new CustomJsonSerializer<Chain>())
            {
                Chain = serializer.DeserializeFromFile(path) ?? new Chain();
                while (Chain.Blocks.Count(b => b.Index == 0) > 1)
                {
                    Chain.Blocks.Remove(Chain.Blocks.First(b => b.Index == 0));
                }
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Registration();
        }

        private void LogIn()
        {
            List<Person> persons;
            if (!File.Exists(usersFile))
            {
                MessageBox.Show("Oooops...Something was wrong!");
                return;
            }

            using (CustomJsonSerializer<List<Person>> serializer = new CustomJsonSerializer<List<Person>>())
            {
                persons = serializer.DeserializeFromFile(usersFile);
            }

            if (!persons.Any(p => p.AccountNumber == loginBox.Text && p.Password == passwordBox.Text))
            {
                MessageBox.Show("Incorrect login or password!");
                return;
            }


            currentPerson = persons.Find(p => p.AccountNumber == loginBox.Text);
            loginBox.Enabled = false;
            passwordBox.Enabled = false;

            signInButton.Enabled = false;
            signUpButton.Enabled = false;

            InitializeChainFromStore();
        }

        private void Registration()
        {
            if (loginBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Input login and password");
                return;
            }

            if (!File.Exists(usersFile))
                File.Create(usersFile).Close();

            List<Person> persons;

            using (CustomJsonSerializer<List<Person>> serializer = new CustomJsonSerializer<List<Person>>())
            {
                persons = serializer.DeserializeFromFile(usersFile) ?? new List<Person>();

                if (persons.Any(p => p.AccountNumber == loginBox.Text))
                {
                    MessageBox.Show("This login currently exist!");
                    return;
                }

                persons.Add(new Person()
                {
                    AccountNumber = loginBox.Text,
                    Password = passwordBox.Text,
                    Name = "",
                    Surname = ""
                });

                serializer.SerializeToFile(persons, usersFile);
            }

            var dataPath = Path.Combine(folderUsersData, $"{loginBox.Text}_chain.json");

            if (!Directory.Exists(folderUsersData))
                Directory.CreateDirectory(folderUsersData);

            var files = Directory.GetFiles(folderUsersData);

            File.Create(dataPath).Close();

            if (files.Length > 0)
            {
                string chainInfo;

                using (StreamReader sr = new StreamReader(files.First()))
                {
                    chainInfo = sr.ReadToEnd();
                }

                using (StreamWriter sw = new StreamWriter(dataPath, false))
                {
                    sw.Write(chainInfo);
                }

            }

            LogIn();
        }
    }
}
