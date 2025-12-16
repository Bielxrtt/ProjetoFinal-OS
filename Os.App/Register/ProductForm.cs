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
    public partial class ProductForm : BaseForm
    {
        private readonly IBaseService<Product> _productService;
        private int _idCurrent = 0;

        public ProductForm()
        {
            InitializeComponent();
            _productService = ConfigureDI.serviceProvider.GetService<IBaseService<Product>>();

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
            {
                try
                {
                    // 1. Validação do Nome
                    if (string.IsNullOrWhiteSpace(txtNameProduct.Text)) // Seu campo se chama txtNameProduct
                    {
                        MessageBox.Show("Nome do produto é obrigatório.");
                        return;
                    }

                    // 2. Validação do Preço
                    if (!decimal.TryParse(txtPrice.Text, out decimal price))
                    {
                        MessageBox.Show("Preço inválido.");
                        return;
                    }

                    // 3. Validação da Quantidade
                    if (!float.TryParse(txtQuantity.Text, out float quantity))
                    {
                        quantity = 0;
                    }

                    // 4. Criação do Objeto (ViewModel) para salvar
                    var productVM = new ProductViewModel
                    {
                        Id = _idCurrent, // _idCurrent controla se é edição ou novo
                        Name = txtNameProduct.Text, // Pega o texto da caixinha
                        Price = price,
                        Quantity = quantity
                    };

                    // 5. Chamada ao Serviço para Salvar no Banco
                    if (_idCurrent > 0)
                    {
                        _productService.Update<ProductViewModel, ProductViewModel, ProductValidator>(productVM);
                        MessageBox.Show("Produto atualizado!");
                    }
                    else
                    {
                        _productService.Add<ProductViewModel, ProductViewModel, ProductValidator>(productVM);
                        MessageBox.Show("Produto cadastrado!");
                    }

                    LimparCampos();
                    CarregarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar: {ex.Message}");
                }
            }
        }

        protected override void CarregarGrid()
        {
            try
            {
                var list = _productService.Get<ProductViewModel>();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].DataBoundItem as ProductViewModel;
                if (item != null)
                {
                    _idCurrent = item.Id;
                    
                    txtNameProduct.Text = item.Name;
                    txtPrice.Text = item.Price.ToString();
                    txtQuantity.Text = item.Quantity.ToString();

                   

                    tabControlRegister.SelectedIndex = 0;
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Excluir produto?", "Confirma", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var item = dataGridView1.SelectedRows[0].DataBoundItem as ProductViewModel;
                    if (item != null)
                    {
                        _productService.Delete(item.Id);
                        CarregarGrid();
                    }
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            _idCurrent = 0;
            txtNameProduct.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }
    }
}