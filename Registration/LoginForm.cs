using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFSeaBattleGame.Registration
{
    public partial class LoginForm : Form
    {
        private readonly MainForm _mainForm;

        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Width, this.passPicture.Height);
        }
        //Authentication authentication;
        public LoginForm()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Width, this.passPicture.Height);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.LightGray;
        }
        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        // кнопка авторизации
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // проверка ввода
            if (!checkCorrectEnter()) return;
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // отправка SQL запроса
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userLogin AND `pass` = @userPass", db.getConnection());
            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@userPass", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            // обработка результатов запроса
            if (table.Rows.Count > 0)
            {
                this.Hide();
                _mainForm.Refresh(); 
                _mainForm.authentication.changeUserAutorized(true); // изменяем статус на авторизирован
                _mainForm.authentication.userLogin = loginUser; // устанавливаем логин
                _mainForm.MainForm_Load(sender, EventArgs.Empty);
               
            }                
            else
                MessageBox.Show("Ошибка, неверный логин или пароль");
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registor = new RegisterForm(_mainForm);
            registor.Show();

        }

        private bool checkCorrectEnter()
        {
                       
            if (string.IsNullOrWhiteSpace(loginField.Text))
            {
                MessageBox.Show("Введите логин");
                return false;
            }
            if (string.IsNullOrWhiteSpace(passField.Text))
            {
                MessageBox.Show("Введите пароль");
                return false;
            }
            return true;

        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (helpEnterLoginLabel.Visible)
            {
                helpEnterLoginLabel.Visible = false;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                helpEnterLoginLabel.Visible = true;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (helpEnterPasswordLabel.Visible)
            {
                helpEnterPasswordLabel.Visible = false;

            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                helpEnterPasswordLabel.Visible = true;
            }
        }

    }
}
