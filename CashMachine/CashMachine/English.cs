using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace CashMachine
{
    #region IDisposable
    public class DisposableStandard : IDisposable
    {
        #region IDisposable
        public void Dispose()
        {

        }
        #endregion
    }
    #endregion
    #region Składowe
    /*public CSVReader CSVReaderObj = new CSVReader(this);*/
    #endregion
    public class English
    {
        public List<int> ID = new List<int>();
        public List<string> Name = new List<string>();
        public List<string> Surname = new List<string>();
        public List<string> Login = new List<string>();
        public List<string> Password = new List<string>();
        public List<string> Money = new List<string>();
        static public readonly string _WorkingDirectory = Environment.CurrentDirectory;
        public readonly string _dataBasePath = Directory.GetParent(_WorkingDirectory).Parent.FullName + @"\Client\Clients.csv";
        public int FlagLN = 0;
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

            CSVReader dataRead = new CSVReader(this);
            dataRead.Read(this);
            while (true)
            {
                processed++;
                Console.WriteLine("Login:");
                string L = Console.ReadLine();
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
            Console.WriteLine("Password:");
            int flagP = 0, processedP = 0;
            while (true)
            {
                string pass = "";
                do
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        pass += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                        {
                            pass = pass.Substring(0, (pass.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                } while (true);
                processedP++;
                foreach (var password in Password)
                {
                    if (processedP == 3)
                    {
                        Console.WriteLine("Please try again in 30 seconds");
                        //await Task.Delay(30000);
                        Thread.Sleep(30000);
                    }
                    if (password == pass)
                    {
                        flagP = 1;
                    }
                    //   else Console.WriteLine("Login is incorrect");
                }
                if (flagP == 0)
                    Console.WriteLine("Password is incorrect");
                if (flagP == 1)
                { 
                    int[] Id = ID.ToArray();
                FlagLN = Id[0];
                break;
                }
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
            //placeholder
            /*CSVWriter cSVWriter = new CSVWriter(this);
            cSVWriter.Writer(this);
            Console.WriteLine($"You got {Money[FlagLN]}");
            Console.WriteLine("How much you want to withdraw?");
            int W = (Convert.ToInt32(Console.ReadLine()));
            var CsvUpdate = string.Join(",", Money);*/

        }
        void PayIn()
        {
            //placeholder
        }
        void Transfer()
        {
            //placeholder
        }
        void MoneyAmmount()
        {
            //placeholder
        }
    }
}





