using Os.Domain.Base;
using Os.Domain.Entities;
using Os.Service.Validators; 
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Os.App.Others
{
    public partial class Login : LostForm
    {
       
        private readonly IBaseService<UserSystem> _userService;

        
        public Login(IBaseService<UserSystem> userService)
        {
            _userService = userService;
            InitializeComponent();
        }

         
        
        public Login() { InitializeComponent(); }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                
                UserSystem user = GetUser(txtLogin.Text, txtPassword.Text);

                if (user == null)
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                if (user.Status != null && user.Status.Name == "Inativo")
                {
                    MessageBox.Show("Usuário inativo. Contate o suporte.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MainForm.CurrentUser = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar logar: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private UserSystem GetUser(string login, string password)
        {
            CheckUserExistence();

            
            var users = _userService.Get<UserSystem>();

            var user = users.FirstOrDefault(x => x.Login == login && x.Password == password);

            return user;
        }

        private void CheckUserExistence()
        {
            
            var users = _userService.Get<UserSystem>().ToList();
            if (!users.Any())
            {
                var admin = new UserSystem
                {
                    Name = "Administrador",
                    Login = "admin",
                    Password = "admin", 
                    AcessLevel = "Admin",
                    IdStatus = 1, 
                };

                
                _userService.Add<UserSystem, UserSystem, UserSystemValidator>(admin);
            }
        }
    }
}