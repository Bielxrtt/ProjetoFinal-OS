using Microsoft.Extensions.DependencyInjection;
using Os.App.Infra;
using Os.App.Register;
using Os.App.Others;
using Os.Domain.Entities;
using ReaLTaiizor.Forms;
using System;
using System.Windows.Forms;

namespace Os.App
{
    public partial class MainForm : LostForm
    {
        public MainForm()
        {
            InitializeComponent();
            ConfigurarVisualizacaoUsuario();
            ConfigurarEventosMenu();
        }

        private void ConfigurarEventosMenu()
        {
            
            clientToolStripMenuItem.Click += btnCliente_Click;
            userEmployeeToolStripMenuItem.Click += btnUserSystem_Click;
            productToolStripMenuItem.Click += btnProduto_Click;
            serviceToolStripMenuItem.Click += btnServico_Click;
            statusToolStripMenuItem.Click += btnStatus_Click;

            deviceToolStripMenuItem.Click += btnDispositivo_Click;

            newOsToolStripMenuItem.Click += btnNewOs_Click;       
            manageOsToolStripMenuItem.Click += btnManageOs_Click; 
        }

        private void ConfigurarVisualizacaoUsuario()
        {
            if (Program.UsuarioLogado == null) return;
        }

        

        private void btnNewOs_Click(object sender, EventArgs e)
        {
            // Abre o formulário na aba 0 (Cadastro)
            var osForm = ConfigureDI.serviceProvider.GetRequiredService<ServiceOrderForm>();
            osForm.DefinirAba(0);
            osForm.ShowDialog();
        }

        private void btnManageOs_Click(object sender, EventArgs e)
        {
            
            var osForm = ConfigureDI.serviceProvider.GetRequiredService<ServiceOrderForm>();
            osForm.DefinirAba(1);
            osForm.ShowDialog();
        }

        private void btnDispositivo_Click(object sender, EventArgs e) 
        {
            var deviceForm = ConfigureDI.serviceProvider.GetRequiredService<DeviceForm>();
            deviceForm.ShowDialog();
        }

        private void btnUserSystem_Click(object sender, EventArgs e)
        {
            if (Program.UsuarioLogado.AcessLevel != "Administrador" && Program.UsuarioLogado.AcessLevel != "Admin")
            {
                MessageBox.Show("Acesso Negado!\nApenas administradores podem acessar esta tela.",
                                "Segurança", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            var userForm = ConfigureDI.serviceProvider.GetRequiredService<UserSystemForm>();
            userForm.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var clientForm = ConfigureDI.serviceProvider.GetRequiredService<ClientForm>();
            clientForm.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            
            var productForm = ConfigureDI.serviceProvider.GetRequiredService<ProductForm>();
            productForm.ShowDialog();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            var serviceForm = ConfigureDI.serviceProvider.GetRequiredService<ServiceForm>();
            serviceForm.ShowDialog();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            var statusForm = ConfigureDI.serviceProvider.GetRequiredService<StatusForm>();
            statusForm.ShowDialog();
        }

        

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}