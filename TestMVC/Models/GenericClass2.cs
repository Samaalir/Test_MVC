using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMVC.Models
{
    public class GenericClass2<K,T>
    {
        private K val1;
        private T val2;
        public GenericClass2(K v1, T v2)
        {
            this.val1 = v1;
            this.val2 = v2;
        }
        public K Val1
        {
            get
            {
                return this.val1;
            }
            set
            {
                this.val1 = value;
            }
        }
        public T Val2
        {
            get
            {
                return this.val2;
            }
            set
            {
                this.val2 = value;
            }
        }

    }
}
