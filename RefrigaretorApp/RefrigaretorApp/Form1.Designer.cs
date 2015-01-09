namespace RefrigaretorApp
{
    partial class RefrigeratorUI
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
            this.remainWeightlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentWeightlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.inputsaveTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight (kg/unit)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No of items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maximum Weight it can take";
            // 
            // remainWeightlabel
            // 
            this.remainWeightlabel.AutoSize = true;
            this.remainWeightlabel.Location = new System.Drawing.Point(407, 223);
            this.remainWeightlabel.Name = "remainWeightlabel";
            this.remainWeightlabel.Size = new System.Drawing.Size(35, 13);
            this.remainWeightlabel.TabIndex = 3;
            this.remainWeightlabel.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remaining Weight";
            // 
            // currentWeightlabel
            // 
            this.currentWeightlabel.AutoSize = true;
            this.currentWeightlabel.Location = new System.Drawing.Point(129, 223);
            this.currentWeightlabel.Name = "currentWeightlabel";
            this.currentWeightlabel.Size = new System.Drawing.Size(35, 13);
            this.currentWeightlabel.TabIndex = 5;
            this.currentWeightlabel.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Current Weight";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(410, 94);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 7;
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(132, 94);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemTextBox.TabIndex = 8;
            // 
            // inputsaveTextBox
            // 
            this.inputsaveTextBox.Location = new System.Drawing.Point(238, 15);
            this.inputsaveTextBox.Name = "inputsaveTextBox";
            this.inputsaveTextBox.Size = new System.Drawing.Size(114, 20);
            this.inputsaveTextBox.TabIndex = 9;
            this.inputsaveTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(258, 149);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 10;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(258, 58);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // RefrigeratorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 261);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.inputsaveTextBox);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.currentWeightlabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.remainWeightlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RefrigeratorUI";
            this.Text = "RedrigeratorUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label remainWeightlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentWeightlabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TextBox inputsaveTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button saveButton;
    }
}

