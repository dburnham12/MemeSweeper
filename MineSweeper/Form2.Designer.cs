namespace MineSweeper
{
    partial class Form2
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
            winLoseMessageLbl = new Label();
            winLosePbx = new PictureBox();
            retryBtn = new Button();
            viewHighScoresBtn = new Button();
            leaderboardPositionLbl = new Label();
            popupMainMenuBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)winLosePbx).BeginInit();
            SuspendLayout();
            // 
            // winLoseMessageLbl
            // 
            winLoseMessageLbl.AutoSize = true;
            winLoseMessageLbl.Font = new Font("OCR A Extended", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            winLoseMessageLbl.Location = new Point(169, 9);
            winLoseMessageLbl.Name = "winLoseMessageLbl";
            winLoseMessageLbl.Size = new Size(158, 32);
            winLoseMessageLbl.TabIndex = 0;
            winLoseMessageLbl.Text = "You win!";
            // 
            // winLosePbx
            // 
            winLosePbx.Image = Properties.Resources.YouLoseTwoMeme;
            winLosePbx.Location = new Point(54, 44);
            winLosePbx.Name = "winLosePbx";
            winLosePbx.Size = new Size(392, 324);
            winLosePbx.SizeMode = PictureBoxSizeMode.StretchImage;
            winLosePbx.TabIndex = 1;
            winLosePbx.TabStop = false;
            // 
            // retryBtn
            // 
            retryBtn.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            retryBtn.Location = new Point(33, 429);
            retryBtn.Name = "retryBtn";
            retryBtn.Size = new Size(144, 53);
            retryBtn.TabIndex = 2;
            retryBtn.Text = "Retry";
            retryBtn.UseVisualStyleBackColor = true;
            retryBtn.Click += retryBtn_Click;
            // 
            // viewHighScoresBtn
            // 
            viewHighScoresBtn.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewHighScoresBtn.Location = new Point(183, 429);
            viewHighScoresBtn.Name = "viewHighScoresBtn";
            viewHighScoresBtn.Size = new Size(144, 53);
            viewHighScoresBtn.TabIndex = 3;
            viewHighScoresBtn.Text = "High Scores";
            viewHighScoresBtn.UseVisualStyleBackColor = true;
            viewHighScoresBtn.Click += viewHighScoresBtn_Click;
            // 
            // leaderboardPositionLbl
            // 
            leaderboardPositionLbl.AutoSize = true;
            leaderboardPositionLbl.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leaderboardPositionLbl.Location = new Point(99, 395);
            leaderboardPositionLbl.Name = "leaderboardPositionLbl";
            leaderboardPositionLbl.Size = new Size(296, 17);
            leaderboardPositionLbl.TabIndex = 4;
            leaderboardPositionLbl.Text = "You did not make the leaderboard";
            // 
            // popupMainMenuBtn
            // 
            popupMainMenuBtn.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            popupMainMenuBtn.Location = new Point(333, 429);
            popupMainMenuBtn.Name = "popupMainMenuBtn";
            popupMainMenuBtn.Size = new Size(144, 53);
            popupMainMenuBtn.TabIndex = 5;
            popupMainMenuBtn.Text = "Main Menu";
            popupMainMenuBtn.UseVisualStyleBackColor = true;
            popupMainMenuBtn.Click += popupMainMenuBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 494);
            Controls.Add(popupMainMenuBtn);
            Controls.Add(leaderboardPositionLbl);
            Controls.Add(viewHighScoresBtn);
            Controls.Add(retryBtn);
            Controls.Add(winLosePbx);
            Controls.Add(winLoseMessageLbl);
            Name = "Form2";
            Text = "Game Over";
            ((System.ComponentModel.ISupportInitialize)winLosePbx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label winLoseMessageLbl;
        private PictureBox winLosePbx;
        private Button retryBtn;
        private Button viewHighScoresBtn;
        private Label leaderboardPositionLbl;
        private Button popupMainMenuBtn;
    }
}