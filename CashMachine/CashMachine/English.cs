using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    public class English
    {
       
        public English() { }
        private void PersonName()
        {

        }
        public void MenuE()
        {
            //SystemLogger();
            MenuPicker();
        }
        void MenuPicker()
        {
            while(true) { 
            Console.WriteLine("***************Welcome in CashPol********************");
            Console.WriteLine("Pick 1 to check amount of money on your account money");
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
        void SystemLogger()
        {

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
