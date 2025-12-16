using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Os.App.Base;
using Os.App.Infra;
using Os.App.ViewModel;
using Os.Domain.Base;
using Os.Domain.Entities;
using Os.Service.Validators;

namespace Os.App.Register
{
    public partial class ClientForm : BaseForm
    {
        private readonly IBaseService<Client> _clientService;
        private int _idCurrent = 0;

        public ClientForm()
        {
            InitializeComponent();
            _clientService = ConfigureDI.serviceProvider.GetService<IBaseService<Client>>();

            ConfigurarEventos();
            
        }

        private void ConfigurarEventos()
        {
            
            if (btnConfirm != null) btnConfirm.Click += BtnConfirm_Click;
            if (btnCancel != null) btnCancel.Click += BtnCancel_Click;
            if (btnDelete != null) btnDelete.Click += BtnDelete_Click;
            if (btnEdit != null) btnEdit.Click += BtnEdit_Click;

           
           

           
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LimparCampos();
            
        }

        private void BtnDevice_Click(object sender, EventArgs e)
        {
            if (_idCurrent == 0)
            {
                MessageBox.Show("Salve ou selecione um cliente antes.");
                return;
            }

            var deviceForm = ConfigureDI.serviceProvider.GetRequiredService<DeviceForm>();
            deviceForm.SetClientePreSelecionado(_idCurrent);
            deviceForm.ShowDialog();
        }

        private void Salvar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtClientName.Text))
                {
                    MessageBox.Show("O nome é obrigatório!");
                    return;
                }

                var clientVM = new ClientViewModel
                {
                    Id_Client = _idCurrent,
                    Name = txtClientName.Text,
                    Phone = txtClientPhone.Text,
                    Email = txtEmail.Text,
                    Adress = txtAdress.Text,
                    Register_Date = DateTime.Now,
                    IdDevice = null
                };

                if (_idCurrent > 0)
                {
                    _clientService.Update<ClientViewModel, ClientViewModel, ClientValidator>(clientVM);
                    MessageBox.Show("Cliente atualizado!");
                }
                else
                {
                    var novo = _clientService.Add<ClientViewModel, ClientViewModel, ClientValidator>(clientVM);
                    MessageBox.Show("Cliente cadastrado!");
                    if (novo != null) _idCurrent = novo.Id_Client;
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        protected override void CarregarGrid()
        {
            try
            {
                var list = _clientService.Get<ClientViewModel>();

                
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;

                
                if (dataGridView1.Columns["IdDevice"] != null) dataGridView1.Columns["IdDevice"].Visible = false;
                if (dataGridView1.Columns["Device"] != null) dataGridView1.Columns["Device"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista: " + ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].DataBoundItem as ClientViewModel;
                if (item != null)
                {
                    _idCurrent = item.Id_Client;
                    txtClientName.Text = item.Name;
                    txtClientPhone.Text = item.Phone;
                    txtEmail.Text = item.Email;
                    txtAdress.Text = item.Adress;
                    tabControlRegister.SelectedIndex = 0;
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Excluir?", "Confirma", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var item = dataGridView1.SelectedRows[0].DataBoundItem as ClientViewModel;
                    if (item != null)
                    {
                        _clientService.Delete(item.Id_Client);
                        CarregarGrid();
                    }
                }
            }
        }

        private void LimparCampos()
        {
            _idCurrent = 0;
            txtClientName.Text = "";
            txtClientPhone.Text = "";
            txtEmail.Text = "";
            txtAdress.Text = "";
        }
    }
}