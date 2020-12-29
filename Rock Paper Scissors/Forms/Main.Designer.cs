namespace Rock_Paper_Scissors
{
    partial class Main
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.userScoreLabel = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.Brown;
            this.btnRock.FlatAppearance.BorderSize = 0;
            this.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRock.Location = new System.Drawing.Point(124, 289);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(76, 76);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.buttonPress);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPaper.FlatAppearance.BorderSize = 0;
            this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaper.ForeColor = System.Drawing.Color.Black;
            this.btnPaper.Location = new System.Drawing.Point(271, 289);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(76, 76);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.buttonPress);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnScissors.FlatAppearance.BorderSize = 0;
            this.btnScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScissors.Location = new System.Drawing.Point(416, 289);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(76, 76);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.buttonPress);
            // 
            // userScoreLabel
            // 
            this.userScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userScoreLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userScoreLabel.Location = new System.Drawing.Point(44, 27);
            this.userScoreLabel.Name = "userScoreLabel";
            this.userScoreLabel.Size = new System.Drawing.Size(209, 29);
            this.userScoreLabel.TabIndex = 3;
            this.userScoreLabel.Text = "User: 0";
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computerScoreLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerScoreLabel.Location = new System.Drawing.Point(354, 27);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(209, 29);
            this.computerScoreLabel.TabIndex = 4;
            this.computerScoreLabel.Text = "Computer: 0";
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackColor = System.Drawing.Color.DimGray;
            this.userPictureBox.Location = new System.Drawing.Point(48, 79);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(205, 153);
            this.userPictureBox.TabIndex = 5;
            this.userPictureBox.TabStop = false;
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.BackColor = System.Drawing.Color.DimGray;
            this.computerPictureBox.Location = new System.Drawing.Point(358, 79);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(205, 153);
            this.computerPictureBox.TabIndex = 6;
            this.computerPictureBox.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(120, 248);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(372, 29);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "STATUS";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 153);
            this.label4.TabIndex = 8;
            this.label4.Text = "VS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Tan;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnRestart.Location = new System.Drawing.Point(189, 391);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(246, 39);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Reset";
            this.btnRestart.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(619, 442);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.computerPictureBox);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.computerScoreLabel);
            this.Controls.Add(this.userScoreLabel);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label userScoreLabel;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRestart;
    }
}

