namespace FruitsProject
{
    partial class Registration
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
            this.lblregusername = new System.Windows.Forms.Label();
            this.lblregpassword = new System.Windows.Forms.Label();
            this.lblregaddress = new System.Windows.Forms.Label();
            this.lblregcontact = new System.Windows.Forms.Label();
            this.lblregemail = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblregusername
            // 
            this.lblregusername.AutoSize = true;
            this.lblregusername.Location = new System.Drawing.Point(190, 56);
            this.lblregusername.Name = "lblregusername";
            this.lblregusername.Size = new System.Drawing.Size(108, 13);
            this.lblregusername.TabIndex = 0;
            this.lblregusername.Text = "ENTER USERNAME";
            // 
            // lblregpassword
            // 
            this.lblregpassword.AutoSize = true;
            this.lblregpassword.Location = new System.Drawing.Point(190, 110);
            this.lblregpassword.Name = "lblregpassword";
            this.lblregpassword.Size = new System.Drawing.Size(110, 13);
            this.lblregpassword.TabIndex = 1;
            this.lblregpassword.Text = "ENTER PASSWORD";
            // 
            // lblregaddress
            // 
            this.lblregaddress.AutoSize = true;
            this.lblregaddress.Location = new System.Drawing.Point(190, 154);
            this.lblregaddress.Name = "lblregaddress";
            this.lblregaddress.Size = new System.Drawing.Size(99, 13);
            this.lblregaddress.TabIndex = 2;
            this.lblregaddress.Text = "ENTER ADDRESS";
            // 
            // lblregcontact
            // 
            this.lblregcontact.AutoSize = true;
            this.lblregcontact.Location = new System.Drawing.Point(190, 203);
            this.lblregcontact.Name = "lblregcontact";
            this.lblregcontact.Size = new System.Drawing.Size(148, 13);
            this.lblregcontact.TabIndex = 3;
            this.lblregcontact.Text = "ENTER CONTACT NUMBER";
            // 
            // lblregemail
            // 
            this.lblregemail.AutoSize = true;
            this.lblregemail.Location = new System.Drawing.Point(190, 244);
            this.lblregemail.Name = "lblregemail";
            this.lblregemail.Size = new System.Drawing.Size(79, 13);
            this.lblregemail.TabIndex = 4;
            this.lblregemail.Text = "ENTER EMAIL";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(387, 56);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(199, 20);
            this.txtusername.TabIndex = 6;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(387, 107);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(199, 20);
            this.txtpassword.TabIndex = 7;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(387, 154);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(199, 20);
            this.txtaddress.TabIndex = 8;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(387, 203);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(199, 20);
            this.txtcontact.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(387, 244);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(199, 20);
            this.txtemail.TabIndex = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(242, 385);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(387, 385);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 505);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblregemail);
            this.Controls.Add(this.lblregcontact);
            this.Controls.Add(this.lblregaddress);
            this.Controls.Add(this.lblregpassword);
            this.Controls.Add(this.lblregusername);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblregusername;
        private System.Windows.Forms.Label lblregpassword;
        private System.Windows.Forms.Label lblregaddress;
        private System.Windows.Forms.Label lblregcontact;
        private System.Windows.Forms.Label lblregemail;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReset;
    }
}