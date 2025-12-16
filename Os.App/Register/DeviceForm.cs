
using Microsoft.Extensions.DependencyInjection;
using Os.App.Base;
using Os.App.Infra;
using Os.App.ViewModel;
using Os.Domain.Base;
using Os.Domain.Entities;
using Os.Domain.Enum;
using Os.Service.Validators;

namespace Os.App.Register
{
    public partial class DeviceForm : BaseForm
    {
        private readonly IBaseService<Device> _deviceService;
        private readonly IBaseService<Client> _clientService;
        private int _idCurrent = 0;

        public DeviceForm()
        {
            InitializeComponent();

            _deviceService = ConfigureDI.serviceProvider.GetService<IBaseService<Device>>();
            _clientService = ConfigureDI.serviceProvider.GetService<IBaseService<Client>>();

            CarregarClientes();
            CarregarBrands();
            CarregarGrid(); 
            ConfigurarEventos();
        }

        
        public void SetClientePreSelecionado(int idCliente)
        {
            if (cboClient.Items.Count > 0)
            {
                
                cboClient.SelectedValue = idCliente;

                
                if (cboClient.SelectedIndex == -1)
                {
                    foreach (var item in cboClient.Items)
                    {
                      
                        if (item is ClientViewModel client && client.Id_Client == idCliente)
                        {
                            cboClient.SelectedItem = item;
                            break;
                        }
                    }
                }

               
            }
        }

        private void ConfigurarEventos()
        {
            if (btnConfirm != null) btnConfirm.Click += BtnConfirm_Click;
            if (btnCancel != null) btnCancel.Click += BtnCancel_Click;
            if (btnDelete != null) btnDelete.Click += BtnDelete_Click;
            if (btnEdit != null) btnEdit.Click += BtnEdit_Click;
        }

        private void CarregarClientes()
        {
            try
            {
                var clients = _clientService.Get<Client>().ToList();
                cboClient.DataSource = clients;
                cboClient.DisplayMember = "Name";
                cboClient.ValueMember = "Id_Client";
                cboClient.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        private void CarregarBrands()
        {
            cboBrand.DataSource = Enum.GetValues(typeof(TypeBrand));
            cboBrand.SelectedIndex = -1;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            if (cboClient.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }

            if (cboBrand.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma marca.");
                return;
            }

            try
            {
                TypeBrand selectedBrand;
                Enum.TryParse(cboBrand.SelectedValue.ToString(), out selectedBrand);

                var deviceVM = new DeviceViewModel
                {
                    Id = _idCurrent,
                    Id_Client = (int)cboClient.SelectedValue,
                    TypeBrand = selectedBrand,
                    Model = txtModel.Text,
                    Type = txtType.Text,
                    IMEI = txtIMEI.Text
                };

                if (_idCurrent > 0)
                {
                    _deviceService.Update<DeviceViewModel, DeviceViewModel, DeviceValidator>(deviceVM);
                    MessageBox.Show("Dispositivo atualizado!");
                }
                else
                {
                    _deviceService.Add<DeviceViewModel, DeviceViewModel, DeviceValidator>(deviceVM);
                    MessageBox.Show("Dispositivo cadastrado!");
                }

                LimparCampos();
                CarregarGrid();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}");
            }
        }

        
        protected override void CarregarGrid()
        {
            try
            {
                var devices = _deviceService.Get<DeviceViewModel>(new List<string> { "Client" });
                dataGridView1.DataSource = devices;

                if (dataGridView1.Columns["Id_Client"] != null) dataGridView1.Columns["Id_Client"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].DataBoundItem as DeviceViewModel;
                if (item != null)
                {
                    _idCurrent = item.Id;
                    cboClient.SelectedValue = item.Id_Client;
                    cboBrand.SelectedItem = item.TypeBrand;
                    txtModel.Text = item.Model;
                    txtType.Text = item.Type;
                    txtIMEI.Text = item.IMEI;
                    tabControlRegister.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Selecione um item na lista.");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Excluir dispositivo?", "Confirma", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var item = dataGridView1.SelectedRows[0].DataBoundItem as DeviceViewModel;
                    if (item != null)
                    {
                        _deviceService.Delete(item.Id);
                        CarregarGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um item na lista.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            _idCurrent = 0;
            cboClient.SelectedIndex = -1;
            cboBrand.SelectedIndex = -1;
            txtModel.Text = "";
            txtType.Text = "";
            txtIMEI.Text = "";
        }
    }
}