using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSeaBattleGame.Registration
{
    // Класс авторизации
    public class Authentication
    {
        private readonly MainForm _mainForm;
        public bool isUserAuthorized { get; set; } = false;
        public string userLogin { get; set; }

        public Authentication(MainForm mainForm)
        {
            _mainForm = mainForm;
        }
        // смена сатуса авторизации пользователя
        public void changeUserAutorized(bool decision)
        {
            this.isUserAuthorized = decision;
        }
    }
}