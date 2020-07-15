using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace CashMachine
{
    public class English
    {
        public List<string> Name = new List<string>();
        public List<string> Surname = new List<string>();
        public List<string> Login = new List<string>();
        public List<string> Password = new List<string>();
        public List<string> Money = new List<string>();
        static private readonly string _WorkingDirectory = Environment.CurrentDirectory;
        private readonly string _dataBasePath = Directory.GetParent(_WorkingDirectory).Parent.FullName + @"\Client\Clients.csv";
        private int FlagLN = 0;
        public void ReadCSV()
        {
            using (var reader = new StreamReader($"{_dataBasePath}"))
            {
                try
                {
                    int flagCN = 0;
                    while (!reader.EndOfStream)
                    {
                        FlagLN = flagCN;
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        try
                        {
                            Name.Add(values[0]);
                        }
                        catch (Exception) { }
                        try
                        {
                            Surname.Add(values[1]);
                        }
                        catch (Exception) { }
                        try
                        {
                            Login.Add(values[2]);
                        }
                        catch (Exception) { }
                        try
                        {
                            Password.Add(values[3]);
                        }
                        catch (Exception) { }
                        try
                        {
                            Money.Add(values[4]);
                        }
                        catch (Exception) { }
                        flagCN++;
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    // Log.Save(e.Message);

                    // Any form of non internet or connection to database security. 
                    Console.WriteLine(e.Message);
                }
                finally
                {

                }
            }
        }
        public void WriteCSV()
        {
            using (FileStream fs = new FileStream(_dataBasePath, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                }
            }
        }
        private void PersonName()
        {
            Console.WriteLine($"Hello {Name[FlagLN]} {Surname[FlagLN]}");
        }
        public void MenuE()
        {
            SystemLogger();
            MenuPicker();
        }
        /// <summary>
        /// Checks person data to aprove ownership of the account.
        /// </summary>
        public void SystemLogger()
        {
            int flag = 0, processed = 0;
            ReadCSV();
            while (true)
            {
                Console.WriteLine("Login:");
                string L = Console.ReadLine();
                processed++;
                foreach (var login in Login)
                {
                    if (processed == 3)
                    {
                        Console.WriteLine("Please try again in 30 seconds");
                        Thread.Sleep(30000);
                    }
                    if (login == L)
                    {
                        flag = 1;
                    }
                    //   else Console.WriteLine("Login is incorrect");
                }
                if (flag == 0)
                    Console.WriteLine("Login is incorrect");
                if (flag == 1)
                    break;
            }
            int flagP = 0, processedP = 0;
            while (true)
            {
                Console.WriteLine("Password:");
                string P = Console.ReadLine();
                processedP++;
                foreach (var password in Password)
                {
                    if (processedP == 3)
                    {
                        Console.WriteLine("Please try again in 30 seconds");
                        //await Task.Delay(30000);
                        Thread.Sleep(30000);
                    }
                    if (password == P)
                    {
                        flagP = 1;
                    }
                    //   else Console.WriteLine("Login is incorrect");
                }
                if (flagP == 0)
                    Console.WriteLine("Password is incorrect");
                if (flagP == 1)
                    break;
            }
        }
        public void Moneyammount()
        {
            Console.WriteLine($"Your current amount of money is {Money[FlagLN]}");
        }
        public void MenuPicker()
        {
            PersonName();
            Moneyammount();
            while (true)
            {
                Console.WriteLine("***************Welcome in CashPol********************");
                Console.WriteLine("Pick 1 to check amount of money on your account");
                Console.WriteLine("Pick 2 to pay in money");
                Console.WriteLine("Pick 3 to Transfer money");
                Console.WriteLine("Pick 4 to withdraw money");
                Console.WriteLine("Pick 5 to end");
                int k = (Convert.ToInt32(Console.ReadLine()));
                switch (k)
                {
                    case 1:
                        MoneyAmmount();
                        break;
                    case 2:
                        PayIn();
                        break;
                    case 3:
                        Transfer();
                        break;
                    case 4:
                        Withdraw();
                        break;
                    case 5:
                        Environment.Exit(1);
                        break;
                }
            }

        }
        void Withdraw()
        {

        }
        void PayIn()
        {

        }
        void Transfer()
        {

        }
        void MoneyAmmount()
        {

        }
    }


}





