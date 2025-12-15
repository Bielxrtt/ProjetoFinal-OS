namespace Os.App.Register
{
    partial class ServiceOrderForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cboClient = new ReaLTaiizor.Controls.MaterialComboBox();
            cboDevice = new ReaLTaiizor.Controls.MaterialComboBox();
            cboStatus = new ReaLTaiizor.Controls.MaterialComboBox();
            cboServices = new ReaLTaiizor.Controls.MaterialComboBox();
            cboProducts = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNote = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            txtTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtProductQty = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnAddService = new ReaLTaiizor.Controls.MaterialButton();
            btnAddProduct = new ReaLTaiizor.Controls.MaterialButton();
            gridServices = new DataGridView();
            gridProducts = new DataGridView();
            grpServices = new GroupBox();
            grpProducts = new GroupBox();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridProducts).BeginInit();
            grpServices.SuspendLayout();
            grpProducts.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(cboClient);
            tabPageRegister.Controls.Add(cboDevice);
            tabPageRegister.Controls.Add(cboStatus);
            tabPageRegister.Controls.Add(grpServices);
            tabPageRegister.Controls.Add(grpProducts);
            tabPageRegister.Controls.Add(txtNote);
            tabPageRegister.Controls.Add(txtTotal);
            tabPageRegister.Controls.SetChildIndex(txtTotal, 0);
            tabPageRegister.Controls.SetChildIndex(txtNote, 0);
            tabPageRegister.Controls.SetChildIndex(grpProducts, 0);
            tabPageRegister.Controls.SetChildIndex(grpServices, 0);
            tabPageRegister.Controls.SetChildIndex(cboStatus, 0);
            tabPageRegister.Controls.SetChildIndex(cboDevice, 0);
            tabPageRegister.Controls.SetChildIndex(cboClient, 0);
            // 
            // cboClient
            // 
            cboClient.AutoResize = false;
            cboClient.BackColor = Color.FromArgb(255, 255, 255);
            cboClient.Depth = 0;
            cboClient.DrawMode = DrawMode.OwnerDrawVariable;
            cboClient.DropDownHeight = 174;
            cboClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClient.DropDownWidth = 121;
            cboClient.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboClient.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboClient.Hint = "Client";
            cboClient.IntegralHeight = false;
            cboClient.ItemHeight = 43;
            cboClient.Location = new Point(20, 20);
            cboClient.MaxDropDownItems = 4;
            cboClient.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboClient.Name = "cboClient";
            cboClient.Size = new Size(280, 49);
            cboClient.StartIndex = 0;
            cboClient.TabIndex = 3;
            // 
            // cboDevice
            // 
            cboDevice.AutoResize = false;
            cboDevice.BackColor = Color.FromArgb(255, 255, 255);
            cboDevice.Depth = 0;
            cboDevice.DrawMode = DrawMode.OwnerDrawVariable;
            cboDevice.DropDownHeight = 174;
            cboDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDevice.DropDownWidth = 121;
            cboDevice.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboDevice.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboDevice.Hint = "Device";
            cboDevice.IntegralHeight = false;
            cboDevice.ItemHeight = 43;
            cboDevice.Location = new Point(310, 20);
            cboDevice.MaxDropDownItems = 4;
            cboDevice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboDevice.Name = "cboDevice";
            cboDevice.Size = new Size(250, 49);
            cboDevice.StartIndex = 0;
            cboDevice.TabIndex = 4;
            // 
            // cboStatus
            // 
            cboStatus.AutoResize = false;
            cboStatus.BackColor = Color.FromArgb(255, 255, 255);
            cboStatus.Depth = 0;
            cboStatus.DrawMode = DrawMode.OwnerDrawVariable;
            cboStatus.DropDownHeight = 174;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.DropDownWidth = 121;
            cboStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboStatus.Hint = "Status";
            cboStatus.IntegralHeight = false;
            cboStatus.ItemHeight = 43;
            cboStatus.Location = new Point(580, 20);
            cboStatus.MaxDropDownItems = 4;
            cboStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(180, 49);
            cboStatus.StartIndex = 0;
            cboStatus.TabIndex = 5;
            // 
            // cboServices
            // 
            cboServices.AutoResize = false;
            cboServices.BackColor = Color.FromArgb(255, 255, 255);
            cboServices.Depth = 0;
            cboServices.DrawMode = DrawMode.OwnerDrawVariable;
            cboServices.DropDownHeight = 174;
            cboServices.DropDownStyle = ComboBoxStyle.DropDownList;
            cboServices.DropDownWidth = 121;
            cboServices.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboServices.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboServices.Hint = "Service";
            cboServices.IntegralHeight = false;
            cboServices.ItemHeight = 43;
            cboServices.Location = new Point(10, 30);
            cboServices.MaxDropDownItems = 4;
            cboServices.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboServices.Name = "cboServices";
            cboServices.Size = new Size(143, 49);
            cboServices.StartIndex = 0;
            cboServices.TabIndex = 0;
            // 
            // cboProducts
            // 
            cboProducts.AutoResize = false;
            cboProducts.BackColor = Color.FromArgb(255, 255, 255);
            cboProducts.Depth = 0;
            cboProducts.DrawMode = DrawMode.OwnerDrawVariable;
            cboProducts.DropDownHeight = 174;
            cboProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducts.DropDownWidth = 121;
            cboProducts.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboProducts.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboProducts.Hint = "Produto";
            cboProducts.IntegralHeight = false;
            cboProducts.ItemHeight = 43;
            cboProducts.Location = new Point(10, 30);
            cboProducts.MaxDropDownItems = 4;
            cboProducts.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboProducts.Name = "cboProducts";
            cboProducts.Size = new Size(113, 49);
            cboProducts.StartIndex = 0;
            cboProducts.TabIndex = 0;
            // 
            // txtNote
            // 
            txtNote.AnimateReadOnly = false;
            txtNote.BackgroundImageLayout = ImageLayout.None;
            txtNote.CharacterCasing = CharacterCasing.Normal;
            txtNote.Depth = 0;
            txtNote.HideSelection = true;
            txtNote.Hint = "Note";
            txtNote.Location = new Point(577, 89);
            txtNote.MaxLength = 32767;
            txtNote.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNote.Name = "txtNote";
            txtNote.PasswordChar = '\0';
            txtNote.ReadOnly = false;
            txtNote.ScrollBars = ScrollBars.None;
            txtNote.SelectedText = "";
            txtNote.SelectionLength = 0;
            txtNote.SelectionStart = 0;
            txtNote.ShortcutsEnabled = true;
            txtNote.Size = new Size(250, 70);
            txtNote.TabIndex = 8;
            txtNote.TabStop = false;
            txtNote.TextAlign = HorizontalAlignment.Left;
            txtNote.UseSystemPasswordChar = false;
            // 
            // txtTotal
            // 
            txtTotal.AnimateReadOnly = false;
            txtTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtTotal.BackgroundImageLayout = ImageLayout.None;
            txtTotal.CharacterCasing = CharacterCasing.Normal;
            txtTotal.Depth = 0;
            txtTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTotal.HideSelection = true;
            txtTotal.Hint = "TOTAL R$";
            txtTotal.LeadingIcon = null;
            txtTotal.Location = new Point(577, 170);
            txtTotal.MaxLength = 32767;
            txtTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotal.Name = "txtTotal";
            txtTotal.PasswordChar = '\0';
            txtTotal.PrefixSuffixText = null;
            txtTotal.ReadOnly = true;
            txtTotal.RightToLeft = RightToLeft.No;
            txtTotal.SelectedText = "";
            txtTotal.SelectionLength = 0;
            txtTotal.SelectionStart = 0;
            txtTotal.ShortcutsEnabled = true;
            txtTotal.Size = new Size(200, 48);
            txtTotal.TabIndex = 9;
            txtTotal.TabStop = false;
            txtTotal.Text = "0,00";
            txtTotal.TextAlign = HorizontalAlignment.Left;
            txtTotal.TrailingIcon = null;
            txtTotal.UseSystemPasswordChar = false;
            // 
            // txtProductQty
            // 
            txtProductQty.AnimateReadOnly = false;
            txtProductQty.AutoCompleteMode = AutoCompleteMode.None;
            txtProductQty.AutoCompleteSource = AutoCompleteSource.None;
            txtProductQty.BackgroundImageLayout = ImageLayout.None;
            txtProductQty.CharacterCasing = CharacterCasing.Normal;
            txtProductQty.Depth = 0;
            txtProductQty.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProductQty.HideSelection = true;
            txtProductQty.Hint = "Qtd";
            txtProductQty.LeadingIcon = null;
            txtProductQty.Location = new Point(140, 30);
            txtProductQty.MaxLength = 32767;
            txtProductQty.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtProductQty.Name = "txtProductQty";
            txtProductQty.PasswordChar = '\0';
            txtProductQty.PrefixSuffixText = null;
            txtProductQty.ReadOnly = false;
            txtProductQty.RightToLeft = RightToLeft.No;
            txtProductQty.SelectedText = "";
            txtProductQty.SelectionLength = 0;
            txtProductQty.SelectionStart = 0;
            txtProductQty.ShortcutsEnabled = true;
            txtProductQty.Size = new Size(60, 48);
            txtProductQty.TabIndex = 1;
            txtProductQty.TabStop = false;
            txtProductQty.Text = "1";
            txtProductQty.TextAlign = HorizontalAlignment.Left;
            txtProductQty.TrailingIcon = null;
            txtProductQty.UseSystemPasswordChar = false;
            // 
            // btnAddService
            // 
            btnAddService.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddService.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddService.Depth = 0;
            btnAddService.HighEmphasis = true;
            btnAddService.Icon = null;
            btnAddService.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAddService.Location = new Point(160, 35);
            btnAddService.Margin = new Padding(4, 6, 4, 6);
            btnAddService.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddService.Name = "btnAddService";
            btnAddService.NoAccentTextColor = Color.Empty;
            btnAddService.Size = new Size(64, 36);
            btnAddService.TabIndex = 1;
            btnAddService.Text = "ADD";
            btnAddService.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddService.UseAccentColor = false;
            // 
            // btnAddProduct
            // 
            btnAddProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddProduct.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddProduct.Depth = 0;
            btnAddProduct.HighEmphasis = true;
            btnAddProduct.Icon = null;
            btnAddProduct.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAddProduct.Location = new Point(207, 35);
            btnAddProduct.Margin = new Padding(4, 6, 4, 6);
            btnAddProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.NoAccentTextColor = Color.Empty;
            btnAddProduct.Size = new Size(64, 36);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "ADD";
            btnAddProduct.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddProduct.UseAccentColor = false;
            // 
            // gridServices
            // 
            gridServices.BackgroundColor = Color.White;
            gridServices.ColumnHeadersHeight = 29;
            gridServices.Location = new Point(10, 90);
            gridServices.Name = "gridServices";
            gridServices.RowHeadersWidth = 51;
            gridServices.Size = new Size(214, 120);
            gridServices.TabIndex = 2;
            // 
            // gridProducts
            // 
            gridProducts.BackgroundColor = Color.White;
            gridProducts.ColumnHeadersHeight = 29;
            gridProducts.Location = new Point(10, 90);
            gridProducts.Name = "gridProducts";
            gridProducts.RowHeadersWidth = 51;
            gridProducts.Size = new Size(261, 120);
            gridProducts.TabIndex = 3;
            // 
            // grpServices
            // 
            grpServices.Controls.Add(cboServices);
            grpServices.Controls.Add(btnAddService);
            grpServices.Controls.Add(gridServices);
            grpServices.Location = new Point(20, 80);
            grpServices.Name = "grpServices";
            grpServices.Size = new Size(235, 220);
            grpServices.TabIndex = 6;
            grpServices.TabStop = false;
            grpServices.Text = "Services";
            // 
            // grpProducts
            // 
            grpProducts.Controls.Add(cboProducts);
            grpProducts.Controls.Add(txtProductQty);
            grpProducts.Controls.Add(btnAddProduct);
            grpProducts.Controls.Add(gridProducts);
            grpProducts.Location = new Point(279, 80);
            grpProducts.Name = "grpProducts";
            grpProducts.Size = new Size(281, 220);
            grpProducts.TabIndex = 7;
            grpProducts.TabStop = false;
            grpProducts.Text = "Products";
            // 
            // ServiceOrderForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            ClientSize = new Size(857, 477);
            Location = new Point(0, 0);
            Name = "ServiceOrderForm";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridProducts).EndInit();
            grpServices.ResumeLayout(false);
            grpServices.PerformLayout();
            grpProducts.ResumeLayout(false);
            grpProducts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Declaração dos componentes
        private ReaLTaiizor.Controls.MaterialComboBox cboClient;
        private ReaLTaiizor.Controls.MaterialComboBox cboDevice;
        private ReaLTaiizor.Controls.MaterialComboBox cboStatus;

        private System.Windows.Forms.GroupBox grpServices;
        private ReaLTaiizor.Controls.MaterialComboBox cboServices;
        private ReaLTaiizor.Controls.MaterialButton btnAddService;
        private System.Windows.Forms.DataGridView gridServices;

        private System.Windows.Forms.GroupBox grpProducts;
        private ReaLTaiizor.Controls.MaterialComboBox cboProducts;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtProductQty;
        private ReaLTaiizor.Controls.MaterialButton btnAddProduct;
        private System.Windows.Forms.DataGridView gridProducts;

        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtNote;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotal;
    }
}