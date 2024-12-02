namespace CashierApplication
{
    partial class frmPurchasedDiscountedItem
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
            LItemN = new Label();
            LPrice = new Label();
            LQ = new Label();
            LD = new Label();
            tbIN = new TextBox();
            tbP = new TextBox();
            tbD = new TextBox();
            tbQ = new TextBox();
            bC = new Button();
            LTA = new Label();
            LC = new Label();
            LPR = new Label();
            tbpr = new TextBox();
            bs = new Button();
            SuspendLayout();
            // 
            // LItemN
            // 
            LItemN.AutoSize = true;
            LItemN.Location = new Point(18, 41);
            LItemN.Name = "LItemN";
            LItemN.Size = new Size(76, 20);
            LItemN.TabIndex = 0;
            LItemN.Text = "Item Name:";
            // 
            // LPrice
            // 
            LPrice.AutoSize = true;
            LPrice.Location = new Point(18, 90);
            LPrice.Name = "LPrice";
            LPrice.Size = new Size(44, 20);
            LPrice.TabIndex = 1;
            LPrice.Text = "Price:";
            // 
            // LQ
            // 
            LQ.AutoSize = true;
            LQ.Location = new Point(309, 91);
            LQ.Name = "LQ";
            LQ.Size = new Size(65, 20);
            LQ.TabIndex = 2;
            LQ.Text = "Quantity:";
            // 
            // LD
            // 
            LD.AutoSize = true;
            LD.Location = new Point(309, 41);
            LD.Name = "LD";
            LD.Size = new Size(90, 20);
            LD.TabIndex = 3;
            LD.Text = "Discount (%):";
            // 
            // tbIN
            // 
            tbIN.Location = new Point(22, 59);
            tbIN.Name = "tbIN";
            tbIN.Size = new Size(281, 25);
            tbIN.TabIndex = 4;
            // 
            // tbP
            // 
            tbP.Location = new Point(68, 90);
            tbP.Name = "tbP";
            tbP.Size = new Size(235, 25);
            tbP.TabIndex = 5;
            // 
            // tbD
            // 
            tbD.Location = new Point(314, 60);
            tbD.Name = "tbD";
            tbD.Size = new Size(160, 25);
            tbD.TabIndex = 6;
            // 
            // tbQ
            // 
            tbQ.Location = new Point(380, 91);
            tbQ.Name = "tbQ";
            tbQ.Size = new Size(94, 25);
            tbQ.TabIndex = 7;
            // 
            // bC
            // 
            bC.Location = new Point(198, 131);
            bC.Name = "bC";
            bC.Size = new Size(105, 39);
            bC.TabIndex = 8;
            bC.Text = "Compute";
            bC.UseVisualStyleBackColor = true;
            bC.Click += bC_Click;
            // 
            // LTA
            // 
            LTA.AutoSize = true;
            LTA.Location = new Point(68, 194);
            LTA.Name = "LTA";
            LTA.Size = new Size(95, 20);
            LTA.TabIndex = 9;
            LTA.Text = "Total Amount:";
            // 
            // LC
            // 
            LC.AutoSize = true;
            LC.Location = new Point(68, 258);
            LC.Name = "LC";
            LC.Size = new Size(60, 20);
            LC.TabIndex = 10;
            LC.Text = "Change:";
            // 
            // LPR
            // 
            LPR.AutoSize = true;
            LPR.Location = new Point(68, 225);
            LPR.Name = "LPR";
            LPR.Size = new Size(124, 20);
            LPR.TabIndex = 11;
            LPR.Text = "Payment Received:";
            // 
            // tbpr
            // 
            tbpr.Location = new Point(198, 225);
            tbpr.Name = "tbpr";
            tbpr.Size = new Size(176, 25);
            tbpr.TabIndex = 12;
            // 
            // bs
            // 
            bs.Location = new Point(380, 219);
            bs.Name = "bs";
            bs.Size = new Size(105, 39);
            bs.TabIndex = 13;
            bs.Text = "Submit";
            bs.UseVisualStyleBackColor = true;
            bs.Click += bs_Click;
            // 
            // frmPurchasedDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(497, 325);
            Controls.Add(bs);
            Controls.Add(tbpr);
            Controls.Add(LPR);
            Controls.Add(LC);
            Controls.Add(LTA);
            Controls.Add(bC);
            Controls.Add(tbQ);
            Controls.Add(tbD);
            Controls.Add(tbP);
            Controls.Add(tbIN);
            Controls.Add(LD);
            Controls.Add(LQ);
            Controls.Add(LPrice);
            Controls.Add(LItemN);
            Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPurchasedDiscountedItem";
            Text = "frmPurchasedDiscountedItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LItemN;
        private Label LPrice;
        private Label LQ;
        private Label LD;
        private TextBox tbIN;
        private TextBox tbP;
        private TextBox tbD;
        private TextBox tbQ;
        private Button bC;
        private Label LTA;
        private Label LC;
        private Label LPR;
        private TextBox tbpr;
        private Button bs;
    }
}
