namespace Lab02_02
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
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCREEN";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCost.Location = new System.Drawing.Point(24, 325);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(62, 29);
            this.lblCost.TabIndex = 16;
            this.lblCost.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCost.Location = new System.Drawing.Point(91, 322);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(276, 34);
            this.txtCost.TabIndex = 17;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(60, 382);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(70, 33);
            this.btnChoose.TabIndex = 18;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(163, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 33);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(268, 382);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(70, 33);
            this.btnFinish.TabIndex = 20;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 50);
            this.panel1.TabIndex = 22;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn1.Location = new System.Drawing.Point(6, 21);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 69);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn2.Location = new System.Drawing.Point(80, 21);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 69);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn3.Location = new System.Drawing.Point(155, 21);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 69);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn4.Location = new System.Drawing.Point(227, 21);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(68, 69);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn5.Location = new System.Drawing.Point(301, 21);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(68, 69);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn6.Location = new System.Drawing.Point(5, 96);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(68, 69);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn7.Location = new System.Drawing.Point(79, 96);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(68, 69);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn8.Location = new System.Drawing.Point(153, 96);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(68, 69);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn9.Location = new System.Drawing.Point(227, 96);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(68, 69);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.White;
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn10.Location = new System.Drawing.Point(301, 96);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(68, 69);
            this.btn10.TabIndex = 10;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.White;
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn11.Location = new System.Drawing.Point(6, 171);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(68, 69);
            this.btn11.TabIndex = 11;
            this.btn11.Text = "11";
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.White;
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn12.Location = new System.Drawing.Point(80, 171);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(68, 69);
            this.btn12.TabIndex = 12;
            this.btn12.Text = "12";
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.White;
            this.btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn13.Location = new System.Drawing.Point(153, 171);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(68, 69);
            this.btn13.TabIndex = 13;
            this.btn13.Text = "13";
            this.btn13.UseVisualStyleBackColor = false;
            this.btn13.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn14
            // 
            this.btn14.BackColor = System.Drawing.Color.White;
            this.btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn14.Location = new System.Drawing.Point(227, 171);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(68, 69);
            this.btn14.TabIndex = 14;
            this.btn14.Text = "14";
            this.btn14.UseVisualStyleBackColor = false;
            this.btn14.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.White;
            this.btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn15.Location = new System.Drawing.Point(301, 171);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(68, 69);
            this.btn15.TabIndex = 15;
            this.btn15.Text = "15";
            this.btn15.UseVisualStyleBackColor = false;
            this.btn15.Click += new System.EventHandler(this.btnChooseASeat);
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.Color.White;
            this.GroupBox.Controls.Add(this.btn15);
            this.GroupBox.Controls.Add(this.btn14);
            this.GroupBox.Controls.Add(this.btn13);
            this.GroupBox.Controls.Add(this.btn12);
            this.GroupBox.Controls.Add(this.btn11);
            this.GroupBox.Controls.Add(this.btn10);
            this.GroupBox.Controls.Add(this.btn9);
            this.GroupBox.Controls.Add(this.btn8);
            this.GroupBox.Controls.Add(this.btn7);
            this.GroupBox.Controls.Add(this.btn6);
            this.GroupBox.Controls.Add(this.btn5);
            this.GroupBox.Controls.Add(this.btn4);
            this.GroupBox.Controls.Add(this.btn3);
            this.GroupBox.Controls.Add(this.btn2);
            this.GroupBox.Controls.Add(this.btn1);
            this.GroupBox.Location = new System.Drawing.Point(12, 56);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(377, 247);
            this.GroupBox.TabIndex = 21;
            this.GroupBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Name = "Form1";
            this.Text = "Selling Movie Thearter Ticket";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.GroupBox GroupBox;
    }
}

