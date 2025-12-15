using System;
using System.Collections.Generic;
using System.Linq;
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
    public partial class ServiceOrderForm : BaseForm
    {
        private readonly IBaseService<Client> _clientService;
        private readonly IBaseService<Device> _deviceService;
        private readonly IBaseService<Os.Domain.Entities.Services> _servicesService;
        private readonly IBaseService<Product> _productService;
        private readonly IBaseService<Status> _statusService;
        private readonly IBaseRepository<ServiceOrder> _osRepository;

        private ServiceOrderViewModel _currentOS;

        public ServiceOrderForm()
        {
            InitializeComponent();

            var provider = ConfigureDI.serviceProvider;
            _clientService = provider.GetService<IBaseService<Client>>();
            _deviceService = provider.GetService<IBaseService<Device>>();
            _servicesService = provider.GetService<IBaseService<Os.Domain.Entities.Services>>();
            _productService = provider.GetService<IBaseService<Product>>();
            _statusService = provider.GetService<IBaseService<Status>>();
            _osRepository = provider.GetService<IBaseRepository<ServiceOrder>>();

            _currentOS = new ServiceOrderViewModel();

            CarregarCombos();
            CarregarGridPrincipal(); 
            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            if (btnConfirm != null) btnConfirm.Click += (s, e) => SalvarOS();
            if (btnCancel != null) btnCancel.Click += (s, e) => Close();

            btnAddService.Click += BtnAddService_Click;
            btnAddProduct.Click += BtnAddProduct_Click;
            cboClient.SelectedIndexChanged += CboClient_SelectedIndexChanged;

            // Evento para recarregar a lista se o usuário clicar na aba "List" manualmente
            tabControlRegister.SelectedIndexChanged += (s, e) =>
            {
                if (tabControlRegister.SelectedIndex == 1) // Aba 1 é a Lista
                {
                    CarregarGridPrincipal();
                }
            };
        }

        private void CarregarGridPrincipal()
        {
            try
            {
                // Busca as OSs incluindo os relacionamentos para mostrar os nomes
                var includes = new List<string> { "Client", "Device", "Status", "User" };
                var listaOS = _osRepository.Select(includes);

                // Mapeamento rápido para mostrar na Grid (Anonymous Object ou ViewModel)
                var gridData = listaOS.Select(x => new
                {
                    Id = x.Id,
                    Data = x.StartDate,
                    Cliente = x.Client?.Name,
                    Aparelho = x.Device?.Model,
                    Status = x.Status?.Name,
                    Total = x.Price.ToString("C2")
                }).OrderByDescending(x => x.Id).ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = gridData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista de OS: " + ex.Message);
            }
        }

        private void CarregarCombos()
        {
            try
            {
                cboClient.DataSource = _clientService.Get<ClientViewModel>().ToList();
                cboClient.DisplayMember = "Name";
                cboClient.ValueMember = "Id_Client";
                cboClient.SelectedIndex = -1;

                cboStatus.DataSource = _statusService.Get<StatusViewModel>().ToList();
                cboStatus.DisplayMember = "Name";
                cboStatus.ValueMember = "Id";
                if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;

                cboServices.DataSource = _servicesService.Get<ServicesViewModel>().ToList();
                cboServices.DisplayMember = "TypeService";
                cboServices.ValueMember = "Id";
                cboServices.SelectedIndex = -1;

                cboProducts.DataSource = _productService.Get<ProductViewModel>().ToList();
                cboProducts.DisplayMember = "Name";
                cboProducts.ValueMember = "Id";
                cboProducts.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void CboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDevice.DataSource = null;
            if (cboClient.SelectedValue != null && int.TryParse(cboClient.SelectedValue.ToString(), out int clientId))
            {
                var allDevices = _deviceService.Get<DeviceViewModel>();
                var userDevices = allDevices.Where(d => d.Id_Client == clientId).ToList();

                cboDevice.DataSource = userDevices;
                cboDevice.DisplayMember = "Model";
                cboDevice.ValueMember = "IdDevice";
                cboDevice.SelectedIndex = -1;
            }
        }

        private void BtnAddService_Click(object sender, EventArgs e)
        {
            var item = (ServicesViewModel)cboServices.SelectedItem;
            if (item == null) return;

            _currentOS.Services.Add(new ServiceOrderItemVM
            {
                IdService = item.Id,
                Description = item.TypeService,
                Price = item.Price
            });
            AtualizarGridItens();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            var item = (ProductViewModel)cboProducts.SelectedItem;
            if (item == null) return;

            if (float.TryParse(txtProductQty.Text, out float qty))
            {
                _currentOS.Products.Add(new ProductOrderItemVM
                {
                    IdProduct = item.Id,
                    Description = item.Name,
                    Price = item.Price,
                    Quantity = qty
                });
                AtualizarGridItens();
                txtProductQty.Text = "1";
            }
            else
            {
                MessageBox.Show("Qtd inválida");
            }
        }

        private void AtualizarGridItens()
        {
            gridServices.DataSource = null;
            gridServices.DataSource = _currentOS.Services;

            gridProducts.DataSource = null;
            gridProducts.DataSource = _currentOS.Products;

            if (gridServices.Columns["IdService"] != null) gridServices.Columns["IdService"].Visible = false;
            if (gridProducts.Columns["IdProduct"] != null) gridProducts.Columns["IdProduct"].Visible = false;

            decimal total = _currentOS.Services.Sum(s => s.Price) + _currentOS.Products.Sum(p => p.Total);
            _currentOS.TotalPrice = total;
            txtTotal.Text = total.ToString("C2");
        }

        private void SalvarOS()
        {
            if (cboClient.SelectedIndex == -1 || cboDevice.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha Cliente e Dispositivo");
                return;
            }

            try
            {
                var os = new ServiceOrder
                {
                    IdClient = (int)cboClient.SelectedValue,
                    IdDevice = (int)cboDevice.SelectedValue,
                    IdStatus = (int?)cboStatus.SelectedValue ?? 1,
                    UserId = Program.UsuarioLogado?.Id ?? 1,
                    StartDate = DateTime.Now,
                    Note = txtNote.Text,
                    Price = _currentOS.TotalPrice,

                    Services = _currentOS.Services.Select(s => new ServiceOrder_has_Service
                    {
                        ServiceId = s.IdService,
                        Price = s.Price
                    }).ToList(),

                    Products = _currentOS.Products.Select(p => new Products_has_ServiceOrder
                    {
                        ProductId = p.IdProduct,
                        Price = p.Price,
                        Quantity = p.Quantity
                    }).ToList()
                };

                _osRepository.Insert(os);

                MessageBox.Show($"OS {os.Id} Salva com Sucesso!");

                // --- FLUXO DE CONSULTA ---
                LimparCampos();          // 1. Limpa o formulário para uma nova
                CarregarGridPrincipal(); // 2. Atualiza a lista com a nova OS
                tabControlRegister.SelectedIndex = 1; // 3. Vai para a aba de Lista automaticamente
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Erro: " + msg);
            }
        }

        private void LimparCampos()
        {
            // Reseta a ViewModel da OS atual
            _currentOS = new ServiceOrderViewModel();

            // Limpa controles visuais
            cboClient.SelectedIndex = -1;
            cboDevice.DataSource = null; // Limpa pois depende do cliente
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            cboServices.SelectedIndex = -1;
            cboProducts.SelectedIndex = -1;
            txtNote.Text = "";
            txtProductQty.Text = "1";

            // Limpa grids visuais de itens
            AtualizarGridItens();
        }
    }
}