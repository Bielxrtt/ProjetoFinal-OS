using Os.App.Infra;
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
    }
}