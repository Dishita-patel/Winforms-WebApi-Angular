namespace winForm
{
    partial class Welcome
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
            this.btnNewBuyer = new System.Windows.Forms.Button();
            this.btnNewCar = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewBuyer
            // 
            this.btnNewBuyer.Location = new System.Drawing.Point(196, 283);
            this.btnNewBuyer.Name = "btnNewBuyer";
            this.btnNewBuyer.Size = new System.Drawing.Size(137, 45);
            this.btnNewBuyer.TabIndex = 0;
            this.btnNewBuyer.Text = "Buyer UI";
            this.btnNewBuyer.UseVisualStyleBackColor = true;
            this.btnNewBuyer.Click += new System.EventHandler(this.btnNewBuyer_Click);
            // 
            // btnNewCar
            // 
            this.btnNewCar.Location = new System.Drawing.Point(365, 283);
            this.btnNewCar.Name = "btnNewCar";
            this.btnNewCar.Size = new System.Drawing.Size(137, 45);
            this.btnNewCar.TabIndex = 1;
            this.btnNewCar.Text = "Car UI";
            this.btnNewCar.UseVisualStyleBackColor = true;
            this.btnNewCar.Click += new System.EventHandler(this.btnNewCar_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(528, 283);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(137, 45);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 695);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnNewCar);
            this.Controls.Add(this.btnNewBuyer);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewBuyer;
        private System.Windows.Forms.Button btnNewCar;
        private System.Windows.Forms.Button btnLogOut;
    }
}