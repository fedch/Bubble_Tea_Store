using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {   
            // Give labels the details passed by the user:
            lblName.Text = Order.userName;
            lblEmail.Text = Order.userEmail;
            lblAddress.Text = Order.userAddress;

            // If a user added items to the cart, display them:
            if (Order.chosenItemsNames.Count > 0)
            {
                for (int i = 0; i < Order.chosenItemsNames.Count; i++)
                {
                    lbItems.Items.Add(Order.chosenItemsNames[i]);
                    lbNumsRequired.Items.Add(Order.chosenItemsAmount[i]);
                    lbTotalPrices.Items.Add("$" + Order.chosenItemsPrices[i]);
                }
                lblTotal.Text = "$" + Order.chosenItemsTotalPrice.ToString();
            }
            // Else, print an error message:
            else
            {
                lbItems.Items.Add("Please add items to the cart");
            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            try
            {
                // Write all details to a file:
                string directory = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                directory += @"\" + Order.userName + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";                
                StreamWriter txt = File.CreateText(directory);
                txt.WriteLine($@"***********************************Invoice***********************************

Customer's name: {Order.userName}
Customer's email: {Order.userEmail}
Cusomer's address: {Order.userAddress}
Invoice Date: {DateTime.Today.ToLongDateString()}

Item Name | No of Items Ordered | Total Item Price");

                for (int i = 0; i < Order.chosenItemsNames.Count; i++)
                {
                    txt.WriteLine($"{Order.chosenItemsNames[i]} | {Order.chosenItemsAmount[i]} | ${Order.chosenItemsPrices[i]}");
                }
                txt.WriteLine($"\nTotal Price: ${Order.chosenItemsTotalPrice}");
                txt.Close();

                MessageBox.Show($"Order Placed! The invoice can be found here: {directory}");
            }
            // If an error happened when writing to a file, print an error message:
           catch(IOException)
            {
                MessageBox.Show("Error: Couldn't save the file");
            }
        }
    }
}
