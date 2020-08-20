using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Penny : Coin
    {
        //Member variables
        public string pennyName;
        public double pennyValue = 0.01;


        //Constructor
        public Penny()
        {
            pennyName = name;
            pennyValue = Value;
        }




        //Memeber methods
    }
}
