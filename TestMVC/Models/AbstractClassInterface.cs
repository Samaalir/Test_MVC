using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMVC.Models
{
    public abstract class classA
    {
        public classA()
        {

        }
        public abstract void doThis();
        public abstract void doThat();
        public abstract string dontDoThis();
        public abstract int dontDThat();
    }
    public abstract class classB
    {
    }
}
