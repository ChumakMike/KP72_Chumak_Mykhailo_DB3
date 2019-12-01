namespace Lab3Databases {
    partial class ProviderAdd {
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
            this.Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.adr = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(328, 301);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(139, 57);
            this.Add.TabIndex = 20;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Enter phone :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Enter adress :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enter name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(286, 241);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(231, 22);
            this.phone.TabIndex = 16;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // adr
            // 
            this.adr.Location = new System.Drawing.Point(286, 181);
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(231, 22);
            this.adr.TabIndex = 15;
            this.adr.TextChanged += new System.EventHandler(this.adr_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(286, 122);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(231, 22);
            this.name.TabIndex = 14;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // ProviderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.adr);
            this.Controls.Add(this.name);
            this.Name = "ProviderAdd";
            this.Text = "ProviderAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox adr;
        private System.Windows.Forms.TextBox name;
    }
}