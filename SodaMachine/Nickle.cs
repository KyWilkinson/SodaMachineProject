using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Nickle : Coin
    {
        //Member variables
        public string nickleName;
        public double nickleValue = 0.05;


        //Constructor
        public Nickle()
        {
            nickleName = name;
            nickleValue = Value;
        }




        //Memeber methods
    }
}
