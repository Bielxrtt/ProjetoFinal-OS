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
        
        public static UserSystem UsuarioLogado { get; set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ConfigureDI.ConfigureServices();

            
            var loginForm = ConfigureDI.serviceProvider.GetRequiredService<Login>();

            
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else
            {
                
                Application.Exit();
            }
        }
    }
}