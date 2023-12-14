namespace WFSeaBattleGame
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.welcomeLable = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.unloginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(321, 290);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(135, 77);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Авторизация";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(321, 171);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(135, 77);
            this.registrationButton.TabIndex = 1;
            this.registrationButton.Text = "Регистрация";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // welcomeLable
            // 
            this.welcomeLable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLable.Location = new System.Drawing.Point(96, 22);
            this.welcomeLable.Name = "welcomeLable";
            this.welcomeLable.Size = new System.Drawing.Size(607, 72);
            this.welcomeLable.TabIndex = 2;
            this.welcomeLable.Text = "Добро Пожаловать!\r\nВойдите в аккаунт, чтобы начать игру\r\n";
            this.welcomeLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.SystemColors.Window;
            this.startGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGameButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startGameButton.Location = new System.Drawing.Point(311, 156);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(173, 98);
            this.startGameButton.TabIndex = 6;
            this.startGameButton.Text = "Начать новую игру";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Visible = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // unloginButton
            // 
            this.unloginButton.BackColor = System.Drawing.SystemColors.Window;
            this.unloginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unloginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unloginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unloginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unloginButton.Location = new System.Drawing.Point(311, 331);
            this.unloginButton.Name = "unloginButton";
            this.unloginButton.Size = new System.Drawing.Size(158, 55);
            this.unloginButton.TabIndex = 7;
            this.unloginButton.Text = "Выйти из аккаунта";
            this.unloginButton.UseVisualStyleBackColor = false;
            this.unloginButton.Visible = false;
            this.unloginButton.Click += new System.EventHandler(this.unloginButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.welcomeLable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 116);
            this.panel1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.unloginButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.loginButton);
            this.Name = "MainForm";
            this.Text = "SeaBattle ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label welcomeLable;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button unloginButton;
        private System.Windows.Forms.Panel panel1;
    }
}

