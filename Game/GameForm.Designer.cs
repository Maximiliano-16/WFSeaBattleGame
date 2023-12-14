namespace WFSeaBattleGame
{
    partial class GameForm
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
            this.labelPrompt = new System.Windows.Forms.Label();
            this.label1x = new System.Windows.Forms.Label();
            this.labelComputerMove = new System.Windows.Forms.Label();
            this.labelShipsPlaceLeft = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelEnemyField = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelYourField = new System.Windows.Forms.Label();
            this.label4x = new System.Windows.Forms.Label();
            this.label3x = new System.Windows.Forms.Label();
            this.label2x = new System.Windows.Forms.Label();
            this.button1x = new System.Windows.Forms.Button();
            this.button2x = new System.Windows.Forms.Button();
            this.button3x = new System.Windows.Forms.Button();
            this.button4x = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBoxEnemy = new System.Windows.Forms.GroupBox();
            this.checkBoxMarkEnemyMoves = new System.Windows.Forms.CheckBox();
            this.labelComputerMovingSpeed = new System.Windows.Forms.Label();
            this.comboBoxComputerMoveSpeed = new System.Windows.Forms.ComboBox();
            this.buttonArrangeShipsRandomly = new System.Windows.Forms.Button();
            this.labelShipPlacement = new System.Windows.Forms.Label();
            this.labelPlaceShips = new System.Windows.Forms.Label();
            this.buttonGameStart = new System.Windows.Forms.Button();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GameRestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComputerMovesSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SlowlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AverageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RapidlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstantlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarkComputerMovesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            this.groupBoxEnemy.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.BackColor = System.Drawing.SystemColors.Control;
            this.labelPrompt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelPrompt.Location = new System.Drawing.Point(795, 531);
            this.labelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(377, 16);
            this.labelPrompt.TabIndex = 37;
            this.labelPrompt.Text = "Нажмите правой кнопкой мыши для изменения настроек";
            // 
            // label1x
            // 
            this.label1x.AutoSize = true;
            this.label1x.Location = new System.Drawing.Point(795, 120);
            this.label1x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1x.Name = "label1x";
            this.label1x.Size = new System.Drawing.Size(14, 16);
            this.label1x.TabIndex = 34;
            this.label1x.Text = "4";
            // 
            // labelComputerMove
            // 
            this.labelComputerMove.AutoSize = true;
            this.labelComputerMove.ForeColor = System.Drawing.Color.Red;
            this.labelComputerMove.Location = new System.Drawing.Point(149, 474);
            this.labelComputerMove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComputerMove.Name = "labelComputerMove";
            this.labelComputerMove.Size = new System.Drawing.Size(99, 16);
            this.labelComputerMove.TabIndex = 35;
            this.labelComputerMove.Text = "Очередь компьютера";
            this.labelComputerMove.Visible = false;
            this.labelComputerMove.VisibleChanged += new System.EventHandler(this.labelComputerMove_VisibleChanged);
            // 
            // labelShipsPlaceLeft
            // 
            this.labelShipsPlaceLeft.AutoSize = true;
            this.labelShipsPlaceLeft.BackColor = System.Drawing.Color.Transparent;
            this.labelShipsPlaceLeft.Location = new System.Drawing.Point(168, 465);
            this.labelShipsPlaceLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShipsPlaceLeft.Name = "labelShipsPlaceLeft";
            this.labelShipsPlaceLeft.Size = new System.Drawing.Size(134, 16);
            this.labelShipsPlaceLeft.TabIndex = 33;
            this.labelShipsPlaceLeft.Text = "Кораблей осталось";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(376, 502);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(127, 28);
            this.buttonRestart.TabIndex = 26;
            this.buttonRestart.Text = "Play again";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(371, 467);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(117, 25);
            this.labelStatus.TabIndex = 32;
            this.labelStatus.Text = "Статус: ----";
            this.labelStatus.Visible = false;
            // 
            // labelEnemyField
            // 
            this.labelEnemyField.AutoSize = true;
            this.labelEnemyField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEnemyField.Location = new System.Drawing.Point(657, 5);
            this.labelEnemyField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnemyField.Name = "labelEnemyField";
            this.labelEnemyField.Size = new System.Drawing.Size(122, 16);
            this.labelEnemyField.TabIndex = 30;
            this.labelEnemyField.Text = "Поле противника";
            this.labelEnemyField.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(69, 485);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(275, 28);
            this.progressBar.TabIndex = 31;
            // 
            // labelYourField
            // 
            this.labelYourField.AutoSize = true;
            this.labelYourField.ForeColor = System.Drawing.Color.Green;
            this.labelYourField.Location = new System.Drawing.Point(149, 5);
            this.labelYourField.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYourField.Name = "labelYourField";
            this.labelYourField.Size = new System.Drawing.Size(76, 16);
            this.labelYourField.TabIndex = 29;
            this.labelYourField.Text = "Ваше поле";
            // 
            // label4x
            // 
            this.label4x.AutoSize = true;
            this.label4x.Location = new System.Drawing.Point(580, 120);
            this.label4x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4x.Name = "label4x";
            this.label4x.Size = new System.Drawing.Size(14, 16);
            this.label4x.TabIndex = 28;
            this.label4x.Text = "1";
            // 
            // label3x
            // 
            this.label3x.AutoSize = true;
            this.label3x.Location = new System.Drawing.Point(653, 120);
            this.label3x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3x.Name = "label3x";
            this.label3x.Size = new System.Drawing.Size(14, 16);
            this.label3x.TabIndex = 27;
            this.label3x.Text = "2";
            // 
            // label2x
            // 
            this.label2x.AutoSize = true;
            this.label2x.Location = new System.Drawing.Point(725, 120);
            this.label2x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2x.Name = "label2x";
            this.label2x.Size = new System.Drawing.Size(14, 16);
            this.label2x.TabIndex = 25;
            this.label2x.Text = "3";
            // 
            // button1x
            // 
            this.button1x.Location = new System.Drawing.Point(772, 76);
            this.button1x.Margin = new System.Windows.Forms.Padding(4);
            this.button1x.Name = "button1x";
            this.button1x.Size = new System.Drawing.Size(63, 28);
            this.button1x.TabIndex = 24;
            this.button1x.Text = "1x";
            this.button1x.UseVisualStyleBackColor = true;
            // 
            // button2x
            // 
            this.button2x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2x.Location = new System.Drawing.Point(701, 76);
            this.button2x.Margin = new System.Windows.Forms.Padding(4);
            this.button2x.Name = "button2x";
            this.button2x.Size = new System.Drawing.Size(63, 28);
            this.button2x.TabIndex = 23;
            this.button2x.Text = "2x";
            this.button2x.UseVisualStyleBackColor = true;
            // 
            // button3x
            // 
            this.button3x.Location = new System.Drawing.Point(631, 76);
            this.button3x.Margin = new System.Windows.Forms.Padding(4);
            this.button3x.Name = "button3x";
            this.button3x.Size = new System.Drawing.Size(63, 28);
            this.button3x.TabIndex = 22;
            this.button3x.Text = "3x";
            this.button3x.UseVisualStyleBackColor = true;
            // 
            // button4x
            // 
            this.button4x.Location = new System.Drawing.Point(560, 76);
            this.button4x.Margin = new System.Windows.Forms.Padding(4);
            this.button4x.Name = "button4x";
            this.button4x.Size = new System.Drawing.Size(63, 28);
            this.button4x.TabIndex = 21;
            this.button4x.Text = "4x";
            this.button4x.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.groupBoxEnemy);
            this.panel.Controls.Add(this.buttonArrangeShipsRandomly);
            this.panel.Controls.Add(this.labelShipPlacement);
            this.panel.Controls.Add(this.labelPlaceShips);
            this.panel.Controls.Add(this.buttonGameStart);
            this.panel.Controls.Add(this.buttonRotate);
            this.panel.Location = new System.Drawing.Point(511, 25);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(468, 489);
            this.panel.TabIndex = 36;
            // 
            // groupBoxEnemy
            // 
            this.groupBoxEnemy.Controls.Add(this.checkBoxMarkEnemyMoves);
            this.groupBoxEnemy.Controls.Add(this.labelComputerMovingSpeed);
            this.groupBoxEnemy.Controls.Add(this.comboBoxComputerMoveSpeed);
            this.groupBoxEnemy.Location = new System.Drawing.Point(103, 267);
            this.groupBoxEnemy.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEnemy.Name = "groupBoxEnemy";
            this.groupBoxEnemy.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEnemy.Size = new System.Drawing.Size(267, 134);
            this.groupBoxEnemy.TabIndex = 21;
            this.groupBoxEnemy.TabStop = false;
            this.groupBoxEnemy.Text = "Настройки врага";
            // 
            // checkBoxMarkEnemyMoves
            // 
            this.checkBoxMarkEnemyMoves.AutoSize = true;
            this.checkBoxMarkEnemyMoves.Checked = true;
            this.checkBoxMarkEnemyMoves.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMarkEnemyMoves.Location = new System.Drawing.Point(84, 98);
            this.checkBoxMarkEnemyMoves.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMarkEnemyMoves.Name = "checkBoxMarkEnemyMoves";
            this.checkBoxMarkEnemyMoves.Size = new System.Drawing.Size(127, 20);
            this.checkBoxMarkEnemyMoves.TabIndex = 19;
            this.checkBoxMarkEnemyMoves.Text = "Отмечать ходы";
            this.checkBoxMarkEnemyMoves.UseVisualStyleBackColor = true;
            this.checkBoxMarkEnemyMoves.CheckedChanged += new System.EventHandler(this.CheckBoxMarkEnemyMoves_CheckedChanged);
            // 
            // labelComputerMovingSpeed
            // 
            this.labelComputerMovingSpeed.AutoSize = true;
            this.labelComputerMovingSpeed.Location = new System.Drawing.Point(89, 32);
            this.labelComputerMovingSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComputerMovingSpeed.Name = "labelComputerMovingSpeed";
            this.labelComputerMovingSpeed.Size = new System.Drawing.Size(101, 16);
            this.labelComputerMovingSpeed.TabIndex = 16;
            this.labelComputerMovingSpeed.Text = "Скорость хода";
            // 
            // comboBoxComputerMoveSpeed
            // 
            this.comboBoxComputerMoveSpeed.FormattingEnabled = true;
            this.comboBoxComputerMoveSpeed.Items.AddRange(new object[] {
            "Медленно",
            "Нормально",
            "Быстро",
            "Безумно"});
            this.comboBoxComputerMoveSpeed.Location = new System.Drawing.Point(47, 52);
            this.comboBoxComputerMoveSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxComputerMoveSpeed.Name = "comboBoxComputerMoveSpeed";
            this.comboBoxComputerMoveSpeed.Size = new System.Drawing.Size(179, 24);
            this.comboBoxComputerMoveSpeed.TabIndex = 15;
            this.comboBoxComputerMoveSpeed.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // buttonArrangeShipsRandomly
            // 
            this.buttonArrangeShipsRandomly.Location = new System.Drawing.Point(150, 198);
            this.buttonArrangeShipsRandomly.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArrangeShipsRandomly.Name = "buttonArrangeShipsRandomly";
            this.buttonArrangeShipsRandomly.Size = new System.Drawing.Size(180, 52);
            this.buttonArrangeShipsRandomly.TabIndex = 22;
            this.buttonArrangeShipsRandomly.Text = "Расставить корабли рандомно";
            this.buttonArrangeShipsRandomly.UseVisualStyleBackColor = true;
            this.buttonArrangeShipsRandomly.Click += new System.EventHandler(this.buttonArrangeShipsRandomly_Click);
            // 
            // labelShipPlacement
            // 
            this.labelShipPlacement.AutoSize = true;
            this.labelShipPlacement.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelShipPlacement.Location = new System.Drawing.Point(191, 167);
            this.labelShipPlacement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShipPlacement.Name = "labelShipPlacement";
            this.labelShipPlacement.Size = new System.Drawing.Size(99, 16);
            this.labelShipPlacement.TabIndex = 18;
            this.labelShipPlacement.Text = "Размещение: |";
            // 
            // labelPlaceShips
            // 
            this.labelPlaceShips.AutoSize = true;
            this.labelPlaceShips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlaceShips.Location = new System.Drawing.Point(172, 12);
            this.labelPlaceShips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlaceShips.Name = "labelPlaceShips";
            this.labelPlaceShips.Size = new System.Drawing.Size(200, 25);
            this.labelPlaceShips.TabIndex = 15;
            this.labelPlaceShips.Text = "Расставьте корабли";
            // 
            // buttonGameStart
            // 
            this.buttonGameStart.Enabled = false;
            this.buttonGameStart.Location = new System.Drawing.Point(150, 428);
            this.buttonGameStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGameStart.Name = "buttonGameStart";
            this.buttonGameStart.Size = new System.Drawing.Size(180, 28);
            this.buttonGameStart.TabIndex = 5;
            this.buttonGameStart.Text = "Начать игру";
            this.buttonGameStart.UseVisualStyleBackColor = true;
            this.buttonGameStart.Click += new System.EventHandler(this.buttonGameStart_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(149, 135);
            this.buttonRotate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(180, 28);
            this.buttonRotate.TabIndex = 4;
            this.buttonRotate.Text = "Повернуть корабль";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameRestartToolStripMenuItem,
            this.ComputerMovesSpeedToolStripMenuItem,
            this.MarkComputerMovesToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(275, 82);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Opening);
            // 
            // GameRestartToolStripMenuItem
            // 
            this.GameRestartToolStripMenuItem.Name = "GameRestartToolStripMenuItem";
            this.GameRestartToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.GameRestartToolStripMenuItem.Text = "Перезапустить игру";
            this.GameRestartToolStripMenuItem.Click += new System.EventHandler(this.GameRestartToolStripMenuItem_Click);
            // 
            // ComputerMovesSpeedToolStripMenuItem
            // 
            this.ComputerMovesSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SlowlyToolStripMenuItem,
            this.AverageToolStripMenuItem,
            this.RapidlyToolStripMenuItem,
            this.InstantlyToolStripMenuItem});
            this.ComputerMovesSpeedToolStripMenuItem.Name = "ComputerMovesSpeedToolStripMenuItem";
            this.ComputerMovesSpeedToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.ComputerMovesSpeedToolStripMenuItem.Text = "Скорость хода компьютера";
            // 
            // SlowlyToolStripMenuItem
            // 
            this.SlowlyToolStripMenuItem.Name = "SlowlyToolStripMenuItem";
            this.SlowlyToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.SlowlyToolStripMenuItem.Text = "Медленно";
            // 
            // AverageToolStripMenuItem
            // 
            this.AverageToolStripMenuItem.Checked = true;
            this.AverageToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AverageToolStripMenuItem.Name = "AverageToolStripMenuItem";
            this.AverageToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.AverageToolStripMenuItem.Text = "Нормально";
            // 
            // RapidlyToolStripMenuItem
            // 
            this.RapidlyToolStripMenuItem.Name = "RapidlyToolStripMenuItem";
            this.RapidlyToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.RapidlyToolStripMenuItem.Text = "Быстро";
            // 
            // InstantlyToolStripMenuItem
            // 
            this.InstantlyToolStripMenuItem.Name = "InstantlyToolStripMenuItem";
            this.InstantlyToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.InstantlyToolStripMenuItem.Text = "Безумно";
            // 
            // MarkComputerMovesToolStripMenuItem
            // 
            this.MarkComputerMovesToolStripMenuItem.Checked = true;
            this.MarkComputerMovesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MarkComputerMovesToolStripMenuItem.Name = "MarkComputerMovesToolStripMenuItem";
            this.MarkComputerMovesToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.MarkComputerMovesToolStripMenuItem.Text = "Отмечать ходы компьютера";
            this.MarkComputerMovesToolStripMenuItem.Click += new System.EventHandler(this.MarkComputerMovesToolStripMenuItem_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 553);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.labelPrompt);
            this.Controls.Add(this.label1x);
            this.Controls.Add(this.labelComputerMove);
            this.Controls.Add(this.labelShipsPlaceLeft);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelEnemyField);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelYourField);
            this.Controls.Add(this.label4x);
            this.Controls.Add(this.label3x);
            this.Controls.Add(this.label2x);
            this.Controls.Add(this.button1x);
            this.Controls.Add(this.button2x);
            this.Controls.Add(this.button3x);
            this.Controls.Add(this.button4x);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBoxEnemy.ResumeLayout(false);
            this.groupBoxEnemy.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.Label label1x;
        private System.Windows.Forms.Label labelComputerMove;
        private System.Windows.Forms.Label labelShipsPlaceLeft;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelEnemyField;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelYourField;
        private System.Windows.Forms.Label label4x;
        private System.Windows.Forms.Label label3x;
        private System.Windows.Forms.Label label2x;
        private System.Windows.Forms.Button button1x;
        private System.Windows.Forms.Button button2x;
        private System.Windows.Forms.Button button3x;
        private System.Windows.Forms.Button button4x;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBoxEnemy;
        private System.Windows.Forms.CheckBox checkBoxMarkEnemyMoves;
        private System.Windows.Forms.Label labelComputerMovingSpeed;
        private System.Windows.Forms.ComboBox comboBoxComputerMoveSpeed;
        private System.Windows.Forms.Button buttonArrangeShipsRandomly;
        private System.Windows.Forms.Label labelShipPlacement;
        private System.Windows.Forms.Label labelPlaceShips;
        private System.Windows.Forms.Button buttonGameStart;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem GameRestartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComputerMovesSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SlowlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AverageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RapidlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InstantlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MarkComputerMovesToolStripMenuItem;
    }
}