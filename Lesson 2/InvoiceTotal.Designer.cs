namespace Lesson_2
{
    partial class InvoiceTotalForm
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
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.labelDiscountPercent = new System.Windows.Forms.Label();
            this.labelDiscountAmount = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.textBoxDiscountPercent = new System.Windows.Forms.TextBox();
            this.textBoxDiscountAmount = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Location = new System.Drawing.Point(55, 9);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(49, 13);
            this.labelSubTotal.TabIndex = 0;
            this.labelSubTotal.Text = "Subtotal:";
            // 
            // labelDiscountPercent
            // 
            this.labelDiscountPercent.AutoSize = true;
            this.labelDiscountPercent.Location = new System.Drawing.Point(12, 33);
            this.labelDiscountPercent.Name = "labelDiscountPercent";
            this.labelDiscountPercent.Size = new System.Drawing.Size(92, 13);
            this.labelDiscountPercent.TabIndex = 1;
            this.labelDiscountPercent.Text = "Discount Percent:";
            // 
            // labelDiscountAmount
            // 
            this.labelDiscountAmount.AutoSize = true;
            this.labelDiscountAmount.Location = new System.Drawing.Point(13, 59);
            this.labelDiscountAmount.Name = "labelDiscountAmount";
            this.labelDiscountAmount.Size = new System.Drawing.Size(91, 13);
            this.labelDiscountAmount.TabIndex = 2;
            this.labelDiscountAmount.Text = "Discount Amount:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(70, 85);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total:";
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(108, 6);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubTotal.TabIndex = 4;
            // 
            // textBoxDiscountPercent
            // 
            this.textBoxDiscountPercent.BackColor = System.Drawing.Color.White;
            this.textBoxDiscountPercent.Location = new System.Drawing.Point(108, 30);
            this.textBoxDiscountPercent.Name = "textBoxDiscountPercent";
            this.textBoxDiscountPercent.ReadOnly = true;
            this.textBoxDiscountPercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiscountPercent.TabIndex = 5;
            this.textBoxDiscountPercent.Text = "10.0%";
            // 
            // textBoxDiscountAmount
            // 
            this.textBoxDiscountAmount.BackColor = System.Drawing.Color.White;
            this.textBoxDiscountAmount.Location = new System.Drawing.Point(108, 56);
            this.textBoxDiscountAmount.Name = "textBoxDiscountAmount";
            this.textBoxDiscountAmount.ReadOnly = true;
            this.textBoxDiscountAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiscountAmount.TabIndex = 6;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.Color.White;
            this.textBoxTotal.Location = new System.Drawing.Point(108, 82);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 7;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(214, 6);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(65, 45);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(214, 56);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(65, 46);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // InvoiceTotalForm
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(294, 112);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxDiscountAmount);
            this.Controls.Add(this.textBoxDiscountPercent);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDiscountAmount);
            this.Controls.Add(this.labelDiscountPercent);
            this.Controls.Add(this.labelSubTotal);
            this.Name = "InvoiceTotalForm";
            this.Text = "Invoice Total";
            this.Load += new System.EventHandler(this.InvoiceTotalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label labelDiscountPercent;
        private System.Windows.Forms.Label labelDiscountAmount;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.TextBox textBoxDiscountPercent;
        private System.Windows.Forms.TextBox textBoxDiscountAmount;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
    }
}

