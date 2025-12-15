using Microsoft.Extensions.DependencyInjection;
using Os.App.Infra;
using Os.App.Register; // Para acessar as telas de cadastro
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
        }

        private void ConfigurarVisualizacaoUsuario()
        {
            // Verifica se tem alguém logado (segurança extra)
            if (Program.UsuarioLogado == null) return;

            // Exemplo: Se você tiver uma label chamada 'lblUsuario' no topo
            // lblUsuario.Text = $"Olá, {Program.UsuarioLogado.Name} ({Program.UsuarioLogado.AcessLevel})";

            // Opcional: Desabilitar botões visualmente se não for Admin
            // if (Program.UsuarioLogado.AcessLevel != "Administrador")
            // {
            //     btnUserSystem.Enabled = false; 
            // }
        }

        // --- Eventos dos Botões do Menu ---

        // Botão para abrir o Cadastro de Usuários (Apenas Admin)
        // Dê um duplo clique no botão de usuários no Designer para gerar este método
        private void btnUserSystem_Click(object sender, EventArgs e)
        {
            // 1. REGRA DE SEGURANÇA: Verifica se é Admin
            // O texto deve ser idêntico ao que está no banco ("Administrador" ou "Admin")
            if (Program.UsuarioLogado.AcessLevel != "Administrador" && Program.UsuarioLogado.AcessLevel != "Admin")
            {
                MessageBox.Show("Acesso Negado!\nApenas administradores podem acessar esta tela.",
                                "Segurança", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // 2. Abre a tela usando Injeção de Dependência
            var userForm = ConfigureDI.serviceProvider.GetRequiredService<UserSystemForm>();
            userForm.ShowDialog();
        }

        // Botão para abrir Clientes (Acesso liberado)
        private void btnCliente_Click(object sender, EventArgs e)
        {
            var clientForm = ConfigureDI.serviceProvider.GetRequiredService<ClientForm>();
            clientForm.ShowDialog();
        }

        // Botão para abrir Produtos
        private void btnProduto_Click(object sender, EventArgs e)
        {
            var productForm = ConfigureDI.serviceProvider.GetRequiredService<ProductForm>();
            productForm.ShowDialog();
        }

        // Botão para abrir Dispositivos
        private void btnDispositivo_Click(object sender, EventArgs e)
        {
            var deviceForm = ConfigureDI.serviceProvider.GetRequiredService<DeviceForm>();
            deviceForm.ShowDialog();
        }

        // Botão para Sair/Logoff
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}