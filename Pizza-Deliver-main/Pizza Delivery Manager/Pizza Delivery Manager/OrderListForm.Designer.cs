namespace Pizza_Delivery_Manager
{
    partial class OrderListForm
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
            this.orderListDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderListDataGridView
            // 
            this.orderListDataGridView.AllowUserToAddRows = false;
            this.orderListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderListDataGridView.Location = new System.Drawing.Point(0, 0);
            this.orderListDataGridView.Name = "orderListDataGridView";
            this.orderListDataGridView.ReadOnly = true;
            this.orderListDataGridView.RowHeadersVisible = false;
            this.orderListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderListDataGridView.Size = new System.Drawing.Size(846, 454);
            this.orderListDataGridView.TabIndex = 0;
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 454);
            this.Controls.Add(this.orderListDataGridView);
            this.Name = "OrderListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order List";
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderListDataGridView;
    }
}