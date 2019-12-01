namespace Lab3Databases {
    partial class ProviderView {
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
            this.ProvidersGrid = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProvidersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RandomFill
            // 
            this.RandomFill.Location = new System.Drawing.Point(95, 330);
            this.RandomFill.Name = "RandomFill";
            this.RandomFill.Size = new System.Drawing.Size(118, 35);
            this.RandomFill.TabIndex = 16;
            this.RandomFill.Text = "Random Fill";
            this.RandomFill.UseVisualStyleBackColor = true;
            this.RandomFill.Click += new System.EventHandler(this.RandomFill_Click);
            // 
            // ProvidersGrid
            // 
            this.ProvidersGrid.AllowUserToAddRows = false;
            this.ProvidersGrid.AllowUserToDeleteRows = false;
            this.ProvidersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProvidersGrid.Location = new System.Drawing.Point(325, 105);
            this.ProvidersGrid.Name = "ProvidersGrid";
            this.ProvidersGrid.ReadOnly = true;
            this.ProvidersGrid.RowTemplate.Height = 24;
            this.ProvidersGrid.Size = new System.Drawing.Size(359, 198);
            this.ProvidersGrid.TabIndex = 15;
            this.ProvidersGrid.SelectionChanged += new System.EventHandler(this.ProvidersGrid_SelectionChanged);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(95, 269);
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
            this.Remove.Location = new System.Drawing.Point(95, 209);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(118, 34);
            this.Remove.TabIndex = 13;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(95, 146);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(118, 34);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // All
            // 
            this.All.Location = new System.Drawing.Point(95, 86);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(118, 34);
            this.All.TabIndex = 11;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = true;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // ProviderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RandomFill);
            this.Controls.Add(this.ProvidersGrid);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.All);
            this.Name = "ProviderView";
            this.Text = "ProviderView";
            ((System.ComponentModel.ISupportInitialize)(this.ProvidersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RandomFill;
        private System.Windows.Forms.DataGridView ProvidersGrid;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button All;
    }
}