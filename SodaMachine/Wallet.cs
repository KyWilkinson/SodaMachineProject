using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class Wallet
    {
        //Member variables
        public List<Coin> coins;
        public Card card;
        //Constructor
        public Wallet()
        {
            coins = new List<Coin>();
            CashInWallet();
            
        }




        //Memeber methods
        public void CashInWallet()
        {
            for(int i = 0; i < 12; i++)
            {
                Quarter quarter = new Quarter();
                coins.Add(quarter);
            }
            for(int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                coins.Add(dime);
            }
            for(int i = 0; i < 15; i++)
            {
                Nickle nickle = new Nickle();
                coins.Add(nickle);
            }
            for(int i = 0; i < 25; i++)
            {
                Penny penny = new Penny();
                coins.Add(penny);
            }
        }

    }
}
