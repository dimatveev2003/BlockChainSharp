using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlockChainSharp.Core;
using BlockChainSharp.Core.Models;
using BlockChainSharp.Core.Serialization;

namespace BlockChainSharp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            
            //Пример как юзать сериализацию
            /*Person person1 = new Person()
                {AccountNumber = "123456789", Name = "One", Surname = "Person", Password = "123456"};
            Person person2 = new Person()
                { AccountNumber = "123456781", Name = "Two", Surname = "Person", Password = "123456" };
            BlockDataModel data = new BlockDataModel()
                {Amount = 100, FromPerson = person1, ToPerson = person2, TransactionTime = DateTime.Now};
            BlockDataModel bdm;
            using (CustomJsonSerializer<BlockDataModel> serializer = new CustomJsonSerializer<BlockDataModel>())
            {
                bdm = serializer.DeserializeFromFile("data.json");
            }*/
        }
    }
}