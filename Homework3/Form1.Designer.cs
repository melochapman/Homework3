namespace Homework3
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
            this.numCardsTextBox = new System.Windows.Forms.TextBox();
            this.dealButton = new System.Windows.Forms.Button();
            this.DealtCardsListBox = new System.Windows.Forms.ListBox();
            this.valueOfHand = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cardsLeftLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numCardsTextBox
            // 
            this.numCardsTextBox.Location = new System.Drawing.Point(792, 66);
            this.numCardsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCardsTextBox.Name = "numCardsTextBox";
            this.numCardsTextBox.Size = new System.Drawing.Size(148, 26);
            this.numCardsTextBox.TabIndex = 0;
            this.numCardsTextBox.TextChanged += new System.EventHandler(this.numCardsTextBox_TextChanged);
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(609, 182);
            this.dealButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(112, 37);
            this.dealButton.TabIndex = 1;
            this.dealButton.Text = "Deal Cards";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // DealtCardsListBox
            // 
            this.DealtCardsListBox.FormattingEnabled = true;
            this.DealtCardsListBox.ItemHeight = 20;
            this.DealtCardsListBox.Location = new System.Drawing.Point(585, 262);
            this.DealtCardsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DealtCardsListBox.Name = "DealtCardsListBox";
            this.DealtCardsListBox.Size = new System.Drawing.Size(178, 144);
            this.DealtCardsListBox.TabIndex = 2;
            // 
            // valueOfHand
            // 
            this.valueOfHand.AutoSize = true;
            this.valueOfHand.Location = new System.Drawing.Point(580, 448);
            this.valueOfHand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueOfHand.Name = "valueOfHand";
            this.valueOfHand.Size = new System.Drawing.Size(115, 20);
            this.valueOfHand.TabIndex = 3;
            this.valueOfHand.Text = "Value of Hand:";
            // 
            // valueLabel
            // 
            this.valueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueLabel.Location = new System.Drawing.Point(748, 446);
            this.valueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(149, 34);
            this.valueLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Cards to Deal:";
            // 
            // cardsLeftLabel
            // 
            this.cardsLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardsLeftLabel.Location = new System.Drawing.Point(748, 515);
            this.cardsLeftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardsLeftLabel.Name = "cardsLeftLabel";
            this.cardsLeftLabel.Size = new System.Drawing.Size(149, 33);
            this.cardsLeftLabel.TabIndex = 6;
            this.cardsLeftLabel.Click += new System.EventHandler(this.cardsLeftLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 517);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cards Left in Deck:";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(849, 572);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(112, 35);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 725);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cardsLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.valueOfHand);
            this.Controls.Add(this.DealtCardsListBox);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.numCardsTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Card Dealer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numCardsTextBox;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.ListBox DealtCardsListBox;
        private System.Windows.Forms.Label valueOfHand;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cardsLeftLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetButton;
    }
}

