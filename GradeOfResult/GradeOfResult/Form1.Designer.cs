namespace GradeOfResult
{
    partial class ResultUI
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.avgTextBox = new System.Windows.Forms.TextBox();
            this.grdTextBox = new System.Windows.Forms.TextBox();
            this.mathTextBox = new System.Windows.Forms.TextBox();
            this.cheTextBox = new System.Windows.Forms.TextBox();
            this.phyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "out of 100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "out of 100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "out of 100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Physices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chemistry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Math";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Average";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gread";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(91, 148);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(100, 23);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // avgTextBox
            // 
            this.avgTextBox.Location = new System.Drawing.Point(91, 186);
            this.avgTextBox.Name = "avgTextBox";
            this.avgTextBox.Size = new System.Drawing.Size(100, 20);
            this.avgTextBox.TabIndex = 9;
            // 
            // grdTextBox
            // 
            this.grdTextBox.Location = new System.Drawing.Point(91, 223);
            this.grdTextBox.Name = "grdTextBox";
            this.grdTextBox.Size = new System.Drawing.Size(100, 20);
            this.grdTextBox.TabIndex = 10;
            // 
            // mathTextBox
            // 
            this.mathTextBox.Location = new System.Drawing.Point(91, 112);
            this.mathTextBox.Name = "mathTextBox";
            this.mathTextBox.Size = new System.Drawing.Size(100, 20);
            this.mathTextBox.TabIndex = 11;
            // 
            // cheTextBox
            // 
            this.cheTextBox.Location = new System.Drawing.Point(91, 68);
            this.cheTextBox.Name = "cheTextBox";
            this.cheTextBox.Size = new System.Drawing.Size(100, 20);
            this.cheTextBox.TabIndex = 12;
            // 
            // phyTextBox
            // 
            this.phyTextBox.Location = new System.Drawing.Point(91, 26);
            this.phyTextBox.Name = "phyTextBox";
            this.phyTextBox.Size = new System.Drawing.Size(100, 20);
            this.phyTextBox.TabIndex = 13;
            // 
            // ResultUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.phyTextBox);
            this.Controls.Add(this.cheTextBox);
            this.Controls.Add(this.mathTextBox);
            this.Controls.Add(this.grdTextBox);
            this.Controls.Add(this.avgTextBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResultUI";
            this.Text = "ResultUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox avgTextBox;
        private System.Windows.Forms.TextBox grdTextBox;
        private System.Windows.Forms.TextBox mathTextBox;
        private System.Windows.Forms.TextBox cheTextBox;
        private System.Windows.Forms.TextBox phyTextBox;
    }
}

