
/* 
 ******************************
 * Description: LINQ Test
 * Author: Leonardo de Almeida
 ******************************
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LINQTest
{
    public partial class Form1 : Form
    {
        static List<Invoice> invoices = new List<Invoice>()
        {new Invoice(87, "Electric Sander", 7, 57.98M),
         new Invoice(24, "Power Saw", 18, 99.99M),
         new Invoice(7, "Sledge Hammer", 11, 21.50M),
         new Invoice(77, "Hammer", 76, 11.99M),
         new Invoice(39, "Lawn Mower", 3, 79.50M),
         new Invoice(68, "Screw Driver", 106, 6.99M),
         new Invoice(56, "Jig saw", 21, 11.00M)};

        public Form1()
        {
            InitializeComponent();
            textBoxOriginalArray.Text = "PART NUMBER   PART DESCRIPTION   QUANTITY     PRICE\r\n\r\n";

            foreach (var element in invoices)
            {
                textBoxOriginalArray.Text += Convert.ToString(element) + "\r\n";
            }
        }

        private void buttonPartDescription_Click(object sender, EventArgs e)
        {
            textBoxSorted.Text = "PART NUMBER   PART DESCRIPTION   QUANTITY     PRICE\r\n\r\n";

            var descriptionSorted =
                from i in invoices
                orderby i.PartDescription
                select i;

            foreach (var element in descriptionSorted)
            {
                textBoxSorted.Text += Convert.ToString(element) + "\r\n";
            }
        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            textBoxSorted.Text = "PART NUMBER   PART DESCRIPTION   QUANTITY     PRICE\r\n\r\n";

            var priceSorted =
                from i in invoices
                orderby i.Price
                select i;

            foreach (var element in priceSorted)
            {
                textBoxSorted.Text += Convert.ToString(element) + "\r\n";
            }
        }


        private void buttonQuantity_Click(object sender, EventArgs e)
        {
            textBoxSorted.Text = "\r\n";

            var quantitySorted =
                from i in invoices
                orderby i.Quantity
                select new { i.Quantity, i.PartDescription };

            foreach (var element in quantitySorted)
            {
                textBoxSorted.Text += Convert.ToString(element) + "\r\n";
            }
        }
    }
}