using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample_1
{
    public class Person
    {
        private double _wallet = 0; //fields are typically named with an _ infront
        public string Name { get; set; } //properties are just fields with the getter and setter
        public int Age { get; set; }

        public void AddMoney(double moneyToAdd) //Assigning _wallet to this method to actually access this field and adding value to it
        {
            _wallet += moneyToAdd;
        }

        public double CheckWallet()
        {
            return _wallet;
        }
    }
}
