namespace Pizza_Delivery_Manager
{
    partial class DeliveryBoyRatingForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDeliveryBoy = new System.Windows.Forms.ComboBox();
            this.btnAddRating = new System.Windows.Forms.Button();
            this.ratingsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Rating";
            // 
            // numRating
            // 
            this.numRating.DecimalPlaces = 2;
            this.numRating.Location = new System.Drawing.Point(483, 54);
            this.numRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(195, 22);
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
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Delivery Boy:";
            // 
            // cboDeliveryBoy
            // 
            this.cboDeliveryBoy.FormattingEnabled = true;
            this.cboDeliveryBoy.Items.AddRange(new object[] {
            "Delivery Boy1",
            "Delivery Boy2",
            "Delivery Boy3",
            "Delivery Boy4",
            "Delivery Boy5"});
            this.cboDeliveryBoy.Location = new System.Drawing.Point(173, 53);
            this.cboDeliveryBoy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDeliveryBoy.Name = "cboDeliveryBoy";
            this.cboDeliveryBoy.Size = new System.Drawing.Size(193, 24);
            this.cboDeliveryBoy.TabIndex = 28;
            // 
            // btnAddRating
            // 
            this.btnAddRating.Location = new System.Drawing.Point(720, 38);
            this.btnAddRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(108, 52);
            this.btnAddRating.TabIndex = 32;
            this.btnAddRating.Text = "Add Rating";
            this.btnAddRating.UseVisualStyleBackColor = true;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // ratingsDataGridView
            // 
            this.ratingsDataGridView.AllowUserToAddRows = false;
            this.ratingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ratingsDataGridView.Location = new System.Drawing.Point(113, 113);
            this.ratingsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ratingsDataGridView.Name = "ratingsDataGridView";
            this.ratingsDataGridView.ReadOnly = true;
            this.ratingsDataGridView.RowHeadersVisible = false;
            this.ratingsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ratingsDataGridView.Size = new System.Drawing.Size(564, 407);
            this.ratingsDataGridView.TabIndex = 33;
            // 
            // DeliveryBoyRatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 554);
            this.Controls.Add(this.ratingsDataGridView);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDeliveryBoy);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeliveryBoyRatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Boy Ratings";
            this.Load += new System.EventHandler(this.DeliveryBoyRatingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDeliveryBoy;
        private System.Windows.Forms.Button btnAddRating;
        private System.Windows.Forms.DataGridView ratingsDataGridView;
    }
}