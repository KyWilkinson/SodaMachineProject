﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //Member variables
        public List<Coin> register;
        public List<Can> inventory;


        //Constructor
        public SodaMachine()
        {
            register = new List<Coin>();
            inventory = new List<Can>();
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

        }

    }
}
