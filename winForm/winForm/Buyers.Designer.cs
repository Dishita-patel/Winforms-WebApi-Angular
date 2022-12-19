namespace winForm
{
    partial class Buyers
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
            this.lblBuyerHeader = new System.Windows.Forms.Label();
            this.lblBuyerfn = new System.Windows.Forms.Label();
            this.lblBuyerln = new System.Windows.Forms.Label();
            this.lblBuyerAge = new System.Windows.Forms.Label();
            this.txtBuyerfn = new System.Windows.Forms.TextBox();
            this.txtBuyerln = new System.Windows.Forms.TextBox();
            this.txtBuyerAge = new System.Windows.Forms.TextBox();
            this.btnBuyerSubmit = new System.Windows.Forms.Button();
            this.lblBuyerSubmitMsg = new System.Windows.Forms.Label();
            this.btnBuyerBack = new System.Windows.Forms.Button();
            this.btnBuyerDelete = new System.Windows.Forms.Button();
            this.btnBuyerUpdate = new System.Windows.Forms.Button();
            this.dataGridBuyerList = new System.Windows.Forms.DataGridView();
            this.btnBuyerClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuyerList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuyerHeader
            // 
            this.lblBuyerHeader.AutoSize = true;
            this.lblBuyerHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblBuyerHeader.Location = new System.Drawing.Point(182, 37);
            this.lblBuyerHeader.Name = "lblBuyerHeader";
            this.lblBuyerHeader.Size = new System.Drawing.Size(452, 38);
            this.lblBuyerHeader.TabIndex = 0;
            this.lblBuyerHeader.Text = "New Buyer Data Entry Form";
            // 
            // lblBuyerfn
            // 
            this.lblBuyerfn.AutoSize = true;
            this.lblBuyerfn.Location = new System.Drawing.Point(20, 106);
            this.lblBuyerfn.Name = "lblBuyerfn";
            this.lblBuyerfn.Size = new System.Drawing.Size(69, 16);
            this.lblBuyerfn.TabIndex = 1;
            this.lblBuyerfn.Text = "FirstName";
            // 
            // lblBuyerln
            // 
            this.lblBuyerln.AutoSize = true;
            this.lblBuyerln.Location = new System.Drawing.Point(353, 103);
            this.lblBuyerln.Name = "lblBuyerln";
            this.lblBuyerln.Size = new System.Drawing.Size(69, 16);
            this.lblBuyerln.TabIndex = 2;
            this.lblBuyerln.Text = "LastName";
            // 
            // lblBuyerAge
            // 
            this.lblBuyerAge.AutoSize = true;
            this.lblBuyerAge.Location = new System.Drawing.Point(729, 106);
            this.lblBuyerAge.Name = "lblBuyerAge";
            this.lblBuyerAge.Size = new System.Drawing.Size(32, 16);
            this.lblBuyerAge.TabIndex = 3;
            this.lblBuyerAge.Text = "Age";
            // 
            // txtBuyerfn
            // 
            this.txtBuyerfn.Location = new System.Drawing.Point(95, 100);
            this.txtBuyerfn.Name = "txtBuyerfn";
            this.txtBuyerfn.Size = new System.Drawing.Size(196, 22);
            this.txtBuyerfn.TabIndex = 5;
            // 
            // txtBuyerln
            // 
            this.txtBuyerln.Location = new System.Drawing.Point(428, 100);
            this.txtBuyerln.Name = "txtBuyerln";
            this.txtBuyerln.Size = new System.Drawing.Size(240, 22);
            this.txtBuyerln.TabIndex = 6;
            // 
            // txtBuyerAge
            // 
            this.txtBuyerAge.Location = new System.Drawing.Point(767, 100);
            this.txtBuyerAge.Name = "txtBuyerAge";
            this.txtBuyerAge.Size = new System.Drawing.Size(240, 22);
            this.txtBuyerAge.TabIndex = 7;
            this.txtBuyerAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyerAge_KeyPress);
            // 
            // btnBuyerSubmit
            // 
            this.btnBuyerSubmit.Location = new System.Drawing.Point(32, 178);
            this.btnBuyerSubmit.Name = "btnBuyerSubmit";
            this.btnBuyerSubmit.Size = new System.Drawing.Size(75, 31);
            this.btnBuyerSubmit.TabIndex = 9;
            this.btnBuyerSubmit.Text = "Submit";
            this.btnBuyerSubmit.UseVisualStyleBackColor = true;
            this.btnBuyerSubmit.Click += new System.EventHandler(this.btnBuyerSubmit_Click);
            // 
            // lblBuyerSubmitMsg
            // 
            this.lblBuyerSubmitMsg.AutoSize = true;
            this.lblBuyerSubmitMsg.Location = new System.Drawing.Point(20, 247);
            this.lblBuyerSubmitMsg.Name = "lblBuyerSubmitMsg";
            this.lblBuyerSubmitMsg.Size = new System.Drawing.Size(0, 16);
            this.lblBuyerSubmitMsg.TabIndex = 10;
            // 
            // btnBuyerBack
            // 
            this.btnBuyerBack.Location = new System.Drawing.Point(932, 178);
            this.btnBuyerBack.Name = "btnBuyerBack";
            this.btnBuyerBack.Size = new System.Drawing.Size(75, 31);
            this.btnBuyerBack.TabIndex = 11;
            this.btnBuyerBack.Text = "Back";
            this.btnBuyerBack.UseVisualStyleBackColor = true;
            this.btnBuyerBack.Click += new System.EventHandler(this.btnBuyerBack_Click);
            // 
            // btnBuyerDelete
            // 
            this.btnBuyerDelete.Location = new System.Drawing.Point(559, 178);
            this.btnBuyerDelete.Name = "btnBuyerDelete";
            this.btnBuyerDelete.Size = new System.Drawing.Size(75, 31);
            this.btnBuyerDelete.TabIndex = 36;
            this.btnBuyerDelete.Text = "Delete";
            this.btnBuyerDelete.UseVisualStyleBackColor = true;
            this.btnBuyerDelete.Click += new System.EventHandler(this.btnBuyerDelete_Click);
            // 
            // btnBuyerUpdate
            // 
            this.btnBuyerUpdate.Location = new System.Drawing.Point(243, 178);
            this.btnBuyerUpdate.Name = "btnBuyerUpdate";
            this.btnBuyerUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnBuyerUpdate.TabIndex = 35;
            this.btnBuyerUpdate.Text = "Update";
            this.btnBuyerUpdate.UseVisualStyleBackColor = true;
            this.btnBuyerUpdate.Click += new System.EventHandler(this.btnBuyerUpdate_Click);
            // 
            // dataGridBuyerList
            // 
            this.dataGridBuyerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuyerList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridBuyerList.Location = new System.Drawing.Point(0, 300);
            this.dataGridBuyerList.Name = "dataGridBuyerList";
            this.dataGridBuyerList.RowHeadersWidth = 51;
            this.dataGridBuyerList.RowTemplate.Height = 24;
            this.dataGridBuyerList.Size = new System.Drawing.Size(1575, 526);
            this.dataGridBuyerList.TabIndex = 37;
            this.dataGridBuyerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBuyerList_CellClick);
            // 
            // btnBuyerClear
            // 
            this.btnBuyerClear.Location = new System.Drawing.Point(732, 178);
            this.btnBuyerClear.Name = "btnBuyerClear";
            this.btnBuyerClear.Size = new System.Drawing.Size(75, 31);
            this.btnBuyerClear.TabIndex = 38;
            this.btnBuyerClear.Text = "Clear";
            this.btnBuyerClear.UseVisualStyleBackColor = true;
            this.btnBuyerClear.Click += new System.EventHandler(this.btnBuyerClear_Click);
            // 
            // Buyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 826);
            this.Controls.Add(this.btnBuyerClear);
            this.Controls.Add(this.dataGridBuyerList);
            this.Controls.Add(this.btnBuyerDelete);
            this.Controls.Add(this.btnBuyerUpdate);
            this.Controls.Add(this.btnBuyerBack);
            this.Controls.Add(this.lblBuyerSubmitMsg);
            this.Controls.Add(this.btnBuyerSubmit);
            this.Controls.Add(this.txtBuyerAge);
            this.Controls.Add(this.txtBuyerln);
            this.Controls.Add(this.txtBuyerfn);
            this.Controls.Add(this.lblBuyerAge);
            this.Controls.Add(this.lblBuyerln);
            this.Controls.Add(this.lblBuyerfn);
            this.Controls.Add(this.lblBuyerHeader);
            this.Name = "Buyers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buyers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuyerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuyerHeader;
        private System.Windows.Forms.Label lblBuyerfn;
        private System.Windows.Forms.Label lblBuyerln;
        private System.Windows.Forms.Label lblBuyerAge;
        private System.Windows.Forms.TextBox txtBuyerfn;
        private System.Windows.Forms.TextBox txtBuyerln;
        private System.Windows.Forms.TextBox txtBuyerAge;
        private System.Windows.Forms.Button btnBuyerSubmit;
        private System.Windows.Forms.Label lblBuyerSubmitMsg;
        private System.Windows.Forms.Button btnBuyerBack;
        private System.Windows.Forms.Button btnBuyerDelete;
        private System.Windows.Forms.Button btnBuyerUpdate;
        private System.Windows.Forms.DataGridView dataGridBuyerList;
        private System.Windows.Forms.Button btnBuyerClear;
    }
}