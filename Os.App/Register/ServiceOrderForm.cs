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

        
        public void DefinirAba(int index)
        {
            if (tabControlRegister.TabCount > index)
            {
                tabControlRegister.SelectedIndex = index;
            }
        }
        

        private void ConfigurarEventos()
        {
            if (btnConfirm != null) btnConfirm.Click += (s, e) => SalvarOS();
            if (btnCancel != null) btnCancel.Click += (s, e) => Close();

            btnAddService.Click += BtnAddService_Click;
            btnAddProduct.Click += BtnAddProduct_Click;
            cboClient.SelectedIndexChanged += CboClient_SelectedIndexChanged;


            
            tabControlRegister.SelectedIndexChanged += (s, e) =>
            {
                if (tabControlRegister.SelectedIndex == 1) 
                {
                    CarregarGridPrincipal();
                }
            };
        }

        private void CarregarGridPrincipal()
        {
            try
            {
                // 1. Carrega todas as tabelas necessárias
                var includes = new List<string>
        {
            "Client",            // Traz o Cliente (para exibir o nome dele)
            "Device",            // Traz o Aparelho
            "Status",
            "User",
            "Services.Service",  // Traz os Serviços e seus nomes
            "Products.Product"   // Traz os Produtos e seus nomes
        };

                var listaOS = _osRepository.Select(includes);

                
                var gridData = listaOS.Select(x => new
                {
                    Id = x.Id,
                    Data = x.Date,
                    // O sinal ?. evita erro se o Cliente for nulo
                    Cliente = x.Client != null ? x.Client.Name : "Sem Cliente",
                    Aparelho = x.Device != null ? x.Device.Model : "Sem Aparelho",

                    // Exibe os serviços separados por vírgula
                    Servicos = x.Services != null
                        ? string.Join(", ", x.Services.Select(s => s.Service?.TypeService))
                        : "",

                    // Exibe os produtos separados por vírgula (Agora vai funcionar pois Product tem Name)
                    Produtos = x.Products != null
                        ? string.Join(", ", x.Products.Select(p => p.Product?.Name))
                        : "",

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
                
                var services = _servicesService.Get<Services>().ToList();
                cboServices.DataSource = services;
                cboServices.DisplayMember = "TypeService"; 
                cboServices.ValueMember = "Id";
                cboServices.SelectedIndex = -1;

               
                var products = _productService.Get<Product>().ToList();
                cboProducts.DataSource = products;
                cboProducts.DisplayMember = "Name";        
                cboProducts.ValueMember = "Id";
                cboProducts.SelectedIndex = -1;

                var clients = _clientService.Get<Client>().ToList();
                cboClient.DataSource = clients;
                cboClient.DisplayMember = "Name";
                cboClient.ValueMember = "Id_Client";
                cboClient.SelectedIndex = -1;




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar listas: {ex.Message}");
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
                    Date = DateTime.Now,
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

                LimparCampos();
                CarregarGridPrincipal();
                tabControlRegister.SelectedIndex = 1; 
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Erro: " + msg);
            }
        }

        private void LimparCampos()
        {
            _currentOS = new ServiceOrderViewModel();

            cboClient.SelectedIndex = -1;
            cboDevice.DataSource = null;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            cboServices.SelectedIndex = -1;
            cboProducts.SelectedIndex = -1;
            txtNote.Text = "";
            txtProductQty.Text = "1";

            AtualizarGridItens();
        }
    }
}