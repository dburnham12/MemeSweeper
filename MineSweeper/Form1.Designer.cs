namespace MineSweeper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newHighScorePbx = new PictureBox();
            timerLbl = new Label();
            numFlagsLbl = new Label();
            difficultyMenuGbx = new GroupBox();
            hardModeBtn = new Button();
            mediumModeBtn = new Button();
            easyModeBtn = new Button();
            mainMenuPnl = new Panel();
            leaderboardMainMenuBtn = new Button();
            profileBtn = new Button();
            mainMenuMemePbx = new PictureBox();
            instructionsBtn = new Button();
            titleLbl = new Label();
            instructionsPnl = new Panel();
            instructionsMemePbx = new PictureBox();
            instructionsBackBtn = new Button();
            clickInstructionLbl = new Label();
            instructionsLbl = new Label();
            panel1 = new Panel();
            clearInstructionLbl = new Label();
            clearInstructionTitleLbl = new Label();
            mineInstructionLbl = new Label();
            numbersInstructionTitleLbl = new Label();
            startInstructionTitleLbl = new Label();
            mineInstructionsLbl = new Label();
            numberInstructionLbl = new Label();
            playerInfoPnl = new Panel();
            infoTitleLbl = new Label();
            infoSaveBtn = new Button();
            infoAgeLbl = new Label();
            infoAgeNud = new NumericUpDown();
            infoUsernameMsk = new MaskedTextBox();
            infoUsernameLbl = new Label();
            infoNameMsk = new MaskedTextBox();
            infoNameLbl = new Label();
            whoAreYouMemePbx = new PictureBox();
            highScoresPnl = new Panel();
            highScoreDifficultyLbl = new Label();
            leaderboardMainBtn = new Button();
            scoreboardTimesLbl = new Label();
            scoreBoardNamesLbl = new Label();
            highScoresLbl = new Label();
            leaderboardSelectPnl = new Panel();
            leaderboardSelectPbx = new PictureBox();
            leaderboardSelectLbl = new Label();
            leaderboardSelectMainMenuBtn = new Button();
            leaderboardSelectDifficulty = new GroupBox();
            leaderboardSelectHard = new Button();
            leaderboardSelectMedium = new Button();
            leaderboardSelectEasy = new Button();
            ((System.ComponentModel.ISupportInitialize)newHighScorePbx).BeginInit();
            difficultyMenuGbx.SuspendLayout();
            mainMenuPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainMenuMemePbx).BeginInit();
            instructionsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)instructionsMemePbx).BeginInit();
            panel1.SuspendLayout();
            playerInfoPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)infoAgeNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)whoAreYouMemePbx).BeginInit();
            highScoresPnl.SuspendLayout();
            leaderboardSelectPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)leaderboardSelectPbx).BeginInit();
            leaderboardSelectDifficulty.SuspendLayout();
            SuspendLayout();
            // 
            // newHighScorePbx
            // 
            newHighScorePbx.Image = Properties.Resources.NotNewHighScoreMeme;
            newHighScorePbx.Location = new Point(264, 11);
            newHighScorePbx.Name = "newHighScorePbx";
            newHighScorePbx.Size = new Size(293, 269);
            newHighScorePbx.SizeMode = PictureBoxSizeMode.StretchImage;
            newHighScorePbx.TabIndex = 4;
            newHighScorePbx.TabStop = false;
            // 
            // timerLbl
            // 
            timerLbl.AutoSize = true;
            timerLbl.Font = new Font("OCR A Extended", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerLbl.Location = new Point(1238, 420);
            timerLbl.Name = "timerLbl";
            timerLbl.Size = new Size(36, 35);
            timerLbl.TabIndex = 0;
            timerLbl.Text = "0";
            // 
            // numFlagsLbl
            // 
            numFlagsLbl.AutoSize = true;
            numFlagsLbl.Font = new Font("OCR A Extended", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numFlagsLbl.Location = new Point(1280, 420);
            numFlagsLbl.Name = "numFlagsLbl";
            numFlagsLbl.Size = new Size(57, 35);
            numFlagsLbl.TabIndex = 1;
            numFlagsLbl.Text = "40";
            // 
            // difficultyMenuGbx
            // 
            difficultyMenuGbx.Controls.Add(hardModeBtn);
            difficultyMenuGbx.Controls.Add(mediumModeBtn);
            difficultyMenuGbx.Controls.Add(easyModeBtn);
            difficultyMenuGbx.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            difficultyMenuGbx.Location = new Point(19, 52);
            difficultyMenuGbx.Name = "difficultyMenuGbx";
            difficultyMenuGbx.Size = new Size(224, 113);
            difficultyMenuGbx.TabIndex = 2;
            difficultyMenuGbx.TabStop = false;
            difficultyMenuGbx.Text = "Difficulty";
            // 
            // hardModeBtn
            // 
            hardModeBtn.Location = new Point(7, 82);
            hardModeBtn.Name = "hardModeBtn";
            hardModeBtn.Size = new Size(210, 25);
            hardModeBtn.TabIndex = 3;
            hardModeBtn.Text = "Hard";
            hardModeBtn.UseVisualStyleBackColor = true;
            hardModeBtn.Click += hardModeBtn_Click;
            // 
            // mediumModeBtn
            // 
            mediumModeBtn.Location = new Point(7, 52);
            mediumModeBtn.Name = "mediumModeBtn";
            mediumModeBtn.Size = new Size(210, 25);
            mediumModeBtn.TabIndex = 2;
            mediumModeBtn.Text = "Medium";
            mediumModeBtn.UseVisualStyleBackColor = true;
            mediumModeBtn.Click += mediumModeBtn_Click;
            // 
            // easyModeBtn
            // 
            easyModeBtn.Location = new Point(7, 22);
            easyModeBtn.Name = "easyModeBtn";
            easyModeBtn.Size = new Size(210, 25);
            easyModeBtn.TabIndex = 1;
            easyModeBtn.Text = "Easy";
            easyModeBtn.UseVisualStyleBackColor = true;
            easyModeBtn.Click += easyModeBtn_Click;
            // 
            // mainMenuPnl
            // 
            mainMenuPnl.Controls.Add(leaderboardMainMenuBtn);
            mainMenuPnl.Controls.Add(profileBtn);
            mainMenuPnl.Controls.Add(mainMenuMemePbx);
            mainMenuPnl.Controls.Add(instructionsBtn);
            mainMenuPnl.Controls.Add(titleLbl);
            mainMenuPnl.Controls.Add(difficultyMenuGbx);
            mainMenuPnl.Location = new Point(14, 12);
            mainMenuPnl.Name = "mainMenuPnl";
            mainMenuPnl.Size = new Size(538, 283);
            mainMenuPnl.TabIndex = 3;
            // 
            // leaderboardMainMenuBtn
            // 
            leaderboardMainMenuBtn.Location = new Point(18, 171);
            leaderboardMainMenuBtn.Name = "leaderboardMainMenuBtn";
            leaderboardMainMenuBtn.Size = new Size(225, 29);
            leaderboardMainMenuBtn.TabIndex = 4;
            leaderboardMainMenuBtn.Text = "Leaderboards";
            leaderboardMainMenuBtn.UseVisualStyleBackColor = true;
            leaderboardMainMenuBtn.Click += leaderboardMainMenuBtn_Click;
            // 
            // profileBtn
            // 
            profileBtn.Location = new Point(18, 241);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(225, 29);
            profileBtn.TabIndex = 6;
            profileBtn.Text = "Profile";
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += profileBtn_Click;
            // 
            // mainMenuMemePbx
            // 
            mainMenuMemePbx.BorderStyle = BorderStyle.FixedSingle;
            mainMenuMemePbx.Image = Properties.Resources.Meme1;
            mainMenuMemePbx.Location = new Point(262, 11);
            mainMenuMemePbx.Name = "mainMenuMemePbx";
            mainMenuMemePbx.Size = new Size(259, 258);
            mainMenuMemePbx.SizeMode = PictureBoxSizeMode.StretchImage;
            mainMenuMemePbx.TabIndex = 5;
            mainMenuMemePbx.TabStop = false;
            // 
            // instructionsBtn
            // 
            instructionsBtn.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructionsBtn.Location = new Point(18, 206);
            instructionsBtn.Name = "instructionsBtn";
            instructionsBtn.Size = new Size(225, 29);
            instructionsBtn.TabIndex = 5;
            instructionsBtn.Text = "Instructions";
            instructionsBtn.UseVisualStyleBackColor = true;
            instructionsBtn.Click += instructionsBtn_Click;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("OCR A Extended", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(30, 11);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(200, 30);
            titleLbl.TabIndex = 3;
            titleLbl.Text = "Memesweeper";
            // 
            // instructionsPnl
            // 
            instructionsPnl.Controls.Add(instructionsMemePbx);
            instructionsPnl.Controls.Add(instructionsBackBtn);
            instructionsPnl.Controls.Add(clickInstructionLbl);
            instructionsPnl.Controls.Add(instructionsLbl);
            instructionsPnl.Controls.Add(panel1);
            instructionsPnl.Location = new Point(661, 12);
            instructionsPnl.Name = "instructionsPnl";
            instructionsPnl.Size = new Size(544, 440);
            instructionsPnl.TabIndex = 4;
            // 
            // instructionsMemePbx
            // 
            instructionsMemePbx.Image = Properties.Resources.InstructionsMeme;
            instructionsMemePbx.Location = new Point(264, 11);
            instructionsMemePbx.Name = "instructionsMemePbx";
            instructionsMemePbx.Size = new Size(262, 416);
            instructionsMemePbx.SizeMode = PictureBoxSizeMode.StretchImage;
            instructionsMemePbx.TabIndex = 11;
            instructionsMemePbx.TabStop = false;
            // 
            // instructionsBackBtn
            // 
            instructionsBackBtn.Location = new Point(17, 398);
            instructionsBackBtn.Name = "instructionsBackBtn";
            instructionsBackBtn.Size = new Size(225, 29);
            instructionsBackBtn.TabIndex = 1;
            instructionsBackBtn.Text = "Main Menu";
            instructionsBackBtn.UseVisualStyleBackColor = true;
            instructionsBackBtn.Click += instructionsBackBtn_Click;
            // 
            // clickInstructionLbl
            // 
            clickInstructionLbl.AutoSize = true;
            clickInstructionLbl.BackColor = SystemColors.Control;
            clickInstructionLbl.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickInstructionLbl.Location = new Point(17, 82);
            clickInstructionLbl.Name = "clickInstructionLbl";
            clickInstructionLbl.Size = new Size(179, 34);
            clickInstructionLbl.TabIndex = 1;
            clickInstructionLbl.Text = "Click on a tile to \r\nstart the game";
            // 
            // instructionsLbl
            // 
            instructionsLbl.AutoSize = true;
            instructionsLbl.Font = new Font("OCR A Extended", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructionsLbl.Location = new Point(17, 11);
            instructionsLbl.Name = "instructionsLbl";
            instructionsLbl.Size = new Size(217, 30);
            instructionsLbl.TabIndex = 0;
            instructionsLbl.Text = "Instructions";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(clearInstructionLbl);
            panel1.Controls.Add(clearInstructionTitleLbl);
            panel1.Controls.Add(mineInstructionLbl);
            panel1.Controls.Add(numbersInstructionTitleLbl);
            panel1.Controls.Add(startInstructionTitleLbl);
            panel1.Controls.Add(mineInstructionsLbl);
            panel1.Controls.Add(numberInstructionLbl);
            panel1.Location = new Point(8, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 338);
            panel1.TabIndex = 10;
            // 
            // clearInstructionLbl
            // 
            clearInstructionLbl.AutoSize = true;
            clearInstructionLbl.Location = new Point(9, 275);
            clearInstructionLbl.Name = "clearInstructionLbl";
            clearInstructionLbl.Size = new Size(215, 51);
            clearInstructionLbl.TabIndex = 9;
            clearInstructionLbl.Text = "If you clear all tiles \r\nthat are not mines \r\nyou win!";
            // 
            // clearInstructionTitleLbl
            // 
            clearInstructionTitleLbl.AutoSize = true;
            clearInstructionTitleLbl.Font = new Font("OCR A Extended", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            clearInstructionTitleLbl.Location = new Point(9, 258);
            clearInstructionTitleLbl.Name = "clearInstructionTitleLbl";
            clearInstructionTitleLbl.Size = new Size(168, 17);
            clearInstructionTitleLbl.TabIndex = 8;
            clearInstructionTitleLbl.Text = "Clear The Board!";
            // 
            // mineInstructionLbl
            // 
            mineInstructionLbl.AutoSize = true;
            mineInstructionLbl.Font = new Font("OCR A Extended", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            mineInstructionLbl.Location = new Point(9, 189);
            mineInstructionLbl.Name = "mineInstructionLbl";
            mineInstructionLbl.Size = new Size(168, 17);
            mineInstructionLbl.TabIndex = 7;
            mineInstructionLbl.Text = "Avoid The Mines!";
            // 
            // numbersInstructionTitleLbl
            // 
            numbersInstructionTitleLbl.AutoSize = true;
            numbersInstructionTitleLbl.Font = new Font("OCR A Extended", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            numbersInstructionTitleLbl.Location = new Point(9, 78);
            numbersInstructionTitleLbl.Name = "numbersInstructionTitleLbl";
            numbersInstructionTitleLbl.Size = new Size(148, 17);
            numbersInstructionTitleLbl.TabIndex = 6;
            numbersInstructionTitleLbl.Text = "Reveal Numbers";
            // 
            // startInstructionTitleLbl
            // 
            startInstructionTitleLbl.AutoSize = true;
            startInstructionTitleLbl.Font = new Font("OCR A Extended", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            startInstructionTitleLbl.Location = new Point(9, 13);
            startInstructionTitleLbl.Name = "startInstructionTitleLbl";
            startInstructionTitleLbl.Size = new Size(108, 17);
            startInstructionTitleLbl.TabIndex = 5;
            startInstructionTitleLbl.Text = "Start Game";
            // 
            // mineInstructionsLbl
            // 
            mineInstructionsLbl.AutoSize = true;
            mineInstructionsLbl.Location = new Point(9, 206);
            mineInstructionsLbl.Name = "mineInstructionsLbl";
            mineInstructionsLbl.Size = new Size(215, 34);
            mineInstructionsLbl.TabIndex = 3;
            mineInstructionsLbl.Text = "If you click on a mine \r\nyou will lose!";
            // 
            // numberInstructionLbl
            // 
            numberInstructionLbl.AutoSize = true;
            numberInstructionLbl.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberInstructionLbl.Location = new Point(9, 95);
            numberInstructionLbl.Name = "numberInstructionLbl";
            numberInstructionLbl.Size = new Size(215, 85);
            numberInstructionLbl.TabIndex = 2;
            numberInstructionLbl.Text = "By clicking you will \r\nreveal numbers that \r\nallow you to determine \r\nhow many mines the \r\nsquare is connected to";
            // 
            // playerInfoPnl
            // 
            playerInfoPnl.Controls.Add(infoTitleLbl);
            playerInfoPnl.Controls.Add(infoSaveBtn);
            playerInfoPnl.Controls.Add(infoAgeLbl);
            playerInfoPnl.Controls.Add(infoAgeNud);
            playerInfoPnl.Controls.Add(infoUsernameMsk);
            playerInfoPnl.Controls.Add(infoUsernameLbl);
            playerInfoPnl.Controls.Add(infoNameMsk);
            playerInfoPnl.Controls.Add(infoNameLbl);
            playerInfoPnl.Controls.Add(whoAreYouMemePbx);
            playerInfoPnl.Location = new Point(12, 301);
            playerInfoPnl.Name = "playerInfoPnl";
            playerInfoPnl.Size = new Size(643, 282);
            playerInfoPnl.TabIndex = 5;
            // 
            // infoTitleLbl
            // 
            infoTitleLbl.AutoSize = true;
            infoTitleLbl.Font = new Font("OCR A Extended", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infoTitleLbl.Location = new Point(22, 11);
            infoTitleLbl.Name = "infoTitleLbl";
            infoTitleLbl.Size = new Size(217, 30);
            infoTitleLbl.TabIndex = 8;
            infoTitleLbl.Text = "Profile Info";
            // 
            // infoSaveBtn
            // 
            infoSaveBtn.Location = new Point(18, 234);
            infoSaveBtn.Name = "infoSaveBtn";
            infoSaveBtn.Size = new Size(229, 29);
            infoSaveBtn.TabIndex = 1;
            infoSaveBtn.Text = "Save Info";
            infoSaveBtn.UseVisualStyleBackColor = true;
            infoSaveBtn.Click += infoSaveBtn_Click;
            // 
            // infoAgeLbl
            // 
            infoAgeLbl.AutoSize = true;
            infoAgeLbl.Font = new Font("OCR A Extended", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            infoAgeLbl.Location = new Point(18, 158);
            infoAgeLbl.Name = "infoAgeLbl";
            infoAgeLbl.Size = new Size(38, 17);
            infoAgeLbl.TabIndex = 6;
            infoAgeLbl.Text = "Age";
            // 
            // infoAgeNud
            // 
            infoAgeNud.Location = new Point(18, 178);
            infoAgeNud.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            infoAgeNud.Name = "infoAgeNud";
            infoAgeNud.Size = new Size(229, 23);
            infoAgeNud.TabIndex = 5;
            // 
            // infoUsernameMsk
            // 
            infoUsernameMsk.Location = new Point(18, 132);
            infoUsernameMsk.Mask = "aaaaaaaaaaaaaaa";
            infoUsernameMsk.Name = "infoUsernameMsk";
            infoUsernameMsk.Size = new Size(229, 23);
            infoUsernameMsk.TabIndex = 4;
            // 
            // infoUsernameLbl
            // 
            infoUsernameLbl.AutoSize = true;
            infoUsernameLbl.Font = new Font("OCR A Extended", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            infoUsernameLbl.Location = new Point(18, 112);
            infoUsernameLbl.Name = "infoUsernameLbl";
            infoUsernameLbl.Size = new Size(88, 17);
            infoUsernameLbl.TabIndex = 3;
            infoUsernameLbl.Text = "Username";
            // 
            // infoNameMsk
            // 
            infoNameMsk.Location = new Point(18, 85);
            infoNameMsk.Mask = "????????????????????";
            infoNameMsk.Name = "infoNameMsk";
            infoNameMsk.Size = new Size(229, 23);
            infoNameMsk.TabIndex = 2;
            // 
            // infoNameLbl
            // 
            infoNameLbl.AutoSize = true;
            infoNameLbl.Font = new Font("OCR A Extended", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            infoNameLbl.Location = new Point(18, 65);
            infoNameLbl.Name = "infoNameLbl";
            infoNameLbl.Size = new Size(48, 17);
            infoNameLbl.TabIndex = 1;
            infoNameLbl.Text = "Name";
            // 
            // whoAreYouMemePbx
            // 
            whoAreYouMemePbx.Image = Properties.Resources.WhoAreYouMeme;
            whoAreYouMemePbx.Location = new Point(264, 15);
            whoAreYouMemePbx.Name = "whoAreYouMemePbx";
            whoAreYouMemePbx.Size = new Size(358, 248);
            whoAreYouMemePbx.SizeMode = PictureBoxSizeMode.StretchImage;
            whoAreYouMemePbx.TabIndex = 0;
            whoAreYouMemePbx.TabStop = false;
            // 
            // highScoresPnl
            // 
            highScoresPnl.Controls.Add(highScoreDifficultyLbl);
            highScoresPnl.Controls.Add(leaderboardMainBtn);
            highScoresPnl.Controls.Add(newHighScorePbx);
            highScoresPnl.Controls.Add(scoreboardTimesLbl);
            highScoresPnl.Controls.Add(scoreBoardNamesLbl);
            highScoresPnl.Controls.Add(highScoresLbl);
            highScoresPnl.Location = new Point(12, 589);
            highScoresPnl.Name = "highScoresPnl";
            highScoresPnl.Size = new Size(570, 298);
            highScoresPnl.TabIndex = 6;
            // 
            // highScoreDifficultyLbl
            // 
            highScoreDifficultyLbl.AutoSize = true;
            highScoreDifficultyLbl.Location = new Point(95, 41);
            highScoreDifficultyLbl.Name = "highScoreDifficultyLbl";
            highScoreDifficultyLbl.Size = new Size(62, 17);
            highScoreDifficultyLbl.TabIndex = 8;
            highScoreDifficultyLbl.Text = "medium";
            // 
            // leaderboardMainBtn
            // 
            leaderboardMainBtn.Location = new Point(16, 254);
            leaderboardMainBtn.Name = "leaderboardMainBtn";
            leaderboardMainBtn.Size = new Size(229, 29);
            leaderboardMainBtn.TabIndex = 1;
            leaderboardMainBtn.Text = "Back";
            leaderboardMainBtn.UseVisualStyleBackColor = true;
            leaderboardMainBtn.Click += leaderboardMainBtn_Click;
            // 
            // scoreboardTimesLbl
            // 
            scoreboardTimesLbl.AutoSize = true;
            scoreboardTimesLbl.Location = new Point(197, 64);
            scoreboardTimesLbl.Name = "scoreboardTimesLbl";
            scoreboardTimesLbl.Size = new Size(35, 17);
            scoreboardTimesLbl.TabIndex = 3;
            scoreboardTimesLbl.Text = "300";
            // 
            // scoreBoardNamesLbl
            // 
            scoreBoardNamesLbl.AutoSize = true;
            scoreBoardNamesLbl.Location = new Point(32, 64);
            scoreBoardNamesLbl.Name = "scoreBoardNamesLbl";
            scoreBoardNamesLbl.Size = new Size(53, 17);
            scoreBoardNamesLbl.TabIndex = 1;
            scoreBoardNamesLbl.Text = "names";
            // 
            // highScoresLbl
            // 
            highScoresLbl.AutoSize = true;
            highScoresLbl.Font = new Font("OCR A Extended", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            highScoresLbl.Location = new Point(31, 11);
            highScoresLbl.Name = "highScoresLbl";
            highScoresLbl.Size = new Size(200, 30);
            highScoresLbl.TabIndex = 0;
            highScoresLbl.Text = "High Scores";
            // 
            // leaderboardSelectPnl
            // 
            leaderboardSelectPnl.Controls.Add(leaderboardSelectPbx);
            leaderboardSelectPnl.Controls.Add(leaderboardSelectLbl);
            leaderboardSelectPnl.Controls.Add(leaderboardSelectMainMenuBtn);
            leaderboardSelectPnl.Controls.Add(leaderboardSelectDifficulty);
            leaderboardSelectPnl.Location = new Point(661, 459);
            leaderboardSelectPnl.Name = "leaderboardSelectPnl";
            leaderboardSelectPnl.Size = new Size(544, 262);
            leaderboardSelectPnl.TabIndex = 7;
            // 
            // leaderboardSelectPbx
            // 
            leaderboardSelectPbx.Image = Properties.Resources.LeaderboardSelectMeme;
            leaderboardSelectPbx.Location = new Point(248, 20);
            leaderboardSelectPbx.Name = "leaderboardSelectPbx";
            leaderboardSelectPbx.Size = new Size(278, 221);
            leaderboardSelectPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            leaderboardSelectPbx.TabIndex = 13;
            leaderboardSelectPbx.TabStop = false;
            // 
            // leaderboardSelectLbl
            // 
            leaderboardSelectLbl.AutoSize = true;
            leaderboardSelectLbl.Font = new Font("OCR A Extended", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leaderboardSelectLbl.Location = new Point(25, 20);
            leaderboardSelectLbl.Name = "leaderboardSelectLbl";
            leaderboardSelectLbl.Size = new Size(200, 30);
            leaderboardSelectLbl.TabIndex = 8;
            leaderboardSelectLbl.Text = "Leaderboard";
            // 
            // leaderboardSelectMainMenuBtn
            // 
            leaderboardSelectMainMenuBtn.Location = new Point(17, 212);
            leaderboardSelectMainMenuBtn.Name = "leaderboardSelectMainMenuBtn";
            leaderboardSelectMainMenuBtn.Size = new Size(225, 29);
            leaderboardSelectMainMenuBtn.TabIndex = 4;
            leaderboardSelectMainMenuBtn.Text = "Main Menu";
            leaderboardSelectMainMenuBtn.UseVisualStyleBackColor = true;
            leaderboardSelectMainMenuBtn.Click += leaderboardSelectMainMenuBtn_Click;
            // 
            // leaderboardSelectDifficulty
            // 
            leaderboardSelectDifficulty.Controls.Add(leaderboardSelectHard);
            leaderboardSelectDifficulty.Controls.Add(leaderboardSelectMedium);
            leaderboardSelectDifficulty.Controls.Add(leaderboardSelectEasy);
            leaderboardSelectDifficulty.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leaderboardSelectDifficulty.Location = new Point(18, 76);
            leaderboardSelectDifficulty.Name = "leaderboardSelectDifficulty";
            leaderboardSelectDifficulty.Size = new Size(224, 113);
            leaderboardSelectDifficulty.TabIndex = 4;
            leaderboardSelectDifficulty.TabStop = false;
            leaderboardSelectDifficulty.Text = "Difficulty";
            // 
            // leaderboardSelectHard
            // 
            leaderboardSelectHard.Location = new Point(7, 82);
            leaderboardSelectHard.Name = "leaderboardSelectHard";
            leaderboardSelectHard.Size = new Size(210, 25);
            leaderboardSelectHard.TabIndex = 3;
            leaderboardSelectHard.Text = "Hard";
            leaderboardSelectHard.UseVisualStyleBackColor = true;
            leaderboardSelectHard.Click += leaderboardSelectHard_Click;
            // 
            // leaderboardSelectMedium
            // 
            leaderboardSelectMedium.Location = new Point(7, 52);
            leaderboardSelectMedium.Name = "leaderboardSelectMedium";
            leaderboardSelectMedium.Size = new Size(210, 25);
            leaderboardSelectMedium.TabIndex = 2;
            leaderboardSelectMedium.Text = "Medium";
            leaderboardSelectMedium.UseVisualStyleBackColor = true;
            leaderboardSelectMedium.Click += leaderboardSelectMedium_Click;
            // 
            // leaderboardSelectEasy
            // 
            leaderboardSelectEasy.Location = new Point(7, 22);
            leaderboardSelectEasy.Name = "leaderboardSelectEasy";
            leaderboardSelectEasy.Size = new Size(210, 25);
            leaderboardSelectEasy.TabIndex = 1;
            leaderboardSelectEasy.Text = "Easy";
            leaderboardSelectEasy.UseVisualStyleBackColor = true;
            leaderboardSelectEasy.Click += leaderboardSelectEasy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1349, 1055);
            Controls.Add(leaderboardSelectPnl);
            Controls.Add(highScoresPnl);
            Controls.Add(playerInfoPnl);
            Controls.Add(instructionsPnl);
            Controls.Add(numFlagsLbl);
            Controls.Add(timerLbl);
            Controls.Add(mainMenuPnl);
            Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Memesweeper";
            ((System.ComponentModel.ISupportInitialize)newHighScorePbx).EndInit();
            difficultyMenuGbx.ResumeLayout(false);
            mainMenuPnl.ResumeLayout(false);
            mainMenuPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainMenuMemePbx).EndInit();
            instructionsPnl.ResumeLayout(false);
            instructionsPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)instructionsMemePbx).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            playerInfoPnl.ResumeLayout(false);
            playerInfoPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)infoAgeNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)whoAreYouMemePbx).EndInit();
            highScoresPnl.ResumeLayout(false);
            highScoresPnl.PerformLayout();
            leaderboardSelectPnl.ResumeLayout(false);
            leaderboardSelectPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)leaderboardSelectPbx).EndInit();
            leaderboardSelectDifficulty.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timerLbl;
        private Label numFlagsLbl;
        private GroupBox difficultyMenuGbx;
        private Button easyModeBtn;
        private Button hardModeBtn;
        private Button mediumModeBtn;
        private Panel mainMenuPnl;
        private Label titleLbl;
        private Panel instructionsPnl;
        private Label instructionsLbl;
        private Button instructionsBtn;
        private Label clickInstructionLbl;
        private Label numberInstructionLbl;
        private Label mineInstructionsLbl;
        private Button instructionsBackBtn;
        private Label mineInstructionLbl;
        private Label numbersInstructionTitleLbl;
        private Label startInstructionTitleLbl;
        private Label clearInstructionLbl;
        private Label clearInstructionTitleLbl;
        private PictureBox mainMenuMemePbx;
        private Panel panel1;
        private Panel playerInfoPnl;
        private PictureBox whoAreYouMemePbx;
        private MaskedTextBox infoNameMsk;
        private Label infoNameLbl;
        private Label infoUsernameLbl;
        private MaskedTextBox infoUsernameMsk;
        private Label infoAgeLbl;
        private NumericUpDown infoAgeNud;
        private Button infoSaveBtn;
        private Label infoTitleLbl;
        private Button profileBtn;
        private Panel highScoresPnl;
        private Label highScoresLbl;
        private Label scoreBoardNamesLbl;
        private Button leaderboardMainBtn;
        private Label scoreboardTimesLbl;
        private PictureBox newHighScorePbx;
        private PictureBox instructionsMemePbx;
        private Button leaderboardMainMenuBtn;
        private Panel leaderboardSelectPnl;
        private Button leaderboardSelectMainMenuBtn;
        private GroupBox leaderboardSelectDifficulty;
        private Button leaderboardSelectHard;
        private Button leaderboardSelectMedium;
        private Button leaderboardSelectEasy;
        private Label leaderboardSelectLbl;
        private PictureBox leaderboardSelectPbx;
        private Label highScoreDifficultyLbl;
    }
}
