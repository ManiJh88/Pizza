namespace Pizza_Delivery_Manager
{
    partial class FrmPizzaRating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPizzaRating));
            this.btnAddRating = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPizza = new System.Windows.Forms.ComboBox();
            this.dgvRating = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRating
            // 
            this.btnAddRating.Location = new System.Drawing.Point(488, 14);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(81, 30);
            this.btnAddRating.TabIndex = 44;
            this.btnAddRating.Text = "Add Rating";
            this.btnAddRating.UseVisualStyleBackColor = true;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Rating";
            // 
            // numRating
            // 
            this.numRating.DecimalPlaces = 2;
            this.numRating.Location = new System.Drawing.Point(316, 20);
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(166, 21);
            this.numRating.TabIndex = 42;
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
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Pizza:";
            // 
            // cbxPizza
            // 
            this.cbxPizza.FormattingEnabled = true;
            this.cbxPizza.Items.AddRange(new object[] {
            "Chicken Fajita",
            "Chicken Tikka",
            "Bar B Q"});
            this.cbxPizza.Location = new System.Drawing.Point(77, 19);
            this.cbxPizza.Name = "cbxPizza";
            this.cbxPizza.Size = new System.Drawing.Size(166, 20);
            this.cbxPizza.TabIndex = 40;
            // 
            // dgvRating
            // 
            this.dgvRating.AllowUserToAddRows = false;
            this.dgvRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRating.Location = new System.Drawing.Point(22, 53);
            this.dgvRating.Name = "dgvRating";
            this.dgvRating.ReadOnly = true;
            this.dgvRating.RowHeadersVisible = false;
            this.dgvRating.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRating.Size = new System.Drawing.Size(547, 306);
            this.dgvRating.TabIndex = 45;
            // 
            // FrmPizzaRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 381);
            this.Controls.Add(this.dgvRating);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPizza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPizzaRating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Ratings";
            this.Load += new System.EventHandler(this.PizzaRatingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPizza;
        private System.Windows.Forms.DataGridView dgvRating;
    }
}