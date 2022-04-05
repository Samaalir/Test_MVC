using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMVC.Models
{
    public class Apple : Product
    {
        public Apple() : base(75,50, 77,"Apple")
        {
            //Quantity = 5;
        }

    }
}
