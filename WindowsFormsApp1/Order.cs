using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Order : Form
    {
        // Declare public static variables to use across various methods and forms:
        public static List<string> itemNames = new List<string>();
        public static List<string> prices = new List<string>();
        public static List<string> stockLeft = new List<string>();
        public static string userName;
        public static string userEmail;
        public static string userAddress;       
        public static List<string> chosenItemsNames = new List<string>();
        public static List<int> chosenItemsAmount = new List<int>();
        public static List<decimal> chosenItemsPrices = new List<decimal>();
        public static decimal chosenItemsTotalPrice;

        public Order()
        {
            InitializeComponent();
            // Disable the groupbox and Numeric UpDown at the start:
            gbItemList.Enabled = false;
            nUDNoOfItems.Enabled = false;
        }

        private static void downloadItems()
        {
            // Using the try-catch blocks show an error if there is a problem with the source txt file:
            try
            {
                // Get the file's directory and store it in the variable directory
                string directory = Path.GetFullPath("Items_Teas_Do_Not_Delete.txt");
                using (StreamReader streamReader = new StreamReader(directory))
                {
                    string line = string.Empty;

                    // Read file text line by line, separate strings by "|" symbol:
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        List<string> tempArray = line.Split('|').ToList();
                        // Save every 0th string in list itemNames:
                        itemNames.Add(tempArray[0]);
                        // Save every 1st string in list prices:
                        prices.Add(tempArray[1]);
                        // Save every 2nd string in list stockLeft:
                        stockLeft.Add(tempArray[2]);
                    }

                    // Remove the titles of the columns (Item|Item Price|Stock Left):
                    itemNames.RemoveAt(0);
                    prices.RemoveAt(0);
                    stockLeft.RemoveAt(0);
                }
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("Couldn't locate the source file");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Ger user details from the Form input:
            userName = txtName.Text;
            userEmail = txtEmail.Text;
            userAddress = txtAddress.Text;
            // Make sure the user provides all the details:
            if (userName == "" || userEmail == "" || userAddress == "")
            {
                MessageBox.Show("Please enter all of your details");
            }
            else
            {
                // Enable the groupBox with the Items:
                gbItemList.Enabled = true;

                // Call downloadItems method and display itemNames in the appropriate comboBox:
                downloadItems();
                foreach (var i in itemNames)
                {
                    comBoxItem.Items.Add(i);
                }
            }
        }

        private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
        {            
            // Find the index of the chosen ComboBox Item and store it in itemIndex:
            int itemIndex = itemNames.FindIndex(a => a.Contains(comBoxItem.Text));

            // Display the corresponding price and the amount of stock left:
            for (int i=0; i<prices.Count; i++)
            {
                if (i == Convert.ToInt32(itemIndex))
                {
                    lblPrice.Text = "$" + prices[i];
                    lblStockLeft.Text = stockLeft[i];
                    // Enable the Numeric UpDown control and set maximum to items left:
                    nUDNoOfItems.Enabled = true;
                    nUDNoOfItems.Maximum = Convert.ToInt32(stockLeft[i]);
                }
            }            
        }
        
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            // Make sure user chooses amount above zero when adding an item to the cart:
            if (nUDNoOfItems.Text == "0")
            {
                MessageBox.Show("The item amount is zero, please enter the amount");
            }
            // Restrict user from adding repeating items:
            else if (chosenItemsNames.Contains(comBoxItem.SelectedItem.ToString()))
            {
                MessageBox.Show("You already added this item to the cart.");
            }
            // Add the selected item to a list, corresponding price to another list and total price based on the amount required to the 3rd list:
            else
            {
                chosenItemsNames.Add(comBoxItem.SelectedItem.ToString());
                chosenItemsAmount.Add(Convert.ToInt32(nUDNoOfItems.Text));
                // Fill a string of total prices for each item based on the amount added to the cart:
                chosenItemsPrices.Add(Decimal.Parse(lblPrice.Text, NumberStyles.Currency) * (Convert.ToInt32(nUDNoOfItems.Text)));

                MessageBox.Show($"The item {comBoxItem.SelectedItem} was added to the cart");
            }
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {   
            // Calculate the total of all prices and open the second form:
            chosenItemsTotalPrice = (chosenItemsPrices.Sum(x => Convert.ToDecimal(x)));
            Cart formCart = new Cart();
            formCart.Show();
        }
    }
}
