
namespace WindowsFormsApp1
{
    partial class Cart
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblForEmail = new System.Windows.Forms.Label();
            this.lblForAddress = new System.Windows.Forms.Label();
            this.lblForName = new System.Windows.Forms.Label();
            this.btnFinal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblForTotal = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTPrice = new System.Windows.Forms.Label();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.lbNumsRequired = new System.Windows.Forms.ListBox();
            this.lbTotalPrices = new System.Windows.Forms.ListBox();
            this.lbCart = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(98, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(98, 81);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(336, 34);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 20);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "adress";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 297);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblForEmail);
            this.splitContainer1.Panel1.Controls.Add(this.lblForAddress);
            this.splitContainer1.Panel1.Controls.Add(this.lblForName);
            this.splitContainer1.Panel1.Controls.Add(this.lblEmail);
            this.splitContainer1.Panel1.Controls.Add(this.lblAddress);
            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnFinal);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotal);
            this.splitContainer1.Panel2.Controls.Add(this.lblForTotal);
            this.splitContainer1.Size = new System.Drawing.Size(776, 141);
            this.splitContainer1.SplitterDistance = 494;
            this.splitContainer1.TabIndex = 4;
            // 
            // lblForEmail
            // 
            this.lblForEmail.AutoSize = true;
            this.lblForEmail.Location = new System.Drawing.Point(21, 81);
            this.lblForEmail.Name = "lblForEmail";
            this.lblForEmail.Size = new System.Drawing.Size(48, 20);
            this.lblForEmail.TabIndex = 4;
            this.lblForEmail.Text = "Email";
            // 
            // lblForAddress
            // 
            this.lblForAddress.AutoSize = true;
            this.lblForAddress.Location = new System.Drawing.Point(259, 34);
            this.lblForAddress.Name = "lblForAddress";
            this.lblForAddress.Size = new System.Drawing.Size(68, 20);
            this.lblForAddress.TabIndex = 5;
            this.lblForAddress.Text = "Address";
            // 
            // lblForName
            // 
            this.lblForName.AutoSize = true;
            this.lblForName.Location = new System.Drawing.Point(18, 34);
            this.lblForName.Name = "lblForName";
            this.lblForName.Size = new System.Drawing.Size(51, 20);
            this.lblForName.TabIndex = 3;
            this.lblForName.Text = "Name";
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(81, 69);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(108, 44);
            this.btnFinal.TabIndex = 2;
            this.btnFinal.Text = "Place order";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(162, 24);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "total";
            // 
            // lblForTotal
            // 
            this.lblForTotal.AutoSize = true;
            this.lblForTotal.Location = new System.Drawing.Point(55, 24);
            this.lblForTotal.Name = "lblForTotal";
            this.lblForTotal.Size = new System.Drawing.Size(86, 20);
            this.lblForTotal.TabIndex = 0;
            this.lblForTotal.Text = "Total price:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(12, 23);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(41, 20);
            this.lblItem.TabIndex = 5;
            this.lblItem.Text = "Item";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(484, 23);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(111, 20);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Num Required";
            // 
            // lblTPrice
            // 
            this.lblTPrice.AutoSize = true;
            this.lblTPrice.Location = new System.Drawing.Point(635, 23);
            this.lblTPrice.Name = "lblTPrice";
            this.lblTPrice.Size = new System.Drawing.Size(83, 20);
            this.lblTPrice.TabIndex = 7;
            this.lblTPrice.Text = "Total Price";
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 20;
            this.lbItems.Location = new System.Drawing.Point(12, 46);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(470, 244);
            this.lbItems.TabIndex = 8;
            // 
            // lbNumsRequired
            // 
            this.lbNumsRequired.FormattingEnabled = true;
            this.lbNumsRequired.ItemHeight = 20;
            this.lbNumsRequired.Location = new System.Drawing.Point(488, 46);
            this.lbNumsRequired.Name = "lbNumsRequired";
            this.lbNumsRequired.Size = new System.Drawing.Size(145, 244);
            this.lbNumsRequired.TabIndex = 9;
            // 
            // lbTotalPrices
            // 
            this.lbTotalPrices.FormattingEnabled = true;
            this.lbTotalPrices.ItemHeight = 20;
            this.lbTotalPrices.Location = new System.Drawing.Point(639, 46);
            this.lbTotalPrices.Name = "lbTotalPrices";
            this.lbTotalPrices.Size = new System.Drawing.Size(145, 244);
            this.lbTotalPrices.TabIndex = 10;
            // 
            // lbCart
            // 
            this.lbCart.FormattingEnabled = true;
            this.lbCart.ItemHeight = 20;
            this.lbCart.Location = new System.Drawing.Point(1, 9);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(798, 444);
            this.lbCart.TabIndex = 3;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTotalPrices);
            this.Controls.Add(this.lbNumsRequired);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.lblTPrice);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lbCart);
            this.Name = "Cart";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblForEmail;
        private System.Windows.Forms.Label lblForAddress;
        private System.Windows.Forms.Label lblForName;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblForTotal;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTPrice;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.ListBox lbNumsRequired;
        private System.Windows.Forms.ListBox lbTotalPrices;
        private System.Windows.Forms.ListBox lbCart;
    }
}