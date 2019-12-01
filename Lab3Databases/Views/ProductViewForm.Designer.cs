namespace Lab3Databases {
    partial class ProductViewForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.RandomFill = new System.Windows.Forms.Button();
            this.ProductsGrid = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RandomFill
            // 
            this.RandomFill.Location = new System.Drawing.Point(96, 305);
            this.RandomFill.Name = "RandomFill";
            this.RandomFill.Size = new System.Drawing.Size(118, 34);
            this.RandomFill.TabIndex = 16;
            this.RandomFill.Text = "Random Fill";
            this.RandomFill.UseVisualStyleBackColor = true;
            this.RandomFill.Click += new System.EventHandler(this.RandomFill_Click);
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.AllowUserToAddRows = false;
            this.ProductsGrid.AllowUserToDeleteRows = false;
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Location = new System.Drawing.Point(297, 75);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.ReadOnly = true;
            this.ProductsGrid.RowTemplate.Height = 24;
            this.ProductsGrid.Size = new System.Drawing.Size(410, 250);
            this.ProductsGrid.TabIndex = 15;
            this.ProductsGrid.SelectionChanged += new System.EventHandler(this.ProductsGrid_SelectionChanged);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(96, 242);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(118, 34);
            this.Update.TabIndex = 14;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Remove
            // 
            this.Remove.Enabled = false;
            this.Remove.Location = new System.Drawing.Point(96, 182);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(118, 34);
            this.Remove.TabIndex = 13;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(96, 119);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(118, 34);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // All
            // 
            this.All.Location = new System.Drawing.Point(96, 59);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(118, 34);
            this.All.TabIndex = 11;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = true;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // ProductViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RandomFill);
            this.Controls.Add(this.ProductsGrid);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.All);
            this.Name = "ProductViewForm";
            this.Text = "ProductViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RandomFill;
        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button All;
    }
}