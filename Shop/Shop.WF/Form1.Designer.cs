namespace Shop.WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegProd = new System.Windows.Forms.Button();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxPrice = new System.Windows.Forms.TextBox();
            this.tBoxQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegProd
            // 
            this.btnRegProd.Location = new System.Drawing.Point(34, 258);
            this.btnRegProd.Name = "btnRegProd";
            this.btnRegProd.Size = new System.Drawing.Size(161, 23);
            this.btnRegProd.TabIndex = 0;
            this.btnRegProd.Text = "Register Product";
            this.btnRegProd.UseVisualStyleBackColor = true;
            this.btnRegProd.Click += new System.EventHandler(this.RegistrationProducts_Click);
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(129, 37);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(100, 23);
            this.tBoxName.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(21, 40);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(39, 15);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tBoxPrice
            // 
            this.tBoxPrice.Location = new System.Drawing.Point(129, 68);
            this.tBoxPrice.Name = "tBoxPrice";
            this.tBoxPrice.Size = new System.Drawing.Size(100, 23);
            this.tBoxPrice.TabIndex = 5;
            // 
            // tBoxQuantity
            // 
            this.tBoxQuantity.Location = new System.Drawing.Point(129, 103);
            this.tBoxQuantity.Name = "tBoxQuantity";
            this.tBoxQuantity.Size = new System.Drawing.Size(100, 23);
            this.tBoxQuantity.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBoxQuantity);
            this.Controls.Add(this.tBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.btnRegProd);
            //this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegProd;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxPrice;
        private System.Windows.Forms.TextBox tBoxQuantity;
    }
}
