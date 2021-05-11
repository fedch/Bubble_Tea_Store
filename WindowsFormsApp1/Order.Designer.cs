
namespace WindowsFormsApp1
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCustDetails = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbItemList = new System.Windows.Forms.GroupBox();
            this.nUDNoOfItems = new System.Windows.Forms.NumericUpDown();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStockLeft = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.comBoxItem = new System.Windows.Forms.ComboBox();
            this.lblItemsNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblItemsLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.gbCustDetails.SuspendLayout();
            this.gbItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNoOfItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustDetails
            // 
            this.gbCustDetails.Controls.Add(this.btnCreate);
            this.gbCustDetails.Controls.Add(this.lblAddress);
            this.gbCustDetails.Controls.Add(this.txtAddress);
            this.gbCustDetails.Controls.Add(this.txtEmail);
            this.gbCustDetails.Controls.Add(this.txtName);
            this.gbCustDetails.Controls.Add(this.lblEmail);
            this.gbCustDetails.Controls.Add(this.lblName);
            this.gbCustDetails.Location = new System.Drawing.Point(12, 12);
            this.gbCustDetails.Name = "gbCustDetails";
            this.gbCustDetails.Size = new System.Drawing.Size(776, 174);
            this.gbCustDetails.TabIndex = 0;
            this.gbCustDetails.TabStop = false;
            this.gbCustDetails.Text = "Customer Details";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(649, 55);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 54);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create Order";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(323, 45);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(410, 45);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(204, 84);
            this.txtAddress.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 26);
            this.txtName.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // gbItemList
            // 
            this.gbItemList.Controls.Add(this.nUDNoOfItems);
            this.gbItemList.Controls.Add(this.btnViewCart);
            this.gbItemList.Controls.Add(this.btnAddtoCart);
            this.gbItemList.Controls.Add(this.button1);
            this.gbItemList.Controls.Add(this.lblStockLeft);
            this.gbItemList.Controls.Add(this.lblPrice);
            this.gbItemList.Controls.Add(this.comBoxItem);
            this.gbItemList.Controls.Add(this.lblItemsNo);
            this.gbItemList.Controls.Add(this.label3);
            this.gbItemList.Controls.Add(this.lblItemsLeft);
            this.gbItemList.Controls.Add(this.label2);
            this.gbItemList.Controls.Add(this.lblItemPrice);
            this.gbItemList.Controls.Add(this.label1);
            this.gbItemList.Controls.Add(this.lblItem);
            this.gbItemList.Location = new System.Drawing.Point(12, 174);
            this.gbItemList.Name = "gbItemList";
            this.gbItemList.Size = new System.Drawing.Size(776, 276);
            this.gbItemList.TabIndex = 1;
            this.gbItemList.TabStop = false;
            this.gbItemList.Text = "Item List";
            // 
            // nUDNoOfItems
            // 
            this.nUDNoOfItems.Location = new System.Drawing.Point(295, 165);
            this.nUDNoOfItems.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDNoOfItems.Name = "nUDNoOfItems";
            this.nUDNoOfItems.Size = new System.Drawing.Size(459, 26);
            this.nUDNoOfItems.TabIndex = 10;
            // 
            // btnViewCart
            // 
            this.btnViewCart.Location = new System.Drawing.Point(622, 223);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(112, 41);
            this.btnViewCart.TabIndex = 9;
            this.btnViewCart.Text = "View Cart";
            this.btnViewCart.UseVisualStyleBackColor = true;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Location = new System.Drawing.Point(472, 223);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(112, 41);
            this.btnAddtoCart.TabIndex = 8;
            this.btnAddtoCart.Text = "Add to cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblStockLeft
            // 
            this.lblStockLeft.AutoSize = true;
            this.lblStockLeft.Location = new System.Drawing.Point(291, 121);
            this.lblStockLeft.Name = "lblStockLeft";
            this.lblStockLeft.Size = new System.Drawing.Size(18, 20);
            this.lblStockLeft.TabIndex = 7;
            this.lblStockLeft.Text = "0";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(291, 70);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "$0.0";
            // 
            // comBoxItem
            // 
            this.comBoxItem.FormattingEnabled = true;
            this.comBoxItem.Location = new System.Drawing.Point(291, 26);
            this.comBoxItem.Name = "comBoxItem";
            this.comBoxItem.Size = new System.Drawing.Size(463, 28);
            this.comBoxItem.TabIndex = 5;
            this.comBoxItem.SelectedIndexChanged += new System.EventHandler(this.cbItem_SelectedIndexChanged);
            // 
            // lblItemsNo
            // 
            this.lblItemsNo.AutoSize = true;
            this.lblItemsNo.Location = new System.Drawing.Point(127, 165);
            this.lblItemsNo.Name = "lblItemsNo";
            this.lblItemsNo.Size = new System.Drawing.Size(157, 20);
            this.lblItemsNo.TabIndex = 3;
            this.lblItemsNo.Text = "No of Items needed: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Items Left: ";
            // 
            // lblItemsLeft
            // 
            this.lblItemsLeft.AutoSize = true;
            this.lblItemsLeft.Location = new System.Drawing.Point(195, 121);
            this.lblItemsLeft.Name = "lblItemsLeft";
            this.lblItemsLeft.Size = new System.Drawing.Size(89, 20);
            this.lblItemsLeft.TabIndex = 2;
            this.lblItemsLeft.Text = "Items Left: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Price: ";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Location = new System.Drawing.Point(195, 70);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(88, 20);
            this.lblItemPrice.TabIndex = 1;
            this.lblItemPrice.Text = "Item Price: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item: ";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(234, 26);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(49, 20);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item: ";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbItemList);
            this.Controls.Add(this.gbCustDetails);
            this.Name = "Order";
            this.Text = "Form1";
            this.gbCustDetails.ResumeLayout(false);
            this.gbCustDetails.PerformLayout();
            this.gbItemList.ResumeLayout(false);
            this.gbItemList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNoOfItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustDetails;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox gbItemList;
        private System.Windows.Forms.Label lblItemsNo;
        private System.Windows.Forms.ComboBox comBoxItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblItemsLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblStockLeft;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nUDNoOfItems;
    }
}

