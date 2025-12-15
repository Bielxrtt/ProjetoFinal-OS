using Microsoft.Extensions.DependencyInjection;
using Os.App.Infra;
using Os.App.Others;
using Os.Domain.Entities;
using System;
using System.Windows.Forms;

namespace Os.App
{
    internal static class Program
    {
        // Sessão global do usuário
        public static UserSystem UsuarioLogado { get; set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Configura os serviços (Banco, AutoMapper, Forms)
            ConfigureDI.ConfigureServices();

            // 2. Pega o formulário de Login já com as dependências injetadas
            var loginForm = ConfigureDI.serviceProvider.GetRequiredService<Login>();

            // 3. Exibe o Login. O MainForm só abre se o resultado for OK.
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else
            {
                // Se o usuário fechar o login sem entrar, o app morre aqui.
                Application.Exit();
            }
        }
    }
}