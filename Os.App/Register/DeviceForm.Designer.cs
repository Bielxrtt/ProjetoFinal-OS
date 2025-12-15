namespace Os.App.Register
{
    partial class DeviceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboClient = new ReaLTaiizor.Controls.MaterialComboBox();
            cboBrand = new ReaLTaiizor.Controls.MaterialComboBox();
            txtModel = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtType = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIMEI = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(857, 441);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtIMEI);
            tabPageRegister.Controls.Add(txtType);
            tabPageRegister.Controls.Add(txtModel);
            tabPageRegister.Controls.Add(cboBrand);
            tabPageRegister.Controls.Add(cboClient);
            tabPageRegister.Size = new Size(849, 400);
            tabPageRegister.Controls.SetChildIndex(cboClient, 0);
            tabPageRegister.Controls.SetChildIndex(cboBrand, 0);
            tabPageRegister.Controls.SetChildIndex(txtModel, 0);
            tabPageRegister.Controls.SetChildIndex(txtType, 0);
            tabPageRegister.Controls.SetChildIndex(txtIMEI, 0);
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
            cboClient.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboClient.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboClient.FormattingEnabled = true;
            cboClient.Hint = "Client";
            cboClient.IntegralHeight = false;
            cboClient.ItemHeight = 43;
            cboClient.Location = new Point(28, 33);
            cboClient.MaxDropDownItems = 4;
            cboClient.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboClient.Name = "cboClient";
            cboClient.Size = new Size(191, 49);
            cboClient.StartIndex = 0;
            cboClient.TabIndex = 3;
            // 
            // cboBrand
            // 
            cboBrand.AutoResize = false;
            cboBrand.BackColor = Color.FromArgb(255, 255, 255);
            cboBrand.Depth = 0;
            cboBrand.DrawMode = DrawMode.OwnerDrawVariable;
            cboBrand.DropDownHeight = 174;
            cboBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBrand.DropDownWidth = 121;
            cboBrand.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboBrand.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboBrand.FormattingEnabled = true;
            cboBrand.Hint = "Brand";
            cboBrand.IntegralHeight = false;
            cboBrand.ItemHeight = 43;
            cboBrand.Location = new Point(27, 103);
            cboBrand.MaxDropDownItems = 4;
            cboBrand.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboBrand.Name = "cboBrand";
            cboBrand.Size = new Size(193, 49);
            cboBrand.StartIndex = 0;
            cboBrand.TabIndex = 4;
            // 
            // txtModel
            // 
            txtModel.AnimateReadOnly = false;
            txtModel.AutoCompleteMode = AutoCompleteMode.None;
            txtModel.AutoCompleteSource = AutoCompleteSource.None;
            txtModel.BackgroundImageLayout = ImageLayout.None;
            txtModel.CharacterCasing = CharacterCasing.Normal;
            txtModel.Depth = 0;
            txtModel.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModel.HideSelection = true;
            txtModel.Hint = "Model";
            txtModel.LeadingIcon = null;
            txtModel.Location = new Point(27, 172);
            txtModel.MaxLength = 32767;
            txtModel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtModel.Name = "txtModel";
            txtModel.PasswordChar = '\0';
            txtModel.PrefixSuffixText = null;
            txtModel.ReadOnly = false;
            txtModel.RightToLeft = RightToLeft.No;
            txtModel.SelectedText = "";
            txtModel.SelectionLength = 0;
            txtModel.SelectionStart = 0;
            txtModel.ShortcutsEnabled = true;
            txtModel.Size = new Size(192, 48);
            txtModel.TabIndex = 5;
            txtModel.TabStop = false;
            txtModel.TextAlign = HorizontalAlignment.Left;
            txtModel.TrailingIcon = null;
            txtModel.UseSystemPasswordChar = false;
            // 
            // txtType
            // 
            txtType.AnimateReadOnly = false;
            txtType.AutoCompleteMode = AutoCompleteMode.None;
            txtType.AutoCompleteSource = AutoCompleteSource.None;
            txtType.BackgroundImageLayout = ImageLayout.None;
            txtType.CharacterCasing = CharacterCasing.Normal;
            txtType.Depth = 0;
            txtType.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtType.HideSelection = true;
            txtType.Hint = "Type";
            txtType.LeadingIcon = null;
            txtType.Location = new Point(274, 172);
            txtType.MaxLength = 32767;
            txtType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtType.Name = "txtType";
            txtType.PasswordChar = '\0';
            txtType.PrefixSuffixText = null;
            txtType.ReadOnly = false;
            txtType.RightToLeft = RightToLeft.No;
            txtType.SelectedText = "";
            txtType.SelectionLength = 0;
            txtType.SelectionStart = 0;
            txtType.ShortcutsEnabled = true;
            txtType.Size = new Size(179, 48);
            txtType.TabIndex = 6;
            txtType.TabStop = false;
            txtType.TextAlign = HorizontalAlignment.Left;
            txtType.TrailingIcon = null;
            txtType.UseSystemPasswordChar = false;
            // 
            // txtIMEI
            // 
            txtIMEI.AnimateReadOnly = false;
            txtIMEI.AutoCompleteMode = AutoCompleteMode.None;
            txtIMEI.AutoCompleteSource = AutoCompleteSource.None;
            txtIMEI.BackgroundImageLayout = ImageLayout.None;
            txtIMEI.CharacterCasing = CharacterCasing.Normal;
            txtIMEI.Depth = 0;
            txtIMEI.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIMEI.HideSelection = true;
            txtIMEI.Hint = "IMEI";
            txtIMEI.LeadingIcon = null;
            txtIMEI.Location = new Point(27, 237);
            txtIMEI.MaxLength = 32767;
            txtIMEI.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtIMEI.Name = "txtIMEI";
            txtIMEI.PasswordChar = '\0';
            txtIMEI.PrefixSuffixText = null;
            txtIMEI.ReadOnly = false;
            txtIMEI.RightToLeft = RightToLeft.No;
            txtIMEI.SelectedText = "";
            txtIMEI.SelectionLength = 0;
            txtIMEI.SelectionStart = 0;
            txtIMEI.ShortcutsEnabled = true;
            txtIMEI.Size = new Size(190, 48);
            txtIMEI.TabIndex = 7;
            txtIMEI.TabStop = false;
            txtIMEI.TextAlign = HorizontalAlignment.Left;
            txtIMEI.TrailingIcon = null;
            txtIMEI.UseSystemPasswordChar = false;
            // 
            // DeviceForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 479);
            Location = new Point(0, 0);
            Name = "DeviceForm";
            Text = "DeviceForm";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtType;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtModel;
        private ReaLTaiizor.Controls.MaterialComboBox cboBrand;
        private ReaLTaiizor.Controls.MaterialComboBox cboClient;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIMEI;
    }
}