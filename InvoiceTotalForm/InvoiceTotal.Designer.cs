namespace InvoiceTotalForm
{
    partial class InvoiceTotalCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceTotalCalc));
            this.label1 = new System.Windows.Forms.Label();
            this.subTotalTxt = new System.Windows.Forms.TextBox();
            this.discPercent = new System.Windows.Forms.TextBox();
            this.discAmount = new System.Windows.Forms.TextBox();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subtotal";
            // 
            // subTotalTxt
            // 
            this.subTotalTxt.Location = new System.Drawing.Point(154, 15);
            this.subTotalTxt.Name = "subTotalTxt";
            this.subTotalTxt.Size = new System.Drawing.Size(173, 22);
            this.subTotalTxt.TabIndex = 2;
            // 
            // discPercent
            // 
            this.discPercent.Location = new System.Drawing.Point(154, 71);
            this.discPercent.Name = "discPercent";
            this.discPercent.ReadOnly = true;
            this.discPercent.Size = new System.Drawing.Size(173, 22);
            this.discPercent.TabIndex = 3;
            this.discPercent.Text = "0%";
            this.discPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // discAmount
            // 
            this.discAmount.Location = new System.Drawing.Point(154, 122);
            this.discAmount.Name = "discAmount";
            this.discAmount.ReadOnly = true;
            this.discAmount.Size = new System.Drawing.Size(173, 22);
            this.discAmount.TabIndex = 4;
            // 
            // totalTxt
            // 
            this.totalTxt.Location = new System.Drawing.Point(154, 176);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.ReadOnly = true;
            this.totalTxt.Size = new System.Drawing.Size(173, 22);
            this.totalTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Discount Percent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Discount Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InvoiceTotalCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(359, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.discAmount);
            this.Controls.Add(this.discPercent);
            this.Controls.Add(this.subTotalTxt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 323);
            this.MinimumSize = new System.Drawing.Size(377, 323);
            this.Name = "InvoiceTotalCalc";
            this.Text = "Invoice Total Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subTotalTxt;
        private System.Windows.Forms.TextBox discPercent;
        private System.Windows.Forms.TextBox discAmount;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

