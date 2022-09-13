namespace Week1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMilesDriven = new System.Windows.Forms.TextBox();
            this.txtFuelPrice = new System.Windows.Forms.TextBox();
            this.txtParkingFee = new System.Windows.Forms.TextBox();
            this.txtTollFee = new System.Windows.Forms.TextBox();
            this.txtCarMPG = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miles driven per day:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current price of fuel per gallon (cents):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parking fees (cents):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tolls (cents):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vehicle MPG:";
            // 
            // txtMilesDriven
            // 
            this.txtMilesDriven.Location = new System.Drawing.Point(371, 51);
            this.txtMilesDriven.Name = "txtMilesDriven";
            this.txtMilesDriven.Size = new System.Drawing.Size(125, 27);
            this.txtMilesDriven.TabIndex = 5;
            // 
            // txtFuelPrice
            // 
            this.txtFuelPrice.Location = new System.Drawing.Point(371, 84);
            this.txtFuelPrice.Name = "txtFuelPrice";
            this.txtFuelPrice.Size = new System.Drawing.Size(125, 27);
            this.txtFuelPrice.TabIndex = 6;
            // 
            // txtParkingFee
            // 
            this.txtParkingFee.Location = new System.Drawing.Point(371, 117);
            this.txtParkingFee.Name = "txtParkingFee";
            this.txtParkingFee.Size = new System.Drawing.Size(125, 27);
            this.txtParkingFee.TabIndex = 7;
            // 
            // txtTollFee
            // 
            this.txtTollFee.Location = new System.Drawing.Point(371, 150);
            this.txtTollFee.Name = "txtTollFee";
            this.txtTollFee.Size = new System.Drawing.Size(125, 27);
            this.txtTollFee.TabIndex = 8;
            // 
            // txtCarMPG
            // 
            this.txtCarMPG.Location = new System.Drawing.Point(371, 183);
            this.txtCarMPG.Name = "txtCarMPG";
            this.txtCarMPG.Size = new System.Drawing.Size(125, 27);
            this.txtCarMPG.TabIndex = 9;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(219, 280);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(94, 29);
            this.calculateBtn.TabIndex = 10;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 399);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.txtCarMPG);
            this.Controls.Add(this.txtTollFee);
            this.Controls.Add(this.txtParkingFee);
            this.Controls.Add(this.txtFuelPrice);
            this.Controls.Add(this.txtMilesDriven);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMilesDriven;
        private TextBox txtFuelPrice;
        private TextBox txtParkingFee;
        private TextBox txtTollFee;
        private TextBox txtCarMPG;
        private Button calculateBtn;
    }
}