namespace Lab3Databases {
    partial class DeliveryAddView {
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.isDeliveredComboBox = new System.Windows.Forms.ComboBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.buyersComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 51);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Select the date of delivery :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Select the date of order :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Select is product delivered :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select Product :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Buyer :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(292, 246);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // isDeliveredComboBox
            // 
            this.isDeliveredComboBox.FormattingEnabled = true;
            this.isDeliveredComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.isDeliveredComboBox.Location = new System.Drawing.Point(292, 316);
            this.isDeliveredComboBox.Name = "isDeliveredComboBox";
            this.isDeliveredComboBox.Size = new System.Drawing.Size(220, 24);
            this.isDeliveredComboBox.TabIndex = 13;
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(292, 116);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(220, 24);
            this.productComboBox.TabIndex = 12;
            // 
            // buyersComboBox
            // 
            this.buyersComboBox.FormattingEnabled = true;
            this.buyersComboBox.Location = new System.Drawing.Point(292, 56);
            this.buyersComboBox.Name = "buyersComboBox";
            this.buyersComboBox.Size = new System.Drawing.Size(220, 24);
            this.buyersComboBox.TabIndex = 11;
            // 
            // DeliveryAddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.isDeliveredComboBox);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.buyersComboBox);
            this.Name = "DeliveryAddView";
            this.Text = "DeliveryAddView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox isDeliveredComboBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox buyersComboBox;
    }
}