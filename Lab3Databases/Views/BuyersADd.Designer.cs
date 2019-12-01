namespace Lab3Databases {
    partial class BuyersAdd {
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
            this.login = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(328, 301);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(139, 57);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter name :";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(286, 241);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(231, 22);
            this.login.TabIndex = 9;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(286, 181);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(231, 22);
            this.surname.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(286, 122);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(231, 22);
            this.name.TabIndex = 7;
            // 
            // BuyersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Name = "BuyersAdd";
            this.Text = "BuyersADd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
    }
}