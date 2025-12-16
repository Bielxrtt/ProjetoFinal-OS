using System;
using System.Windows.Forms;
using ReaLTaiizor.Forms;

namespace Os.App.Base
{
    public partial class BaseForm : LostForm
    {
        public BaseForm()
        {
            InitializeComponent();
            ConfigurarBotoesBase();
        }

        private void ConfigurarBotoesBase()
        {
            
            if (btnConsult != null)
            {
                btnConsult.Click += (s, e) =>
                {
                    CarregarGrid(); 
                    tabControlRegister.SelectedIndex = 1; 
                };
            }

            
            tabControlRegister.SelectedIndexChanged += (s, e) =>
            {
                if (tabControlRegister.SelectedIndex == 1)
                {
                    CarregarGrid();
                }
            };
        }

        
        protected virtual void CarregarGrid()
        {
           
        }

        
        protected virtual void btnDelete_Click(object sender, EventArgs e) { }
        protected virtual void btnEdit_Click(object sender, EventArgs e) { }
        protected virtual void btnSave_Click(object sender, EventArgs e) { }
    }
}