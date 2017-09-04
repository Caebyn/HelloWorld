using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_SW2604_01_2._0
{
    class Person
    {
        public delegate float TotalPrice();
        public TotalPrice OnTotalPrice;
        public float Total;
        public float cheeseburger = 6.52f;
        public float pizza = 7.53f;
        public float salad = 7.47f;
        public float coke = 2.99f;
        public float coffee = 3.89f;
        public float sundae = 4.40f;

        public float TotalPrice()
        {
            this.cheeseburger + 
        }
    }
}
