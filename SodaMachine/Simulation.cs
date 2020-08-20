using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Simulation
    {
        //Member variables
        public SodaMachine sodaMachine;
        public Customer customer;


        //Constructor
        public Simulation()
        {
            sodaMachine = new SodaMachine();
            customer = new Customer();
        }




        //Memeber methods
        public void WelcomeMessage()
        {
            Console.WriteLine("Please make your choice");
            Console.ReadLine();
        }


        //run method
        public void RunSimulation()
        {
            //welcome message
            WelcomeMessage();
            //display soda machine options
            sodaMachine.DisplayInventory();
            Can canToSell = sodaMachine.SellSoda();
            //make choice
            //insert money for choice
            //check inventory
            //dispense choice if in inventory or return money
            //give back change if more than exact amount is put in
            //goodbye message(enjoy your soda and please come back soon
        }
    }
}
