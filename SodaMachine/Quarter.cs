using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Quarter : Coin
    {
        //Member variables
        public string quarterName;
        public double quaterValue;


        //Constructor
        public Quarter()
        {
            quarterName = name;
            quaterValue = Value;
        }




        //Memeber methods
    }
}
