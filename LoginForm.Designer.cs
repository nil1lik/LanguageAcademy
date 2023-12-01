namespace LanguageAcademy
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txt_loginName = new System.Windows.Forms.TextBox();
            this.txt_loginPass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_loginName
            // 
            this.txt_loginName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_loginName.Location = new System.Drawing.Point(192, 142);
            this.txt_loginName.Name = "txt_loginName";
            this.txt_loginName.Size = new System.Drawing.Size(216, 20);
            this.txt_loginName.TabIndex = 0;
            this.txt_loginName.Text = "Please enter username.";
            // 
            // txt_loginPass
            // 
            this.txt_loginPass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_loginPass.Location = new System.Drawing.Point(192, 168);
            this.txt_loginPass.Name = "txt_loginPass";
            this.txt_loginPass.Size = new System.Drawing.Size(216, 20);
            this.txt_loginPass.TabIndex = 1;
            this.txt_loginPass.Text = "Please enter password.";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_login.Location = new System.Drawing.Point(241, 194);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(117, 28);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LanguageAcademy.Properties.Resources._732c2a61c1763251636de374736654fd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 399);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_loginPass);
            this.Controls.Add(this.txt_loginName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Language Academy - Please Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_loginName;
        private System.Windows.Forms.TextBox txt_loginPass;
        private System.Windows.Forms.Button btn_login;
    }
}