namespace JP_Surplus
{
    partial class Add
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBoxName = new TextBox();
            txtBoxInch = new TextBox();
            txtBoxQty = new TextBox();
            txtBoxPrice = new TextBox();
            button2 = new Button();
            label5 = new Label();
            txtBoxDesc = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(374, 322);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Main Page";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 63);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 103);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Inches:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 150);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 189);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Price:";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(172, 60);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(100, 23);
            txtBoxName.TabIndex = 5;
            // 
            // txtBoxInch
            // 
            txtBoxInch.Location = new Point(172, 100);
            txtBoxInch.Name = "txtBoxInch";
            txtBoxInch.Size = new Size(100, 23);
            txtBoxInch.TabIndex = 6;
            // 
            // txtBoxQty
            // 
            txtBoxQty.Location = new Point(172, 142);
            txtBoxQty.Name = "txtBoxQty";
            txtBoxQty.Size = new Size(100, 23);
            txtBoxQty.TabIndex = 7;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(172, 186);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(100, 23);
            txtBoxPrice.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(185, 280);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 230);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 10;
            label5.Text = "Description:";
            // 
            // txtBoxDesc
            // 
            txtBoxDesc.Location = new Point(172, 230);
            txtBoxDesc.Name = "txtBoxDesc";
            txtBoxDesc.Size = new Size(100, 23);
            txtBoxDesc.TabIndex = 11;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 377);
            Controls.Add(txtBoxDesc);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(txtBoxPrice);
            Controls.Add(txtBoxQty);
            Controls.Add(txtBoxInch);
            Controls.Add(txtBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxName;
        private TextBox txtBoxInch;
        private TextBox txtBoxQty;
        private TextBox txtBoxPrice;
        private Button button2;
        private Label label5;
        private TextBox txtBoxDesc;
    }
}