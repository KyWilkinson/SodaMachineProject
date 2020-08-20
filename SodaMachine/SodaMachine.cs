using System;
using System.Collections.Generic;
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
                Can canToSell = inventory[0];
                inventory.RemoveAt(0);
                return canToSell;
            }
            else if(userInput == "Cola")
            {
                Can canToSell = inventory[0];
                inventory.RemoveAt(0);
                return canToSell;
            }
            else if(userInput == "Orange Soda")
            {
                Can canToSell = inventory[0];
                inventory.RemoveAt(0);
                return canToSell;
            }
            else
            {
                SellSoda();
                return SellSoda();
            }
        }
        public void Transaction()
        {

        }

    }
}
