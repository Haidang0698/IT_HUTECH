namespace Lab02_03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccID = new System.Windows.Forms.TextBox();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.txtAccAddress = new System.Windows.Forms.TextBox();
            this.txtAccMoney = new System.Windows.Forms.TextBox();
            this.btnAdd_Update = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lstAccount = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(169, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(135, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(116, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(24, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(763, 52);
            this.label4.TabIndex = 3;
            this.label4.Text = "MANAGE ACCOUNT INFORMATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(30, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "The Money In The Account";
            // 
            // txtAccID
            // 
            this.txtAccID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAccID.Location = new System.Drawing.Point(277, 77);
            this.txtAccID.Name = "txtAccID";
            this.txtAccID.Size = new System.Drawing.Size(467, 28);
            this.txtAccID.TabIndex = 5;
            // 
            // txtAccName
            // 
            this.txtAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAccName.Location = new System.Drawing.Point(277, 118);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(467, 28);
            this.txtAccName.TabIndex = 6;
            // 
            // txtAccAddress
            // 
            this.txtAccAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAccAddress.Location = new System.Drawing.Point(277, 161);
            this.txtAccAddress.Name = "txtAccAddress";
            this.txtAccAddress.Size = new System.Drawing.Size(467, 28);
            this.txtAccAddress.TabIndex = 7;
            // 
            // txtAccMoney
            // 
            this.txtAccMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAccMoney.Location = new System.Drawing.Point(277, 201);
            this.txtAccMoney.Name = "txtAccMoney";
            this.txtAccMoney.Size = new System.Drawing.Size(467, 28);
            this.txtAccMoney.TabIndex = 8;
            // 
            // btnAdd_Update
            // 
            this.btnAdd_Update.Location = new System.Drawing.Point(361, 238);
            this.btnAdd_Update.Name = "btnAdd_Update";
            this.btnAdd_Update.Size = new System.Drawing.Size(112, 28);
            this.btnAdd_Update.TabIndex = 10;
            this.btnAdd_Update.Text = "Add/Update";
            this.btnAdd_Update.UseVisualStyleBackColor = true;
            this.btnAdd_Update.Click += new System.EventHandler(this.btnAdd_Update_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(493, 238);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 28);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(615, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 28);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(398, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Money";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTotal.Location = new System.Drawing.Point(518, 449);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(292, 28);
            this.txtTotal.TabIndex = 14;
            // 
            // lstAccount
            // 
            this.lstAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colAccID,
            this.colAccName,
            this.colAccAddress,
            this.colAccMoney});
            this.lstAccount.FullRowSelect = true;
            this.lstAccount.GridLines = true;
            this.lstAccount.HideSelection = false;
            this.lstAccount.Location = new System.Drawing.Point(13, 272);
            this.lstAccount.Name = "lstAccount";
            this.lstAccount.Size = new System.Drawing.Size(797, 171);
            this.lstAccount.TabIndex = 15;
            this.lstAccount.UseCompatibleStateImageBehavior = false;
            this.lstAccount.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 40;
            // 
            // colAccID
            // 
            this.colAccID.Tag = "txtAccID";
            this.colAccID.Text = "Account ID";
            this.colAccID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAccID.Width = 85;
            // 
            // colAccName
            // 
            this.colAccName.Tag = "txtAccName";
            this.colAccName.Text = "Account Name";
            this.colAccName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAccName.Width = 182;
            // 
            // colAccAddress
            // 
            this.colAccAddress.Text = "Address";
            this.colAccAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAccAddress.Width = 164;
            // 
            // colAccMoney
            // 
            this.colAccMoney.Text = "Money";
            this.colAccMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAccMoney.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 488);
            this.Controls.Add(this.lstAccount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd_Update);
            this.Controls.Add(this.txtAccMoney);
            this.Controls.Add(this.txtAccAddress);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.txtAccID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Account Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccID;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.TextBox txtAccAddress;
        private System.Windows.Forms.TextBox txtAccMoney;
        private System.Windows.Forms.Button btnAdd_Update;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListView lstAccount;
        private System.Windows.Forms.ColumnHeader colSTT;
        public System.Windows.Forms.ColumnHeader colAccID;
        public System.Windows.Forms.ColumnHeader colAccName;
        public System.Windows.Forms.ColumnHeader colAccAddress;
        public System.Windows.Forms.ColumnHeader colAccMoney;
    }
}

