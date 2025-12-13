using Microsoft.Extensions.DependencyInjection;
using Os.App.Infra;
using Os.App.Others;
using Os.Domain.Entities; // Adicione isso
using ReaLTaiizor.Forms;

namespace Os.App
{
    public partial class MainForm : LostForm
    {
        // Propriedade para guardar o usuário logado
        public static UserSystem CurrentUser { get; set; }

        public MainForm()
        {
            InitializeComponent();
            CarregarPermissoes();
            LoginLoad();
        }

        private void CarregarPermissoes()
        {
            // Exemplo: Mostrar o nome no título ou em uma Label
            if (CurrentUser != null)
            {
                // Se tiver algum controle de Label, use: lblUsuario.Text = CurrentUser.Name;

                // Exemplo de controle de acesso:
                if (CurrentUser.AcessLevel != "Admin")
                {
                    // Esconder menus que só admin pode ver
                    // menuGerenciarUsuarios.Visible = false;
                }
            }
        }

        private void LoginLoad()
        {
            var login = ConfigureDI.serviceProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }

            }
        }

    }
}