namespace bankinterst
{
    partial class BankBalanceUI
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
            this.interst_comboBox = new System.Windows.Forms.ComboBox();
            this.bankLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // interst_comboBox
            // 
            this.interst_comboBox.FormattingEnabled = true;
            this.interst_comboBox.Items.AddRange(new object[] {
            "BRAC",
            "EBL",
            "DBL"});
            this.interst_comboBox.Location = new System.Drawing.Point(118, 32);
            this.interst_comboBox.Name = "interst_comboBox";
            this.interst_comboBox.Size = new System.Drawing.Size(121, 21);
            this.interst_comboBox.TabIndex = 0;
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Location = new System.Drawing.Point(39, 32);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(32, 13);
            this.bankLabel.TabIndex = 1;
            this.bankLabel.Text = "Bank";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(39, 81);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "Year";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(39, 120);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(46, 13);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.Text = "Balance";
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(118, 78);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(100, 20);
            this.yearBox.TabIndex = 4;
            // 
            // balanceBox
            // 
            this.balanceBox.Location = new System.Drawing.Point(118, 117);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(100, 20);
            this.balanceBox.TabIndex = 5;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(70, 190);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(169, 23);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Total Balance";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // BankBalanceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.interst_comboBox);
            this.Name = "BankBalanceUI";
            this.Text = "Balance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox interst_comboBox;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.Button showButton;
    }
}

