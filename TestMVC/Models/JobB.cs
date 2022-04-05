using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace TestMVC.Models
{
    public class JobB : classA
    {
        public JobB()
        {

        }

        public override string dontDoThis()
        {
            return "dontDoThis";
        }

        public override int dontDThat()
        {
            return 3;
        }

        public override void doThat()
        {
            
        }

        public override void doThis()
        {
            Console.Write("override dothis()");
        }
    }
}
