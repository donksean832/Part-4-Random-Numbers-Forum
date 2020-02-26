namespace Part_4_Random_Numbers_Forum
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
            this.Lblgreeting = new System.Windows.Forms.Label();
            this.TxtMinimum = new System.Windows.Forms.TextBox();
            this.TxtMaximum = new System.Windows.Forms.TextBox();
            this.LblMinimum = new System.Windows.Forms.Label();
            this.LblMaximum = new System.Windows.Forms.Label();
            this.BtnInteger = new System.Windows.Forms.Button();
            this.BtnDouble = new System.Windows.Forms.Button();
            this.LblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lblgreeting
            // 
            this.Lblgreeting.AutoSize = true;
            this.Lblgreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lblgreeting.Location = new System.Drawing.Point(33, 39);
            this.Lblgreeting.Name = "Lblgreeting";
            this.Lblgreeting.Size = new System.Drawing.Size(512, 36);
            this.Lblgreeting.TabIndex = 0;
            this.Lblgreeting.Text = "Enter a minimum and maximum value.";
            // 
            // TxtMinimum
            // 
            this.TxtMinimum.Location = new System.Drawing.Point(212, 125);
            this.TxtMinimum.Name = "TxtMinimum";
            this.TxtMinimum.Size = new System.Drawing.Size(296, 22);
            this.TxtMinimum.TabIndex = 1;
            // 
            // TxtMaximum
            // 
            this.TxtMaximum.Location = new System.Drawing.Point(212, 221);
            this.TxtMaximum.Name = "TxtMaximum";
            this.TxtMaximum.Size = new System.Drawing.Size(296, 22);
            this.TxtMaximum.TabIndex = 2;
            // 
            // LblMinimum
            // 
            this.LblMinimum.AutoSize = true;
            this.LblMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LblMinimum.Location = new System.Drawing.Point(33, 125);
            this.LblMinimum.Name = "LblMinimum";
            this.LblMinimum.Size = new System.Drawing.Size(134, 36);
            this.LblMinimum.TabIndex = 3;
            this.LblMinimum.Text = "Minimum";
            // 
            // LblMaximum
            // 
            this.LblMaximum.AutoSize = true;
            this.LblMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LblMaximum.Location = new System.Drawing.Point(33, 221);
            this.LblMaximum.Name = "LblMaximum";
            this.LblMaximum.Size = new System.Drawing.Size(141, 36);
            this.LblMaximum.TabIndex = 4;
            this.LblMaximum.Text = "Maximum";
            // 
            // BtnInteger
            // 
            this.BtnInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BtnInteger.Location = new System.Drawing.Point(70, 298);
            this.BtnInteger.Name = "BtnInteger";
            this.BtnInteger.Size = new System.Drawing.Size(135, 48);
            this.BtnInteger.TabIndex = 5;
            this.BtnInteger.Text = "Integer";
            this.BtnInteger.UseVisualStyleBackColor = true;
            this.BtnInteger.Click += new System.EventHandler(this.BtnInteger_Click);
            // 
            // BtnDouble
            // 
            this.BtnDouble.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BtnDouble.Location = new System.Drawing.Point(332, 298);
            this.BtnDouble.Name = "BtnDouble";
            this.BtnDouble.Size = new System.Drawing.Size(123, 48);
            this.BtnDouble.TabIndex = 6;
            this.BtnDouble.Text = "Double";
            this.BtnDouble.UseVisualStyleBackColor = true;
            // 
            // LblAnswer
            // 
            this.LblAnswer.AutoSize = true;
            this.LblAnswer.Location = new System.Drawing.Point(59, 383);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(53, 17);
            this.LblAnswer.TabIndex = 7;
            this.LblAnswer.Text = "answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 449);
            this.Controls.Add(this.LblAnswer);
            this.Controls.Add(this.BtnDouble);
            this.Controls.Add(this.BtnInteger);
            this.Controls.Add(this.LblMaximum);
            this.Controls.Add(this.LblMinimum);
            this.Controls.Add(this.TxtMaximum);
            this.Controls.Add(this.TxtMinimum);
            this.Controls.Add(this.Lblgreeting);
            this.Name = "Form1";
            this.Text = "Part 4 Random Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblgreeting;
        private System.Windows.Forms.TextBox TxtMinimum;
        private System.Windows.Forms.TextBox TxtMaximum;
        private System.Windows.Forms.Label LblMinimum;
        private System.Windows.Forms.Label LblMaximum;
        private System.Windows.Forms.Button BtnInteger;
        private System.Windows.Forms.Button BtnDouble;
        private System.Windows.Forms.Label LblAnswer;
    }
}

