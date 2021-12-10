namespace Pizza_Delivery_Manager
{
    partial class MainForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ratingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryBoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(74, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(243, 48);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOrderList
            // 
            this.btnOrderList.Location = new System.Drawing.Point(74, 160);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(243, 48);
            this.btnOrderList.TabIndex = 11;
            this.btnOrderList.Text = "Order List";
            this.btnOrderList.UseVisualStyleBackColor = true;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(74, 106);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(243, 48);
            this.btnNewOrder.TabIndex = 10;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ratingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ratingsToolStripMenuItem
            // 
            this.ratingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzaToolStripMenuItem,
            this.deliveryBoyToolStripMenuItem});
            this.ratingsToolStripMenuItem.Name = "ratingsToolStripMenuItem";
            this.ratingsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ratingsToolStripMenuItem.Text = "Ratings";
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pizzaToolStripMenuItem.Text = "Pizza";
            this.pizzaToolStripMenuItem.Click += new System.EventHandler(this.pizzaToolStripMenuItem_Click);
            // 
            // deliveryBoyToolStripMenuItem
            // 
            this.deliveryBoyToolStripMenuItem.Name = "deliveryBoyToolStripMenuItem";
            this.deliveryBoyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deliveryBoyToolStripMenuItem.Text = "Delivery Boy";
            this.deliveryBoyToolStripMenuItem.Click += new System.EventHandler(this.deliveryBoyToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 369);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrderList);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Delivery Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ratingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryBoyToolStripMenuItem;
    }
}

