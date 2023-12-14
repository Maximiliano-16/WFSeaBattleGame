using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFSeaBattleGame.Registration
{
    public partial class RegisterForm : Form
    {
        private readonly MainForm _mainForm;
        public RegisterForm()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Width, this.passPicture.Height);
        }

        public RegisterForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Width, this.passPicture.Height);
          
        }

        private void authPicture_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void nameField_Enter(object sender, EventArgs e)
        {
            if (helpEnterNameLabel.Visible)
            {
                helpEnterNameLabel.Visible = false;
            }
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {
                helpEnterNameLabel.Visible = true;
            }
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
        
        // проверка корректности ввода
        private bool checkCorrectEnter()
        {
            // если ничего не было введено или пробелы, то уведомляем пользователя
            if (string.IsNullOrWhiteSpace(nameField.Text))
            {
                MessageBox.Show("Введите имя");
                return false;
            }
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
        // Проверка на то, не занят ли логин 
        private bool isUserExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // SQL запрос для получения пользователя с введённым логином 
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userLogin", db.getConnection());
            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = loginField.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            // вывод уведомления, если логин занят
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Логин занят!");
                return true;
            }                
            else
                return false;
        }

        // кнопка регистрации
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!checkCorrectEnter()) return; // проверка на корректность ввода данных
            if (isUserExists()) return; // выход если такой пользователь уже есть
            DataBase db = new DataBase();
            // отправка SQL запроса
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`name`, `login`, `pass`) VALUES (@name, @login, @pass)", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;

            db.openConnection();
            // уведомление об операции
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт создаан!");
            else
                MessageBox.Show("Ошибка, аккаунт не был создан!");

            db.closeConnection();
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(_mainForm);
            loginForm.Show();
        }
    }
}
