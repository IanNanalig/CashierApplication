namespace CashierApplication
{
    partial class frmLoginAccount
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
            Lusern = new Label();
            tbusern = new TextBox();
            tbpass = new TextBox();
            Lpassw = new Label();
            BLogin = new Button();
            SuspendLayout();
            // 
            // Lusern
            // 
            Lusern.AutoSize = true;
            Lusern.Location = new Point(10, 8);
            Lusern.Name = "Lusern";
            Lusern.Size = new Size(74, 20);
            Lusern.TabIndex = 0;
            Lusern.Text = "Username:";
            // 
            // tbusern
            // 
            tbusern.Location = new Point(15, 29);
            tbusern.Name = "tbusern";
            tbusern.Size = new Size(328, 25);
            tbusern.TabIndex = 1;
            // 
            // tbpass
            // 
            tbpass.Location = new Point(15, 84);
            tbpass.Name = "tbpass";
            tbpass.Size = new Size(328, 25);
            tbpass.TabIndex = 3;
            // 
            // Lpassw
            // 
            Lpassw.AutoSize = true;
            Lpassw.Location = new Point(10, 63);
            Lpassw.Name = "Lpassw";
            Lpassw.Size = new Size(72, 20);
            Lpassw.TabIndex = 2;
            Lpassw.Text = "Password:";
            // 
            // BLogin
            // 
            BLogin.Location = new Point(138, 115);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(75, 35);
            BLogin.TabIndex = 4;
            BLogin.Text = "Login";
            BLogin.UseVisualStyleBackColor = true;
            BLogin.Click += BLogin_Click;
            // 
            // frmLoginAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(367, 180);
            Controls.Add(BLogin);
            Controls.Add(tbpass);
            Controls.Add(Lpassw);
            Controls.Add(tbusern);
            Controls.Add(Lusern);
            Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLoginAccount";
            Text = "frmLoginAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lusern;
        private TextBox tbusern;
        private TextBox tbpass;
        private Label Lpassw;
        private Button BLogin;
    }
}