namespace RecipeHelper
{
    partial class RecipeHelper
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
            this.convertFC = new System.Windows.Forms.Button();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahren = new System.Windows.Forms.TextBox();
            this.txtMilli = new System.Windows.Forms.TextBox();
            this.txtCups = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.convertMC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrenheit";
            // 
            // convertFC
            // 
            this.convertFC.Location = new System.Drawing.Point(68, 93);
            this.convertFC.Name = "convertFC";
            this.convertFC.Size = new System.Drawing.Size(111, 66);
            this.convertFC.TabIndex = 2;
            this.convertFC.Text = "Convert to Fahrenheit";
            this.convertFC.UseVisualStyleBackColor = true;
            this.convertFC.Click += new System.EventHandler(this.convertFC_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(130, 41);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 22);
            this.txtCelsius.TabIndex = 4;
            // 
            // txtFahren
            // 
            this.txtFahren.Location = new System.Drawing.Point(130, 199);
            this.txtFahren.Name = "txtFahren";
            this.txtFahren.ReadOnly = true;
            this.txtFahren.Size = new System.Drawing.Size(100, 22);
            this.txtFahren.TabIndex = 5;
            // 
            // txtMilli
            // 
            this.txtMilli.Location = new System.Drawing.Point(419, 41);
            this.txtMilli.Name = "txtMilli";
            this.txtMilli.Size = new System.Drawing.Size(100, 22);
            this.txtMilli.TabIndex = 9;
            // 
            // txtCups
            // 
            this.txtCups.Location = new System.Drawing.Point(419, 199);
            this.txtCups.Name = "txtCups";
            this.txtCups.ReadOnly = true;
            this.txtCups.Size = new System.Drawing.Size(100, 22);
            this.txtCups.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Milliliters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cups";
            // 
            // convertMC
            // 
            this.convertMC.Location = new System.Drawing.Point(362, 93);
            this.convertMC.Name = "convertMC";
            this.convertMC.Size = new System.Drawing.Size(111, 66);
            this.convertMC.TabIndex = 10;
            this.convertMC.Text = "Convert to Cups";
            this.convertMC.UseVisualStyleBackColor = true;
            this.convertMC.Click += new System.EventHandler(this.convertMC_Click);
            // 
            // RecipeHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 281);
            this.Controls.Add(this.convertMC);
            this.Controls.Add(this.txtMilli);
            this.Controls.Add(this.txtCups);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFahren);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.convertFC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecipeHelper";
            this.Text = "Recipe Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convertFC;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahren;
        private System.Windows.Forms.TextBox txtMilli;
        private System.Windows.Forms.TextBox txtCups;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button convertMC;
    }
}

