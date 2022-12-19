namespace winForm
{
    partial class Cars
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
            this.btnCarBack = new System.Windows.Forms.Button();
            this.lblSubmitMsg = new System.Windows.Forms.Label();
            this.btnCarSubmit = new System.Windows.Forms.Button();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.txtCarColor = new System.Windows.Forms.TextBox();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblCarColour = new System.Windows.Forms.Label();
            this.lblCarHeader = new System.Windows.Forms.Label();
            this.txtCarPrice = new System.Windows.Forms.TextBox();
            this.txtCarMileage = new System.Windows.Forms.TextBox();
            this.txtCarYear = new System.Windows.Forms.TextBox();
            this.lblCarPrice = new System.Windows.Forms.Label();
            this.lblCarMileage = new System.Windows.Forms.Label();
            this.lblCarYear = new System.Windows.Forms.Label();
            this.txtCarPreviousOwners = new System.Windows.Forms.TextBox();
            this.lblCarPreviousOwners = new System.Windows.Forms.Label();
            this.lblCarSubmitMsg = new System.Windows.Forms.Label();
            this.btnCarUpdate = new System.Windows.Forms.Button();
            this.btnCarDelete = new System.Windows.Forms.Button();
            this.dataGridCarList = new System.Windows.Forms.DataGridView();
            this.btnCarClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarBack
            // 
            this.btnCarBack.Location = new System.Drawing.Point(772, 267);
            this.btnCarBack.Name = "btnCarBack";
            this.btnCarBack.Size = new System.Drawing.Size(75, 31);
            this.btnCarBack.TabIndex = 24;
            this.btnCarBack.Text = "Back";
            this.btnCarBack.UseVisualStyleBackColor = true;
            this.btnCarBack.Click += new System.EventHandler(this.btnCarBack_Click);
            // 
            // lblSubmitMsg
            // 
            this.lblSubmitMsg.AutoSize = true;
            this.lblSubmitMsg.Location = new System.Drawing.Point(12, 305);
            this.lblSubmitMsg.Name = "lblSubmitMsg";
            this.lblSubmitMsg.Size = new System.Drawing.Size(0, 16);
            this.lblSubmitMsg.TabIndex = 20;
            // 
            // btnCarSubmit
            // 
            this.btnCarSubmit.Location = new System.Drawing.Point(131, 267);
            this.btnCarSubmit.Name = "btnCarSubmit";
            this.btnCarSubmit.Size = new System.Drawing.Size(75, 31);
            this.btnCarSubmit.TabIndex = 23;
            this.btnCarSubmit.Text = "Submit";
            this.btnCarSubmit.UseVisualStyleBackColor = true;
            this.btnCarSubmit.Click += new System.EventHandler(this.btnCarSubmit_Click);
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(184, 175);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(240, 22);
            this.txtCarModel.TabIndex = 18;
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(184, 128);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(240, 22);
            this.txtCarMake.TabIndex = 17;
            // 
            // txtCarColor
            // 
            this.txtCarColor.Location = new System.Drawing.Point(184, 86);
            this.txtCarColor.Name = "txtCarColor";
            this.txtCarColor.Size = new System.Drawing.Size(240, 22);
            this.txtCarColor.TabIndex = 16;
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(41, 181);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(45, 16);
            this.lblCarModel.TabIndex = 15;
            this.lblCarModel.Text = "Model";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(40, 134);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(41, 16);
            this.lblMake.TabIndex = 14;
            this.lblMake.Text = "Make";
            // 
            // lblCarColour
            // 
            this.lblCarColour.AutoSize = true;
            this.lblCarColour.Location = new System.Drawing.Point(40, 92);
            this.lblCarColour.Name = "lblCarColour";
            this.lblCarColour.Size = new System.Drawing.Size(39, 16);
            this.lblCarColour.TabIndex = 13;
            this.lblCarColour.Text = "Color";
            // 
            // lblCarHeader
            // 
            this.lblCarHeader.AutoSize = true;
            this.lblCarHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblCarHeader.Location = new System.Drawing.Point(329, 23);
            this.lblCarHeader.Name = "lblCarHeader";
            this.lblCarHeader.Size = new System.Drawing.Size(417, 38);
            this.lblCarHeader.TabIndex = 12;
            this.lblCarHeader.Text = "New Car Data Entry Form";
            // 
            // txtCarPrice
            // 
            this.txtCarPrice.Location = new System.Drawing.Point(733, 131);
            this.txtCarPrice.Name = "txtCarPrice";
            this.txtCarPrice.Size = new System.Drawing.Size(240, 22);
            this.txtCarPrice.TabIndex = 21;
            // 
            // txtCarMileage
            // 
            this.txtCarMileage.Location = new System.Drawing.Point(733, 89);
            this.txtCarMileage.Name = "txtCarMileage";
            this.txtCarMileage.Size = new System.Drawing.Size(240, 22);
            this.txtCarMileage.TabIndex = 20;
            // 
            // txtCarYear
            // 
            this.txtCarYear.Location = new System.Drawing.Point(184, 222);
            this.txtCarYear.Name = "txtCarYear";
            this.txtCarYear.Size = new System.Drawing.Size(240, 22);
            this.txtCarYear.TabIndex = 19;
            // 
            // lblCarPrice
            // 
            this.lblCarPrice.AutoSize = true;
            this.lblCarPrice.Location = new System.Drawing.Point(589, 134);
            this.lblCarPrice.Name = "lblCarPrice";
            this.lblCarPrice.Size = new System.Drawing.Size(38, 16);
            this.lblCarPrice.TabIndex = 24;
            this.lblCarPrice.Text = "Price";
            // 
            // lblCarMileage
            // 
            this.lblCarMileage.AutoSize = true;
            this.lblCarMileage.Location = new System.Drawing.Point(589, 92);
            this.lblCarMileage.Name = "lblCarMileage";
            this.lblCarMileage.Size = new System.Drawing.Size(56, 16);
            this.lblCarMileage.TabIndex = 23;
            this.lblCarMileage.Text = "Mileage";
            // 
            // lblCarYear
            // 
            this.lblCarYear.AutoSize = true;
            this.lblCarYear.Location = new System.Drawing.Point(40, 228);
            this.lblCarYear.Name = "lblCarYear";
            this.lblCarYear.Size = new System.Drawing.Size(36, 16);
            this.lblCarYear.TabIndex = 22;
            this.lblCarYear.Text = "Year";
            // 
            // txtCarPreviousOwners
            // 
            this.txtCarPreviousOwners.Location = new System.Drawing.Point(733, 178);
            this.txtCarPreviousOwners.Name = "txtCarPreviousOwners";
            this.txtCarPreviousOwners.Size = new System.Drawing.Size(240, 22);
            this.txtCarPreviousOwners.TabIndex = 22;
            // 
            // lblCarPreviousOwners
            // 
            this.lblCarPreviousOwners.AutoSize = true;
            this.lblCarPreviousOwners.Location = new System.Drawing.Point(589, 181);
            this.lblCarPreviousOwners.Name = "lblCarPreviousOwners";
            this.lblCarPreviousOwners.Size = new System.Drawing.Size(108, 16);
            this.lblCarPreviousOwners.TabIndex = 29;
            this.lblCarPreviousOwners.Text = "Previous Owners";
            // 
            // lblCarSubmitMsg
            // 
            this.lblCarSubmitMsg.AutoSize = true;
            this.lblCarSubmitMsg.Location = new System.Drawing.Point(227, 509);
            this.lblCarSubmitMsg.Name = "lblCarSubmitMsg";
            this.lblCarSubmitMsg.Size = new System.Drawing.Size(0, 16);
            this.lblCarSubmitMsg.TabIndex = 32;
            // 
            // btnCarUpdate
            // 
            this.btnCarUpdate.Location = new System.Drawing.Point(336, 267);
            this.btnCarUpdate.Name = "btnCarUpdate";
            this.btnCarUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnCarUpdate.TabIndex = 33;
            this.btnCarUpdate.Text = "Update";
            this.btnCarUpdate.UseVisualStyleBackColor = true;
            this.btnCarUpdate.Click += new System.EventHandler(this.btnCarUpdate_Click);
            // 
            // btnCarDelete
            // 
            this.btnCarDelete.Location = new System.Drawing.Point(492, 267);
            this.btnCarDelete.Name = "btnCarDelete";
            this.btnCarDelete.Size = new System.Drawing.Size(75, 31);
            this.btnCarDelete.TabIndex = 34;
            this.btnCarDelete.Text = "Delete";
            this.btnCarDelete.UseVisualStyleBackColor = true;
            this.btnCarDelete.Click += new System.EventHandler(this.btnCarDelete_Click);
            // 
            // dataGridCarList
            // 
            this.dataGridCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridCarList.Location = new System.Drawing.Point(0, 358);
            this.dataGridCarList.Name = "dataGridCarList";
            this.dataGridCarList.RowHeadersWidth = 51;
            this.dataGridCarList.RowTemplate.Height = 24;
            this.dataGridCarList.Size = new System.Drawing.Size(1575, 468);
            this.dataGridCarList.TabIndex = 35;
            this.dataGridCarList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCarList_CellClick);
            // 
            // btnCarClear
            // 
            this.btnCarClear.Location = new System.Drawing.Point(631, 267);
            this.btnCarClear.Name = "btnCarClear";
            this.btnCarClear.Size = new System.Drawing.Size(75, 31);
            this.btnCarClear.TabIndex = 36;
            this.btnCarClear.Text = "Clear";
            this.btnCarClear.UseVisualStyleBackColor = true;
            this.btnCarClear.Click += new System.EventHandler(this.btnCarClear_Click);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 826);
            this.Controls.Add(this.btnCarClear);
            this.Controls.Add(this.dataGridCarList);
            this.Controls.Add(this.btnCarDelete);
            this.Controls.Add(this.btnCarUpdate);
            this.Controls.Add(this.lblCarSubmitMsg);
            this.Controls.Add(this.txtCarPreviousOwners);
            this.Controls.Add(this.lblCarPreviousOwners);
            this.Controls.Add(this.txtCarPrice);
            this.Controls.Add(this.txtCarMileage);
            this.Controls.Add(this.txtCarYear);
            this.Controls.Add(this.lblCarPrice);
            this.Controls.Add(this.lblCarMileage);
            this.Controls.Add(this.lblCarYear);
            this.Controls.Add(this.btnCarBack);
            this.Controls.Add(this.lblSubmitMsg);
            this.Controls.Add(this.btnCarSubmit);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtCarMake);
            this.Controls.Add(this.txtCarColor);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblCarColour);
            this.Controls.Add(this.lblCarHeader);
            this.Name = "Cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarBack;
        private System.Windows.Forms.Label lblSubmitMsg;
        private System.Windows.Forms.Button btnCarSubmit;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarMake;
        private System.Windows.Forms.TextBox txtCarColor;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblCarColour;
        private System.Windows.Forms.Label lblCarHeader;
        private System.Windows.Forms.TextBox txtCarPrice;
        private System.Windows.Forms.TextBox txtCarMileage;
        private System.Windows.Forms.TextBox txtCarYear;
        private System.Windows.Forms.Label lblCarPrice;
        private System.Windows.Forms.Label lblCarMileage;
        private System.Windows.Forms.Label lblCarYear;
        private System.Windows.Forms.TextBox txtCarPreviousOwners;
        private System.Windows.Forms.Label lblCarPreviousOwners;
        private System.Windows.Forms.Label lblCarSubmitMsg;
        private System.Windows.Forms.Button btnCarUpdate;
        private System.Windows.Forms.Button btnCarDelete;
        private System.Windows.Forms.DataGridView dataGridCarList;
        private System.Windows.Forms.Button btnCarClear;
    }
}