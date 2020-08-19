using System;
using System.Collections.Generic;
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


        //run method
        public void RunSimulation()
        {
            //welcome message
            //display wallet total
            //display soda machine options
            //make choice
            //insert money for choice
            //check inventory
            //check to see if correct amount of money is put in
            //dispense choice if in inventory or return money
            //give back change if more than exact amount is put in
            //goodbye message(enjoy your soda and please come back soon
        }
    }
}
