namespace TwelveWindowsForms
{
    partial class frmDrawing
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
            this.components = new System.ComponentModel.Container();
            this.pbxGrid = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.aggressiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.restartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameplayOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Animations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.PointerShadow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.SoundEffects = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.Crono = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.grbGame = new System.Windows.Forms.GroupBox();
            this.lblHigher = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbBest = new System.Windows.Forms.GroupBox();
            this.lblBestHigher = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBestTime = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grbGame.SuspendLayout();
            this.grbBest.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxGrid
            // 
            this.pbxGrid.BackColor = System.Drawing.Color.DimGray;
            this.pbxGrid.Location = new System.Drawing.Point(254, 105);
            this.pbxGrid.Name = "pbxGrid";
            this.pbxGrid.Size = new System.Drawing.Size(241, 343);
            this.pbxGrid.TabIndex = 0;
            this.pbxGrid.TabStop = false;
            this.pbxGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxGrid_Paint);
            this.pbxGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxGrid_MouseClick);
            this.pbxGrid.MouseLeave += new System.EventHandler(this.pbxGrid_MouseLeave);
            this.pbxGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxGrid_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameplayOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 31);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.restartGameToolStripMenuItem,
            this.toolStripSeparator3,
            this.scoresToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 27);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.Animations_Click);
            this.fileToolStripMenuItem.MouseEnter += new System.EventHandler(this.Animations_MouseEnter);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fastNewGameToolStripMenuItem,
            this.toolStripSeparator6,
            this.newGameToolStripMenuItem1});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.MouseEnter += new System.EventHandler(this.Animations_MouseEnter);
            // 
            // fastNewGameToolStripMenuItem
            // 
            this.fastNewGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.toolStripSeparator7,
            this.aggressiveToolStripMenuItem});
            this.fastNewGameToolStripMenuItem.Name = "fastNewGameToolStripMenuItem";
            this.fastNewGameToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.fastNewGameToolStripMenuItem.Text = "Fast New Game";
            this.fastNewGameToolStripMenuItem.MouseEnter += new System.EventHandler(this.Animations_MouseEnter);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(172, 28);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            this.normalToolStripMenuItem.MouseEnter += new System.EventHandler(this.Animations_MouseEnter);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(169, 6);
            // 
            // aggressiveToolStripMenuItem
            // 
            this.aggressiveToolStripMenuItem.Name = "aggressiveToolStripMenuItem";
            this.aggressiveToolStripMenuItem.Size = new System.Drawing.Size(172, 28);
            this.aggressiveToolStripMenuItem.Text = "Aggressive";
            this.aggressiveToolStripMenuItem.Click += new System.EventHandler(this.aggressiveToolStripMenuItem_Click);
            this.aggressiveToolStripMenuItem.MouseEnter += new System.EventHandler(this.Animations_MouseEnter);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(213, 6);
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(216, 28);
            this.newGameToolStripMenuItem1.Text = "New Game...";
            this.newGameToolStripMenuItem1.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            this.newGameToolStripMenuItem1.MouseEnter += new System.EventHandler(this.Animations_MouseEnter);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // restartGameToolStripMenuItem
            // 
            this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            this.restartGameToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.restartGameToolStripMenuItem.Text = "Restart Game";
            this.restartGameToolStripMenuItem.Click += new System.EventHandler(this.restartGameToolStripMenuItem_Click);
            this.restartGameToolStripMenuItem.MouseEnter += new System.EventHandler(this.Animations_MouseEnter);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            // 
            // scoresToolStripMenuItem
            // 
            this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            this.scoresToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.scoresToolStripMenuItem.Text = "Scores";
            this.scoresToolStripMenuItem.Click += new System.EventHandler(this.scoresToolStripMenuItem_Click);
            this.scoresToolStripMenuItem.MouseEnter += new System.EventHandler(this.Animations_MouseEnter);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseEnter += new System.EventHandler(this.Animations_MouseEnter);
            // 
            // gameplayOptionsToolStripMenuItem
            // 
            this.gameplayOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Animations,
            this.toolStripSeparator4,
            this.PointerShadow,
            this.toolStripSeparator5,
            this.SoundEffects});
            this.gameplayOptionsToolStripMenuItem.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameplayOptionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gameplayOptionsToolStripMenuItem.Name = "gameplayOptionsToolStripMenuItem";
            this.gameplayOptionsToolStripMenuItem.Size = new System.Drawing.Size(178, 27);
            this.gameplayOptionsToolStripMenuItem.Text = "Gameplay Options";
            this.gameplayOptionsToolStripMenuItem.Click += new System.EventHandler(this.Animations_Click);
            this.gameplayOptionsToolStripMenuItem.MouseEnter += new System.EventHandler(this.Animations_MouseEnter);
            // 
            // Animations
            // 
            this.Animations.Checked = true;
            this.Animations.CheckOnClick = true;
            this.Animations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animations.Name = "Animations";
            this.Animations.Size = new System.Drawing.Size(220, 28);
            this.Animations.Text = "Animations";
            this.Animations.Click += new System.EventHandler(this.Animations_Click);
            this.Animations.MouseEnter += new System.EventHandler(this.Animations_MouseEnter);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(217, 6);
            // 
            // PointerShadow
            // 
            this.PointerShadow.Checked = true;
            this.PointerShadow.CheckOnClick = true;
            this.PointerShadow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PointerShadow.Name = "PointerShadow";
            this.PointerShadow.Size = new System.Drawing.Size(220, 28);
            this.PointerShadow.Text = "Pointer Shadow";
            this.PointerShadow.Click += new System.EventHandler(this.Animations_Click);
            this.PointerShadow.MouseEnter += new System.EventHandler(this.Animations_MouseEnter);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(217, 6);
            // 
            // SoundEffects
            // 
            this.SoundEffects.Checked = true;
            this.SoundEffects.CheckOnClick = true;
            this.SoundEffects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SoundEffects.Name = "SoundEffects";
            this.SoundEffects.Size = new System.Drawing.Size(220, 28);
            this.SoundEffects.Text = "Sound Effects";
            this.SoundEffects.Click += new System.EventHandler(this.Animations_Click);
            this.SoundEffects.MouseEnter += new System.EventHandler(this.Animations_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Moves:";
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoves.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMoves.Location = new System.Drawing.Point(19, 58);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(21, 23);
            this.lblMoves.TabIndex = 6;
            this.lblMoves.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(3, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTime.Location = new System.Drawing.Point(3, 233);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 23);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "0:00:00";
            // 
            // Crono
            // 
            this.Crono.Interval = 1000;
            this.Crono.Tick += new System.EventHandler(this.Crono_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label.Location = new System.Drawing.Point(3, 154);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 23);
            this.label.TabIndex = 9;
            this.label.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblScore.Location = new System.Drawing.Point(19, 177);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(21, 23);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "0";
            // 
            // grbGame
            // 
            this.grbGame.Controls.Add(this.lblHigher);
            this.grbGame.Controls.Add(this.label3);
            this.grbGame.Controls.Add(this.label4);
            this.grbGame.Controls.Add(this.label1);
            this.grbGame.Controls.Add(this.lblScore);
            this.grbGame.Controls.Add(this.lblMoves);
            this.grbGame.Controls.Add(this.label);
            this.grbGame.Controls.Add(this.label2);
            this.grbGame.Controls.Add(this.lblTime);
            this.grbGame.Location = new System.Drawing.Point(0, 105);
            this.grbGame.Name = "grbGame";
            this.grbGame.Size = new System.Drawing.Size(85, 286);
            this.grbGame.TabIndex = 11;
            this.grbGame.TabStop = false;
            this.grbGame.Text = "groupBox1";
            // 
            // lblHigher
            // 
            this.lblHigher.AutoSize = true;
            this.lblHigher.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigher.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblHigher.Location = new System.Drawing.Point(19, 116);
            this.lblHigher.Name = "lblHigher";
            this.lblHigher.Size = new System.Drawing.Size(27, 23);
            this.lblHigher.TabIndex = 13;
            this.lblHigher.Text = " 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(2, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Higher:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Game";
            // 
            // grbBest
            // 
            this.grbBest.Controls.Add(this.lblBestHigher);
            this.grbBest.Controls.Add(this.label6);
            this.grbBest.Controls.Add(this.label7);
            this.grbBest.Controls.Add(this.label8);
            this.grbBest.Controls.Add(this.lblBestScore);
            this.grbBest.Controls.Add(this.lblName);
            this.grbBest.Controls.Add(this.label11);
            this.grbBest.Controls.Add(this.label12);
            this.grbBest.Controls.Add(this.lblBestTime);
            this.grbBest.Location = new System.Drawing.Point(724, 105);
            this.grbBest.Name = "grbBest";
            this.grbBest.Size = new System.Drawing.Size(85, 286);
            this.grbBest.TabIndex = 12;
            this.grbBest.TabStop = false;
            this.grbBest.Text = "groupBox1";
            // 
            // lblBestHigher
            // 
            this.lblBestHigher.AutoSize = true;
            this.lblBestHigher.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestHigher.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblBestHigher.Location = new System.Drawing.Point(19, 116);
            this.lblBestHigher.Name = "lblBestHigher";
            this.lblBestHigher.Size = new System.Drawing.Size(27, 23);
            this.lblBestHigher.TabIndex = 13;
            this.lblBestHigher.Text = " 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(2, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Higher:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(9, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Best";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(3, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Name:";
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBestScore.Location = new System.Drawing.Point(19, 177);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(21, 23);
            this.lblBestScore.TabIndex = 10;
            this.lblBestScore.Text = "0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblName.Location = new System.Drawing.Point(10, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(18, 19);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(3, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 23);
            this.label11.TabIndex = 9;
            this.label11.Text = "Score:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(3, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 23);
            this.label12.TabIndex = 7;
            this.label12.Text = "Time:";
            // 
            // lblBestTime
            // 
            this.lblBestTime.AutoSize = true;
            this.lblBestTime.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestTime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBestTime.Location = new System.Drawing.Point(3, 233);
            this.lblBestTime.Name = "lblBestTime";
            this.lblBestTime.Size = new System.Drawing.Size(77, 23);
            this.lblBestTime.TabIndex = 8;
            this.lblBestTime.Text = "0:00:00";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Black;
            this.lblExit.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Red;
            this.lblExit.Location = new System.Drawing.Point(726, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(28, 28);
            this.lblExit.TabIndex = 14;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.lblExit_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            // 
            // frmDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(809, 575);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.grbBest);
            this.Controls.Add(this.grbGame);
            this.Controls.Add(this.pbxGrid);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDrawing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twelve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDrawing_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbGame.ResumeLayout(false);
            this.grbGame.PerformLayout();
            this.grbBest.ResumeLayout(false);
            this.grbBest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer Crono;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.GroupBox grbGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHigher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem restartGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameplayOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Animations;
        private System.Windows.Forms.ToolStripMenuItem PointerShadow;
        private System.Windows.Forms.GroupBox grbBest;
        private System.Windows.Forms.Label lblBestHigher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblBestTime;
        private System.Windows.Forms.ToolStripMenuItem SoundEffects;
        private System.Windows.Forms.ToolStripMenuItem fastNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggressiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label lblExit;
    }
}

