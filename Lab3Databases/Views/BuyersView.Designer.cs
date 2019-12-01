namespace Lab3Databases {
    partial class BuyersView {
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
            this.BuyersGrid = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BuyersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RandomFill
            // 
            this.RandomFill.Location = new System.Drawing.Point(94, 313);
            this.RandomFill.Name = "RandomFill";
            this.RandomFill.Size = new System.Drawing.Size(118, 30);
            this.RandomFill.TabIndex = 11;
            this.RandomFill.Text = "Random Fill";
            this.RandomFill.UseVisualStyleBackColor = true;
            this.RandomFill.Click += new System.EventHandler(this.RandomFill_Click);
            // 
            // BuyersGrid
            // 
            this.BuyersGrid.AllowUserToAddRows = false;
            this.BuyersGrid.AllowUserToDeleteRows = false;
            this.BuyersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuyersGrid.Location = new System.Drawing.Point(297, 75);
            this.BuyersGrid.Name = "BuyersGrid";
            this.BuyersGrid.ReadOnly = true;
            this.BuyersGrid.RowTemplate.Height = 24;
            this.BuyersGrid.Size = new System.Drawing.Size(410, 250);
            this.BuyersGrid.TabIndex = 10;
            this.BuyersGrid.SelectionChanged += new System.EventHandler(this.BuyersGrid_SelectionChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(94, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Remove
            // 
            this.Remove.Enabled = false;
            this.Remove.Location = new System.Drawing.Point(94, 186);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(118, 34);
            this.Remove.TabIndex = 8;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(94, 123);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(118, 34);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // All
            // 
            this.All.Location = new System.Drawing.Point(94, 63);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(118, 34);
            this.All.TabIndex = 6;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = true;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // BuyersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RandomFill);
            this.Controls.Add(this.BuyersGrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.All);
            this.Name = "BuyersView";
            this.Text = "BuyersView";
            ((System.ComponentModel.ISupportInitialize)(this.BuyersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RandomFill;
        private System.Windows.Forms.DataGridView BuyersGrid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button All;
    }
}