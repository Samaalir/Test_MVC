using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMVC.Models
{
    public abstract class Product
    {
        public int _quantity;
        public string _message;
        public int _stock;
        private readonly int anotherNumber;

        protected Product(int quantity, int stock, string message)
        {
            this._quantity = quantity;
            this._stock = stock;
            this._message = message;
        }

        protected Product(int quantity, int stock, int anotherNumber, string message)
        {
            this._quantity = quantity;
            this._stock = stock;
            this.anotherNumber = anotherNumber;
            this._message = message;
        }

        public int Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
                if (this._quantity == 0)
                    Console.Write(_message);
            }
        }
    }
}
