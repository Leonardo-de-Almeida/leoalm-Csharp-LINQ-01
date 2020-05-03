using System;
namespace LINQTest
{
    class Invoice
    {
        /*
         *****************************************
         *   Instance variables and Properties   *
         *****************************************
         */

        // Read-only auto-implemented properties:
        public int PartNumber { get; }
        public string PartDescription { get; }

        // Private properties:
        private int quantity;
        private decimal price;

        // Public property Quantity:
        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if (value >= 0)
                    this.quantity = value;
                else
                    this.quantity = 0;
            }
        }

        // Public property Price:
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value >= 0)
                    this.price = value;
                else
                    this.price = 0;
            }
        }

        /*
         *******************
         *   Constructor   *
         *******************
         */
        // Constructor with all four parameters:
        public Invoice(int PartNum, string PartDesc, int Qtdy, decimal InvPrice)
        {
            this.PartNumber = PartNum;
            this.PartDescription = PartDesc;
            this.Quantity = Qtdy;
            this.Price = InvPrice;
        }

        /*
         ***************************************
         *   Overriding of ToString() method   *
         ***************************************
         */

        // Overriding of ToString() method to print this object in a nicely formatted string:
        public override string ToString()
        {
            return String.Format($"{this.PartNumber,11}{this.PartDescription,19}{this.Quantity,11}{this.Price,10:C2}");
        }
    }
}
