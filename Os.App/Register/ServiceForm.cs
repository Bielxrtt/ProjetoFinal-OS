using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Os.App.Base;
using Os.App.Infra;
using Os.App.ViewModel;
using Os.Domain.Base;

using ServiceEntity = Os.Domain.Entities.Services;
using Os.Service.Validators;

namespace Os.App.Register
{
    public partial class ServiceForm : BaseForm
    {
        private readonly IBaseService<ServiceEntity> _serviceService;
        private int _idCurrent = 0;

        public ServiceForm()
        {
            InitializeComponent();
            _serviceService = ConfigureDI.serviceProvider.GetService<IBaseService<ServiceEntity>>();

            ConfigurarEventos();
            CarregarGrid();
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
            try
            {
                
                string priceText = txtPrice.Text.Replace("R$", "").Trim();

                if (!decimal.TryParse(priceText, out decimal price))
                {
                    MessageBox.Show("Preço inválido.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtServiceName.Text))
                {
                    MessageBox.Show("O nome do serviço é obrigatório.");
                    return;
                }

                var serviceVM = new ServicesViewModel
                {
                    Id = _idCurrent,
                    TypeService = txtServiceName.Text,
                    Description = txtDescription.Text,
                    Price = price
                };

                if (_idCurrent > 0)
                {
                    _serviceService.Update<ServicesViewModel, ServicesViewModel, ServicesValidator>(serviceVM);
                    MessageBox.Show("Serviço atualizado!");
                }
                else
                {
                    _serviceService.Add<ServicesViewModel, ServicesViewModel, ServicesValidator>(serviceVM);
                    MessageBox.Show("Serviço cadastrado!");
                }

                LimparCampos();
                CarregarGrid();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Erro: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        private void CarregarGrid()
        {
            try
            {
                services = _serviceService.Get<ServicesViewModel>().ToList;
              
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].DataBoundItem as ServicesViewModel;
                if (item != null)
                {
                    _idCurrent = item.Id;
                    txtServiceName.Text = item.TypeService;
                    txtDescription.Text = item.Description;
                    txtPrice.Text = item.Price.ToString();
                    tabControlRegister.SelectedIndex = 0;
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && MessageBox.Show("Excluir?", "Confirma", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var item = dataGridView1.SelectedRows[0].DataBoundItem as ServicesViewModel;
                if (item != null)
                {
                    _serviceService.Delete(item.Id);
                    CarregarGrid();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LimparCampos();
            tabControlRegister.SelectedIndex = 1;
        }

        private void LimparCampos()
        {
            _idCurrent = 0;
            txtServiceName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
        }
    }
}