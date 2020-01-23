namespace ParkingCardHelper
{
    partial class ParkingHelper
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
            this.txtCreditAdded = new System.Windows.Forms.TextBox();
            this.txtOneParkNoCard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOneParkWithCard = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDaysParking = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCreditRemaining = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSaved = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit added to Campus Card";
            // 
            // txtCreditAdded
            // 
            this.txtCreditAdded.Location = new System.Drawing.Point(281, 28);
            this.txtCreditAdded.Name = "txtCreditAdded";
            this.txtCreditAdded.Size = new System.Drawing.Size(100, 22);
            this.txtCreditAdded.TabIndex = 1;
            // 
            // txtOneParkNoCard
            // 
            this.txtOneParkNoCard.Location = new System.Drawing.Point(281, 86);
            this.txtOneParkNoCard.Name = "txtOneParkNoCard";
            this.txtOneParkNoCard.Size = new System.Drawing.Size(100, 22);
            this.txtOneParkNoCard.TabIndex = 3;
            this.txtOneParkNoCard.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parking Cost without Campus Card";
            // 
            // txtOneParkWithCard
            // 
            this.txtOneParkWithCard.Location = new System.Drawing.Point(281, 140);
            this.txtOneParkWithCard.Name = "txtOneParkWithCard";
            this.txtOneParkWithCard.Size = new System.Drawing.Size(100, 22);
            this.txtOneParkWithCard.TabIndex = 5;
            this.txtOneParkWithCard.Text = "2.50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parking Cost with Campus Card";
            // 
            // txtDaysParking
            // 
            this.txtDaysParking.Location = new System.Drawing.Point(281, 231);
            this.txtDaysParking.Name = "txtDaysParking";
            this.txtDaysParking.ReadOnly = true;
            this.txtDaysParking.Size = new System.Drawing.Size(100, 22);
            this.txtDaysParking.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of days of Parking";
            // 
            // txtCreditRemaining
            // 
            this.txtCreditRemaining.Location = new System.Drawing.Point(281, 278);
            this.txtCreditRemaining.Name = "txtCreditRemaining";
            this.txtCreditRemaining.ReadOnly = true;
            this.txtCreditRemaining.Size = new System.Drawing.Size(100, 22);
            this.txtCreditRemaining.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Credit Remaining";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(293, 186);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(293, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSaved
            // 
            this.txtSaved.Location = new System.Drawing.Point(281, 323);
            this.txtSaved.Name = "txtSaved";
            this.txtSaved.ReadOnly = true;
            this.txtSaved.Size = new System.Drawing.Size(100, 22);
            this.txtSaved.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Amount Saved";
            // 
            // ParkingHelper
            // 
            this.AcceptButton = this.btnCalculate;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 416);
            this.Controls.Add(this.txtSaved);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCreditRemaining);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDaysParking);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOneParkWithCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOneParkNoCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCreditAdded);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximumSize = new System.Drawing.Size(423, 463);
            this.MinimumSize = new System.Drawing.Size(423, 463);
            this.Name = "ParkingHelper";
            this.ShowIcon = false;
            this.Text = "Parking Card Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreditAdded;
        private System.Windows.Forms.TextBox txtOneParkNoCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOneParkWithCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDaysParking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCreditRemaining;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSaved;
        private System.Windows.Forms.Label label6;
    }
}

