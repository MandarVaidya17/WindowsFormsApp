namespace WindowsFormsApp
{
    partial class Form1
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
            this.Btncancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btncancel
            // 
            this.Btncancel.Location = new System.Drawing.Point(200, 172);
            this.Btncancel.Name = "Btncancel";
            this.Btncancel.Size = new System.Drawing.Size(75, 39);
            this.Btncancel.TabIndex = 0;
            this.Btncancel.Text = "Cancel";
            this.Btncancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(77, 172);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 39);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(200, 85);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(230, 26);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(200, 37);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(230, 26);
            this.txtusername.TabIndex = 3;
            this.txtusername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Btncancel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btncancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
    }
}