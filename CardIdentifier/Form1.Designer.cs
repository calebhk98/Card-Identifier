namespace CardIdentifier
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
            this.Clubs2 = new System.Windows.Forms.PictureBox();
            this.Diamonds8 = new System.Windows.Forms.PictureBox();
            this.Joker = new System.Windows.Forms.PictureBox();
            this.SpadesA = new System.Windows.Forms.PictureBox();
            this.SpadesKing = new System.Windows.Forms.PictureBox();
            this.CardName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Clubs2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diamonds8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Joker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpadesA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpadesKing)).BeginInit();
            this.SuspendLayout();
            // 
            // Clubs2
            // 
            this.Clubs2.Image = global::CardIdentifier.Properties.Resources._2_Clubs;
            this.Clubs2.Location = new System.Drawing.Point(33, 146);
            this.Clubs2.Name = "Clubs2";
            this.Clubs2.Size = new System.Drawing.Size(220, 305);
            this.Clubs2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Clubs2.TabIndex = 0;
            this.Clubs2.TabStop = false;
            this.Clubs2.Click += new System.EventHandler(this.Clubs2_Click);
            // 
            // Diamonds8
            // 
            this.Diamonds8.Image = global::CardIdentifier.Properties.Resources._8_Diamonds;
            this.Diamonds8.Location = new System.Drawing.Point(277, 146);
            this.Diamonds8.Name = "Diamonds8";
            this.Diamonds8.Size = new System.Drawing.Size(218, 305);
            this.Diamonds8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Diamonds8.TabIndex = 1;
            this.Diamonds8.TabStop = false;
            this.Diamonds8.Click += new System.EventHandler(this.Diamonds8_Click);
            // 
            // Joker
            // 
            this.Joker.Image = global::CardIdentifier.Properties.Resources.Joker_Black;
            this.Joker.Location = new System.Drawing.Point(749, 146);
            this.Joker.Name = "Joker";
            this.Joker.Size = new System.Drawing.Size(218, 305);
            this.Joker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Joker.TabIndex = 2;
            this.Joker.TabStop = false;
            this.Joker.Click += new System.EventHandler(this.Joker_Click);
            // 
            // SpadesA
            // 
            this.SpadesA.Image = global::CardIdentifier.Properties.Resources.Ace_Spades;
            this.SpadesA.Location = new System.Drawing.Point(511, 146);
            this.SpadesA.Name = "SpadesA";
            this.SpadesA.Size = new System.Drawing.Size(218, 305);
            this.SpadesA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpadesA.TabIndex = 3;
            this.SpadesA.TabStop = false;
            this.SpadesA.Click += new System.EventHandler(this.SpadesA_Click);
            // 
            // SpadesKing
            // 
            this.SpadesKing.Image = global::CardIdentifier.Properties.Resources.King_Spades;
            this.SpadesKing.Location = new System.Drawing.Point(986, 146);
            this.SpadesKing.Name = "SpadesKing";
            this.SpadesKing.Size = new System.Drawing.Size(218, 305);
            this.SpadesKing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpadesKing.TabIndex = 4;
            this.SpadesKing.TabStop = false;
            this.SpadesKing.Click += new System.EventHandler(this.SpadesKing_Click);
            // 
            // CardName
            // 
            this.CardName.AutoSize = true;
            this.CardName.Location = new System.Drawing.Point(508, 28);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(213, 13);
            this.CardName.TabIndex = 5;
            this.CardName.Text = "Click a card to find what the Card\'s name is.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 497);
            this.Controls.Add(this.CardName);
            this.Controls.Add(this.SpadesKing);
            this.Controls.Add(this.SpadesA);
            this.Controls.Add(this.Joker);
            this.Controls.Add(this.Diamonds8);
            this.Controls.Add(this.Clubs2);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.Clubs2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diamonds8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Joker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpadesA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpadesKing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Clubs2;
        private System.Windows.Forms.PictureBox Diamonds8;
        private System.Windows.Forms.PictureBox Joker;
        private System.Windows.Forms.PictureBox SpadesA;
        private System.Windows.Forms.PictureBox SpadesKing;
        private System.Windows.Forms.Label CardName;
    }
}

