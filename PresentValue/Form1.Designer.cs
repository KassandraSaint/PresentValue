
namespace PresentValue
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
            this.futureBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.presentValueLabel = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Future Value $:";
            // 
            // futureBox
            // 
            this.futureBox.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureBox.Location = new System.Drawing.Point(367, 34);
            this.futureBox.Name = "futureBox";
            this.futureBox.Size = new System.Drawing.Size(300, 41);
            this.futureBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interest Rate %:";
            // 
            // rateBox
            // 
            this.rateBox.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateBox.Location = new System.Drawing.Point(367, 108);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(300, 41);
            this.rateBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Years:";
            // 
            // yearsBox
            // 
            this.yearsBox.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsBox.Location = new System.Drawing.Point(368, 182);
            this.yearsBox.Name = "yearsBox";
            this.yearsBox.Size = new System.Drawing.Size(300, 41);
            this.yearsBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Present Value:";
            // 
            // presentValueLabel
            // 
            this.presentValueLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.presentValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presentValueLabel.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentValueLabel.Location = new System.Drawing.Point(371, 256);
            this.presentValueLabel.Name = "presentValueLabel";
            this.presentValueLabel.Size = new System.Drawing.Size(296, 52);
            this.presentValueLabel.TabIndex = 7;
            this.presentValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.calcBtn.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn.Location = new System.Drawing.Point(140, 351);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(250, 80);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(416, 351);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(250, 80);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.presentValueLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yearsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.futureBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Present Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox futureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yearsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label presentValueLabel;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

