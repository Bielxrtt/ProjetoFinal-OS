using Os.Domain.Base;
using Os.Domain.Entities;
using Os.Service.Validators;
using ReaLTaiizor.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
// Adicione este using para acessar a classe Program
using Os.App;

namespace Os.App.Others
{
    public partial class Login : LostForm
    {
        private readonly IBaseService<UserSystem> _userService;
        private readonly IBaseService<Status> _statusService; // Adicionei para garantir que o Status exista

        // Construtor ÚNICO e com Injeção de Dependência
        // Adicionei o serviço de Status também
        public Login(IBaseService<UserSystem> userService, IBaseService<Status> statusService)
        {
            _userService = userService;
            _statusService = statusService;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica e cria o Admin padrão se o banco estiver vazio
                CheckUserExistence();

                // Busca o usuário
                UserSystem user = GetUser(txtLogin.Text, txtPassword.Text);

                if (user == null)
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verifica se está inativo
                // Nota: O método Get<UserSystem> precisa trazer o Status junto (Include) no Repositório,
                // ou verificamos apenas pelo IdStatus se o objeto Status vier nulo.
                if (user.Status != null && user.Status.Name == "Inativo")
                {
                    MessageBox.Show("Usuário inativo. Contate o suporte.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // SUCESSO: Salva na Sessão Global definida no Program.cs
                Program.UsuarioLogado = user;

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
            // Fecha a aplicação completamente
            Application.Exit();
        }

        private UserSystem GetUser(string login, string password)
        {
            // Busca usuários com a tabela de Status carregada (se o seu repositório suportar Includes genéricos)
            // Se não suportar, trará apenas os dados do usuário, o que serve para o login.
            var users = _userService.Get<UserSystem>(new System.Collections.Generic.List<string> { "Status" });

            // Validação simples (Idealmente usar Hash na senha)
            return users.FirstOrDefault(x => x.Login == login && x.Password == password);
        }

        private void CheckUserExistence()
        {
            try
            {
                var users = _userService.Get<UserSystem>().ToList();

                // Se não existe NENHUM usuário, cria o Admin padrão
                if (!users.Any())
                {
                    // 1. Garante que existe um Status "Ativo" primeiro
                    var statusList = _statusService.Get<Status>().ToList();
                    int idStatusAtivo = 1;

                    if (!statusList.Any())
                    {
                        var novoStatus = new Status { Name = "Ativo", Description = "Usuário ativo no sistema" };
                        var statusSalvo = _statusService.Add<Status, Status, StatusValidator>(novoStatus);
                        idStatusAtivo = statusSalvo.Id; // Pega o ID gerado
                    }
                    else
                    {
                        idStatusAtivo = statusList.First().Id;
                    }

                    // 2. Cria o Admin
                    var admin = new UserSystem
                    {
                        Name = "Administrador",
                        Login = "admin",
                        Password = "admin",
                        AcessLevel = "Administrador", // Use "Administrador" ou "Admin" (mantenha o padrão do MainForm)
                        IdStatus = idStatusAtivo,
                    };

                    _userService.Add<UserSystem, UserSystem, UserSystemValidator>(admin);
                }
            }
            catch (Exception ex)
            {
                // Apenas loga ou ignora silenciosamente na tela de login para não assustar o usuário,
                // a menos que seja crítico.
                Console.WriteLine("Erro ao verificar admin padrão: " + ex.Message);
            }
        }
    }
}