using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class SodaMachine
    {
        //Member variables
        public List<Coin> register;
        public List<Can> inventory;


        //Constructor
        public SodaMachine()
        {
            register = new List<Coin>();
            inventory = new List<Can>();
            FillRegister();
            FillInventory();
        }
        //member methods
        public void DisplayInventory()
        {
            foreach (Can can in inventory)
            {
                Console.WriteLine(can.name);
                Console.WriteLine(can.Cost);
            }
        }
        public void FillRegister()
        {
             
            for(int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
                register.Add(quarter);
            }
            for(int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                register.Add(dime);
            }
            for(int i = 0; i < 20; i++)
            {
                Nickle nickle = new Nickle();
                register.Add(nickle);
            }
            for(int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                register.Add(penny);
            }
        }

        public void FillInventory()
        {
            for(int i = 0; i < 12; i++)
            {
                Rootbeer rootbeer = new Rootbeer();
                inventory.Add(rootbeer);
            }
            for (int i = 0; i < 12; i++)
            {
                Cola cola = new Cola();
                inventory.Add(cola);
            }
            for(int i = 0; i < 1; i++)
            {
                Orange_Soda orange_Soda = new Orange_Soda();
                inventory.Add(orange_Soda);
            }
        }
        public Can SellSoda()
        {
            Console.WriteLine("PLease make you choice");
             string userInput = Console.ReadLine();
            if(userInput == "Rootbeer")
            {
                int rbIndex = FindCanIndex(userInput);
                Can canToSell = inventory[rbIndex];
                inventory.RemoveAt(rbIndex);
                return canToSell;
            }
            else if(userInput == "Cola")
            {
                int colaIndex = FindCanIndex(userInput);
                Can canToSell = inventory[colaIndex];
                inventory.RemoveAt(0);
                return canToSell;
            }
            else if(userInput == "Orange Soda")
            {
                int osIndex = FindCanIndex(userInput);
                Can canToSell = inventory[osIndex];
                inventory.RemoveAt(osIndex);
                return canToSell;
            }
            else
            {
                SellSoda();
                return SellSoda();
            }
        }
        public int InsertCoins()
        {
            Console.WriteLine("Insert coins");
            Console.ReadLine();

        }
        public void Transaction(Can can, double coin)
        {

            if(can.Cost == coin)
            {
                //accept change and dispense soda
                register.Add(coin);

            }
            else if (can.Cost < coin)
            {
                //accept change dispense and return extra change
                //if not enough fund in register cancel order and return change
            }

        }
        public double DetermineCoinValue(List<Coin> coins)
        {
            double sum = 0;
            for (int i = 0; i < coins.Count; i++)
            {
                sum += coins[i].Value;
                
            }
            return sum;
        }
        public int FindCanIndex(string can)
        {
           
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].name == can)
                {
                    return i;
                }
            }
            return -1;
        }

        //function that takes in a string canName and returns the index value of the first can in the invetonry whose name matches that string

    }
}
