namespace WFSeaBattleGame.Registration
{
    partial class RegisterForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.registerLabel = new System.Windows.Forms.Label();
            this.helpEnterNameLabel = new System.Windows.Forms.Label();
            this.helpEnterPasswordLabel = new System.Windows.Forms.Label();
            this.helpEnterLoginLabel = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.namePicture = new System.Windows.Forms.PictureBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.passPicture = new System.Windows.Forms.PictureBox();
            this.authPicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mainPanel.Controls.Add(this.registerLabel);
            this.mainPanel.Controls.Add(this.helpEnterNameLabel);
            this.mainPanel.Controls.Add(this.helpEnterPasswordLabel);
            this.mainPanel.Controls.Add(this.helpEnterLoginLabel);
            this.mainPanel.Controls.Add(this.loginField);
            this.mainPanel.Controls.Add(this.nameField);
            this.mainPanel.Controls.Add(this.namePicture);
            this.mainPanel.Controls.Add(this.buttonRegister);
            this.mainPanel.Controls.Add(this.passField);
            this.mainPanel.Controls.Add(this.passPicture);
            this.mainPanel.Controls.Add(this.authPicture);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(582, 583);
            this.mainPanel.TabIndex = 1;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registerLabel.Location = new System.Drawing.Point(217, 499);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(121, 18);
            this.registerLabel.TabIndex = 11;
            this.registerLabel.Text = "Авторизоваться";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // helpEnterNameLabel
            // 
            this.helpEnterNameLabel.AutoSize = true;
            this.helpEnterNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.helpEnterNameLabel.Enabled = false;
            this.helpEnterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpEnterNameLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpEnterNameLabel.Location = new System.Drawing.Point(162, 160);
            this.helpEnterNameLabel.Name = "helpEnterNameLabel";
            this.helpEnterNameLabel.Size = new System.Drawing.Size(183, 32);
            this.helpEnterNameLabel.TabIndex = 10;
            this.helpEnterNameLabel.Text = "Введите имя";
            // 
            // helpEnterPasswordLabel
            // 
            this.helpEnterPasswordLabel.AutoSize = true;
            this.helpEnterPasswordLabel.BackColor = System.Drawing.SystemColors.Window;
            this.helpEnterPasswordLabel.Enabled = false;
            this.helpEnterPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpEnterPasswordLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpEnterPasswordLabel.Location = new System.Drawing.Point(162, 334);
            this.helpEnterPasswordLabel.Name = "helpEnterPasswordLabel";
            this.helpEnterPasswordLabel.Size = new System.Drawing.Size(227, 32);
            this.helpEnterPasswordLabel.TabIndex = 9;
            this.helpEnterPasswordLabel.Text = "Введите пароль";
            // 
            // helpEnterLoginLabel
            // 
            this.helpEnterLoginLabel.AutoSize = true;
            this.helpEnterLoginLabel.BackColor = System.Drawing.SystemColors.Window;
            this.helpEnterLoginLabel.Enabled = false;
            this.helpEnterLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpEnterLoginLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpEnterLoginLabel.Location = new System.Drawing.Point(162, 247);
            this.helpEnterLoginLabel.Name = "helpEnterLoginLabel";
            this.helpEnterLoginLabel.Size = new System.Drawing.Size(207, 32);
            this.helpEnterLoginLabel.TabIndex = 8;
            this.helpEnterLoginLabel.Text = "Введите логин";
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(147, 231);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(350, 64);
            this.loginField.TabIndex = 2;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.Location = new System.Drawing.Point(147, 143);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(350, 64);
            this.nameField.TabIndex = 7;
            this.nameField.Enter += new System.EventHandler(this.nameField_Enter);
            this.nameField.Leave += new System.EventHandler(this.nameField_Leave);
            // 
            // namePicture
            // 
            this.namePicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.namePicture.Image = global::WFSeaBattleGame.Properties.Resources._4092564_profile_about_mobile_ui_user_icon;
            this.namePicture.Location = new System.Drawing.Point(46, 143);
            this.namePicture.Name = "namePicture";
            this.namePicture.Size = new System.Drawing.Size(64, 64);
            this.namePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.namePicture.TabIndex = 6;
            this.namePicture.TabStop = false;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(147, 421);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(292, 66);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(147, 316);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(350, 38);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // passPicture
            // 
            this.passPicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passPicture.Image = global::WFSeaBattleGame.Properties.Resources._511942_lock_login_protection_secure_icon;
            this.passPicture.Location = new System.Drawing.Point(46, 316);
            this.passPicture.Name = "passPicture";
            this.passPicture.Size = new System.Drawing.Size(64, 64);
            this.passPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passPicture.TabIndex = 3;
            this.passPicture.TabStop = false;
            // 
            // authPicture
            // 
            this.authPicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.authPicture.Image = global::WFSeaBattleGame.Properties.Resources._4092564_profile_about_mobile_ui_user_icon;
            this.authPicture.Location = new System.Drawing.Point(46, 231);
            this.authPicture.Name = "authPicture";
            this.authPicture.Size = new System.Drawing.Size(64, 64);
            this.authPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.authPicture.TabIndex = 1;
            this.authPicture.TabStop = false;
            this.authPicture.Click += new System.EventHandler(this.authPicture_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 100);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(549, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Х";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 583);
            this.Controls.Add(this.mainPanel);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox passPicture;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox authPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.PictureBox namePicture;
        private System.Windows.Forms.Label helpEnterLoginLabel;
        private System.Windows.Forms.Label helpEnterPasswordLabel;
        private System.Windows.Forms.Label helpEnterNameLabel;
        private System.Windows.Forms.Label registerLabel;
    }
}