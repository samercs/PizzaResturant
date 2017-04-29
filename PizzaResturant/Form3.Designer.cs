using System.ComponentModel;

namespace PizzaResturant
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22F);
            this.label1.Location = new System.Drawing.Point(70, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 22F);
            this.label2.Location = new System.Drawing.Point(70, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Credit Card No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 22F);
            this.label3.Location = new System.Drawing.Point(70, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credit Card Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 22F);
            this.label4.Location = new System.Drawing.Point(70, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expire Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 22F);
            this.label5.Location = new System.Drawing.Point(70, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Security Code";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 22F);
            this.textBox1.Location = new System.Drawing.Point(406, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(499, 43);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 22F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "VISA",
            "MASTER CARD",
            "KNET"});
            this.comboBox1.Location = new System.Drawing.Point(406, 315);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(499, 43);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 22F);
            this.textBox2.Location = new System.Drawing.Point(406, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(499, 43);
            this.textBox2.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 22F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox2.Location = new System.Drawing.Point(406, 373);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 43);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Tahoma", 22F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.comboBox3.Location = new System.Drawing.Point(673, 373);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(232, 43);
            this.comboBox3.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 22F);
            this.textBox3.Location = new System.Drawing.Point(406, 439);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(499, 43);
            this.textBox3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 22F);
            this.button1.Location = new System.Drawing.Point(719, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 70);
            this.button1.TabIndex = 11;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 22F);
            this.label6.Location = new System.Drawing.Point(70, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Order Total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Tahoma", 22F);
            this.lblOrderTotal.Location = new System.Drawing.Point(400, 111);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(167, 36);
            this.lblOrderTotal.TabIndex = 13;
            this.lblOrderTotal.Text = "Order Total";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 723);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Payment Information";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Closing += new CancelEventHandler(this.Form_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOrderTotal;
    }
}