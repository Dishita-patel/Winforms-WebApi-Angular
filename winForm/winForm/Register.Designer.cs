namespace winForm
{
    partial class Register
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
            this.btnUsrClear = new System.Windows.Forms.Button();
            this.txtUsrPswd = new System.Windows.Forms.TextBox();
            this.txtUsrLoginName = new System.Windows.Forms.TextBox();
            this.lblUsrCPswd = new System.Windows.Forms.Label();
            this.lblUsrPswd = new System.Windows.Forms.Label();
            this.btnUsrBack = new System.Windows.Forms.Button();
            this.btnUsrRegister = new System.Windows.Forms.Button();
            this.txtUsrEmpType = new System.Windows.Forms.TextBox();
            this.txtUsrln = new System.Windows.Forms.TextBox();
            this.txtUsrfn = new System.Windows.Forms.TextBox();
            this.lblUsrEmpType = new System.Windows.Forms.Label();
            this.lblUsrln = new System.Windows.Forms.Label();
            this.lblUsrfn = new System.Windows.Forms.Label();
            this.lblCarHeader = new System.Windows.Forms.Label();
            this.lblUsrLoginName = new System.Windows.Forms.Label();
            this.txtUsrCPswd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUsrClear
            // 
            this.btnUsrClear.Location = new System.Drawing.Point(703, 306);
            this.btnUsrClear.Name = "btnUsrClear";
            this.btnUsrClear.Size = new System.Drawing.Size(75, 31);
            this.btnUsrClear.TabIndex = 56;
            this.btnUsrClear.Text = "Clear";
            this.btnUsrClear.UseVisualStyleBackColor = true;
            this.btnUsrClear.Click += new System.EventHandler(this.btnUsrClear_Click);
            // 
            // txtUsrPswd
            // 
            this.txtUsrPswd.Location = new System.Drawing.Point(982, 170);
            this.txtUsrPswd.Name = "txtUsrPswd";
            this.txtUsrPswd.Size = new System.Drawing.Size(240, 22);
            this.txtUsrPswd.TabIndex = 46;
            // 
            // txtUsrLoginName
            // 
            this.txtUsrLoginName.Location = new System.Drawing.Point(982, 128);
            this.txtUsrLoginName.Name = "txtUsrLoginName";
            this.txtUsrLoginName.Size = new System.Drawing.Size(240, 22);
            this.txtUsrLoginName.TabIndex = 45;
            // 
            // lblUsrCPswd
            // 
            this.lblUsrCPswd.AutoSize = true;
            this.lblUsrCPswd.Location = new System.Drawing.Point(838, 220);
            this.lblUsrCPswd.Name = "lblUsrCPswd";
            this.lblUsrCPswd.Size = new System.Drawing.Size(115, 16);
            this.lblUsrCPswd.TabIndex = 52;
            this.lblUsrCPswd.Text = "Confirm Password";
            // 
            // lblUsrPswd
            // 
            this.lblUsrPswd.AutoSize = true;
            this.lblUsrPswd.Location = new System.Drawing.Point(838, 173);
            this.lblUsrPswd.Name = "lblUsrPswd";
            this.lblUsrPswd.Size = new System.Drawing.Size(67, 16);
            this.lblUsrPswd.TabIndex = 49;
            this.lblUsrPswd.Text = "Password";
            // 
            // btnUsrBack
            // 
            this.btnUsrBack.Location = new System.Drawing.Point(946, 306);
            this.btnUsrBack.Name = "btnUsrBack";
            this.btnUsrBack.Size = new System.Drawing.Size(75, 31);
            this.btnUsrBack.TabIndex = 51;
            this.btnUsrBack.Text = "Back";
            this.btnUsrBack.UseVisualStyleBackColor = true;
            this.btnUsrBack.Click += new System.EventHandler(this.btnUsrBack_Click);
            // 
            // btnUsrRegister
            // 
            this.btnUsrRegister.Location = new System.Drawing.Point(443, 306);
            this.btnUsrRegister.Name = "btnUsrRegister";
            this.btnUsrRegister.Size = new System.Drawing.Size(75, 31);
            this.btnUsrRegister.TabIndex = 50;
            this.btnUsrRegister.Text = "Register";
            this.btnUsrRegister.UseVisualStyleBackColor = true;
            this.btnUsrRegister.Click += new System.EventHandler(this.btnUsrSubmit_Click);
            // 
            // txtUsrEmpType
            // 
            this.txtUsrEmpType.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUsrEmpType.Enabled = false;
            this.txtUsrEmpType.Location = new System.Drawing.Point(433, 214);
            this.txtUsrEmpType.Name = "txtUsrEmpType";
            this.txtUsrEmpType.Size = new System.Drawing.Size(240, 22);
            this.txtUsrEmpType.TabIndex = 43;
            this.txtUsrEmpType.Text = "Employee";
            // 
            // txtUsrln
            // 
            this.txtUsrln.Location = new System.Drawing.Point(433, 167);
            this.txtUsrln.Name = "txtUsrln";
            this.txtUsrln.Size = new System.Drawing.Size(240, 22);
            this.txtUsrln.TabIndex = 42;
            // 
            // txtUsrfn
            // 
            this.txtUsrfn.Location = new System.Drawing.Point(433, 125);
            this.txtUsrfn.Name = "txtUsrfn";
            this.txtUsrfn.Size = new System.Drawing.Size(240, 22);
            this.txtUsrfn.TabIndex = 41;
            // 
            // lblUsrEmpType
            // 
            this.lblUsrEmpType.AutoSize = true;
            this.lblUsrEmpType.Location = new System.Drawing.Point(290, 220);
            this.lblUsrEmpType.Name = "lblUsrEmpType";
            this.lblUsrEmpType.Size = new System.Drawing.Size(104, 16);
            this.lblUsrEmpType.TabIndex = 40;
            this.lblUsrEmpType.Text = "Employee Type";
            // 
            // lblUsrln
            // 
            this.lblUsrln.AutoSize = true;
            this.lblUsrln.Location = new System.Drawing.Point(289, 173);
            this.lblUsrln.Name = "lblUsrln";
            this.lblUsrln.Size = new System.Drawing.Size(69, 16);
            this.lblUsrln.TabIndex = 39;
            this.lblUsrln.Text = "LastName";
            // 
            // lblUsrfn
            // 
            this.lblUsrfn.AutoSize = true;
            this.lblUsrfn.Location = new System.Drawing.Point(289, 131);
            this.lblUsrfn.Name = "lblUsrfn";
            this.lblUsrfn.Size = new System.Drawing.Size(69, 16);
            this.lblUsrfn.TabIndex = 38;
            this.lblUsrfn.Text = "FirstName";
            // 
            // lblCarHeader
            // 
            this.lblCarHeader.AutoSize = true;
            this.lblCarHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblCarHeader.Location = new System.Drawing.Point(578, 62);
            this.lblCarHeader.Name = "lblCarHeader";
            this.lblCarHeader.Size = new System.Drawing.Size(293, 38);
            this.lblCarHeader.TabIndex = 37;
            this.lblCarHeader.Text = "Registration Form";
            // 
            // lblUsrLoginName
            // 
            this.lblUsrLoginName.AutoSize = true;
            this.lblUsrLoginName.Location = new System.Drawing.Point(838, 131);
            this.lblUsrLoginName.Name = "lblUsrLoginName";
            this.lblUsrLoginName.Size = new System.Drawing.Size(77, 16);
            this.lblUsrLoginName.TabIndex = 53;
            this.lblUsrLoginName.Text = "LoginName";
            // 
            // txtUsrCPswd
            // 
            this.txtUsrCPswd.Location = new System.Drawing.Point(982, 217);
            this.txtUsrCPswd.Name = "txtUsrCPswd";
            this.txtUsrCPswd.Size = new System.Drawing.Size(240, 22);
            this.txtUsrCPswd.TabIndex = 47;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 826);
            this.Controls.Add(this.btnUsrClear);
            this.Controls.Add(this.txtUsrCPswd);
            this.Controls.Add(this.lblUsrLoginName);
            this.Controls.Add(this.txtUsrPswd);
            this.Controls.Add(this.txtUsrLoginName);
            this.Controls.Add(this.lblUsrCPswd);
            this.Controls.Add(this.lblUsrPswd);
            this.Controls.Add(this.btnUsrBack);
            this.Controls.Add(this.btnUsrRegister);
            this.Controls.Add(this.txtUsrEmpType);
            this.Controls.Add(this.txtUsrln);
            this.Controls.Add(this.txtUsrfn);
            this.Controls.Add(this.lblUsrEmpType);
            this.Controls.Add(this.lblUsrln);
            this.Controls.Add(this.lblUsrfn);
            this.Controls.Add(this.lblCarHeader);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsrClear;
        private System.Windows.Forms.TextBox txtUsrPswd;
        private System.Windows.Forms.TextBox txtUsrLoginName;
        private System.Windows.Forms.Label lblUsrCPswd;
        private System.Windows.Forms.Label lblUsrPswd;
        private System.Windows.Forms.Button btnUsrBack;
        private System.Windows.Forms.Button btnUsrRegister;
        private System.Windows.Forms.TextBox txtUsrEmpType;
        private System.Windows.Forms.TextBox txtUsrln;
        private System.Windows.Forms.TextBox txtUsrfn;
        private System.Windows.Forms.Label lblUsrEmpType;
        private System.Windows.Forms.Label lblUsrln;
        private System.Windows.Forms.Label lblUsrfn;
        private System.Windows.Forms.Label lblCarHeader;
        private System.Windows.Forms.Label lblUsrLoginName;
        private System.Windows.Forms.TextBox txtUsrCPswd;
    }
}