namespace Pizza_Delivery_Manager
{
    partial class FrmDeliveryBoyRating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeliveryBoyRating));
            this.label3 = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDeliveryBoy = new System.Windows.Forms.ComboBox();
            this.btnAddRating = new System.Windows.Forms.Button();
            this.dgvRating = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Rating";
            // 
            // numRating
            // 
            this.numRating.DecimalPlaces = 2;
            this.numRating.Location = new System.Drawing.Point(336, 20);
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(146, 21);
            this.numRating.TabIndex = 30;
            this.numRating.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Delivery Boy:";
            // 
            // cbxDeliveryBoy
            // 
            this.cbxDeliveryBoy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDeliveryBoy.FormattingEnabled = true;
            this.cbxDeliveryBoy.Items.AddRange(new object[] {
            "Delivery Boy1",
            "Delivery Boy2",
            "Delivery Boy3",
            "Delivery Boy4",
            "Delivery Boy5"});
            this.cbxDeliveryBoy.Location = new System.Drawing.Point(122, 19);
            this.cbxDeliveryBoy.Name = "cbxDeliveryBoy";
            this.cbxDeliveryBoy.Size = new System.Drawing.Size(146, 20);
            this.cbxDeliveryBoy.TabIndex = 28;
            // 
            // btnAddRating
            // 
            this.btnAddRating.Location = new System.Drawing.Point(488, 12);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(81, 34);
            this.btnAddRating.TabIndex = 32;
            this.btnAddRating.Text = "Add Rating";
            this.btnAddRating.UseVisualStyleBackColor = true;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // dgvRating
            // 
            this.dgvRating.AllowUserToAddRows = false;
            this.dgvRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRating.Location = new System.Drawing.Point(15, 52);
            this.dgvRating.Name = "dgvRating";
            this.dgvRating.ReadOnly = true;
            this.dgvRating.RowHeadersVisible = false;
            this.dgvRating.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRating.Size = new System.Drawing.Size(554, 315);
            this.dgvRating.TabIndex = 33;
            // 
            // FrmDeliveryBoyRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 385);
            this.Controls.Add(this.dgvRating);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDeliveryBoy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDeliveryBoyRating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Boy Ratings";
            this.Load += new System.EventHandler(this.DeliveryBoyRatingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDeliveryBoy;
        private System.Windows.Forms.Button btnAddRating;
        private System.Windows.Forms.DataGridView dgvRating;
    }
}