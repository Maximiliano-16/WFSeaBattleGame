using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFSeaBattleGame.Registration;

namespace WFSeaBattleGame
{
    public partial class MainForm : Form
    {
        public Authentication authentication;
        private GameForm _gameForm;

        // public bool isUserAuthorized { get; set; } = false;
        public MainForm()
        {
            InitializeComponent();
            authentication = new Authentication(this);


        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            RegisterForm newForm = new RegisterForm(this);
            newForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm(this);
            newForm.Show();
        }
               
        private void MainForm_Shown(object sender, EventArgs e)
        {
           
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            if (authentication.isUserAuthorized) 
            {
                welcomeLable.Text = $"Привет {authentication.userLogin}";
                //welcomeLable.TextAlign = ContentAlignment.TopCenter;
                loginButton.Visible = false;
                registrationButton.Visible = false;
                startGameButton.Visible = true;
                unloginButton.Visible = true;
            }
            else
            {
                welcomeLable.Text = $"Добро Пожаловать!\r\nВойдите в аккаунт, чтобы начать игру\r\n";
                loginButton.Visible = true;
                registrationButton.Visible = true;
                startGameButton.Visible = false;
                unloginButton.Visible = false;
            }
        }
        public void MainForm_Refresh(object sender, EventArgs e)
        {
            if (authentication.isUserAuthorized) { welcomeLable.Text = $"Привет {authentication.userLogin}"; }
        }

    
        private void startGameButton_Click(object sender, EventArgs e)
        {
            _gameForm = new GameForm(this);
            _gameForm.Show();
        }

        private void unloginButton_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Вы уверены, что хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                     break;
                default:
                    this.authentication.changeUserAutorized(false); // изменяем статус на авторизирован
                    this.authentication.userLogin = ""; // устанавливаем логин
                    this.MainForm_Load(sender, EventArgs.Empty);
                    
                    break;
            }
        }
    }
}
