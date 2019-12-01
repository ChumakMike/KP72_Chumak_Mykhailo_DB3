namespace Lab3Databases {
    partial class DeliveryUpdView {
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
            this.upd_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // upd_but
            // 
            this.upd_but.Location = new System.Drawing.Point(322, 251);
            this.upd_but.Name = "upd_but";
            this.upd_but.Size = new System.Drawing.Size(161, 47);
            this.upd_but.TabIndex = 5;
            this.upd_but.Text = "Update";
            this.upd_but.UseVisualStyleBackColor = true;
            this.upd_but.Click += new System.EventHandler(this.upd_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Change Delivery State :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox1.Location = new System.Drawing.Point(311, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // DeliveryUpdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.upd_but);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "DeliveryUpdView";
            this.Text = "DeliveryUpdView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upd_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}