namespace Os.App.Register
{
    partial class UserSystemForm
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
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboAcessLevel = new ReaLTaiizor.Controls.MaterialComboBox();
            cboStatus = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(858, 437);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(cboStatus);
            tabPageRegister.Controls.Add(cboAcessLevel);
            tabPageRegister.Controls.Add(txtPassword);
            tabPageRegister.Controls.Add(txtLogin);
            tabPageRegister.Controls.Add(txtName);
            tabPageRegister.Size = new Size(850, 396);
            tabPageRegister.Controls.SetChildIndex(txtName, 0);
            tabPageRegister.Controls.SetChildIndex(txtLogin, 0);
            tabPageRegister.Controls.SetChildIndex(txtPassword, 0);
            tabPageRegister.Controls.SetChildIndex(cboAcessLevel, 0);
            tabPageRegister.Controls.SetChildIndex(cboStatus, 0);
            // 
            // tabPage2
            // 
            tabPage2.Size = new Size(850, 396);
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Name";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(16, 35);
            txtName.MaxLength = 32767;
            txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = false;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(265, 48);
            txtName.TabIndex = 3;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtLogin
            // 
            txtLogin.AnimateReadOnly = false;
            txtLogin.AutoCompleteMode = AutoCompleteMode.None;
            txtLogin.AutoCompleteSource = AutoCompleteSource.None;
            txtLogin.BackgroundImageLayout = ImageLayout.None;
            txtLogin.CharacterCasing = CharacterCasing.Normal;
            txtLogin.Depth = 0;
            txtLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLogin.HideSelection = true;
            txtLogin.Hint = "Login";
            txtLogin.LeadingIcon = null;
            txtLogin.Location = new Point(299, 35);
            txtLogin.MaxLength = 32767;
            txtLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.PrefixSuffixText = null;
            txtLogin.ReadOnly = false;
            txtLogin.RightToLeft = RightToLeft.No;
            txtLogin.SelectedText = "";
            txtLogin.SelectionLength = 0;
            txtLogin.SelectionStart = 0;
            txtLogin.ShortcutsEnabled = true;
            txtLogin.Size = new Size(219, 48);
            txtLogin.TabIndex = 4;
            txtLogin.TabStop = false;
            txtLogin.TextAlign = HorizontalAlignment.Left;
            txtLogin.TrailingIcon = null;
            txtLogin.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Password";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(18, 116);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PrefixSuffixText = null;
            txtPassword.ReadOnly = false;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(265, 48);
            txtPassword.TabIndex = 5;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // cboAcessLevel
            // 
            cboAcessLevel.AutoResize = false;
            cboAcessLevel.BackColor = Color.FromArgb(255, 255, 255);
            cboAcessLevel.Depth = 0;
            cboAcessLevel.DrawMode = DrawMode.OwnerDrawVariable;
            cboAcessLevel.DropDownHeight = 174;
            cboAcessLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAcessLevel.DropDownWidth = 121;
            cboAcessLevel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAcessLevel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAcessLevel.FormattingEnabled = true;
            cboAcessLevel.Hint = "Acess Level";
            cboAcessLevel.IntegralHeight = false;
            cboAcessLevel.ItemHeight = 43;
            cboAcessLevel.Location = new Point(315, 117);
            cboAcessLevel.MaxDropDownItems = 4;
            cboAcessLevel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAcessLevel.Name = "cboAcessLevel";
            cboAcessLevel.Size = new Size(124, 49);
            cboAcessLevel.StartIndex = 0;
            cboAcessLevel.TabIndex = 6;
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
            cboStatus.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboStatus.FormattingEnabled = true;
            cboStatus.Hint = "Status";
            cboStatus.IntegralHeight = false;
            cboStatus.ItemHeight = 43;
            cboStatus.Location = new Point(469, 116);
            cboStatus.MaxDropDownItems = 4;
            cboStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(133, 49);
            cboStatus.StartIndex = 0;
            cboStatus.TabIndex = 7;
            // 
            // UserSystemForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 475);
            Location = new Point(0, 0);
            Name = "UserSystemForm";
            Text = "UserSystemForm";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboAcessLevel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialComboBox cboStatus;
    }
}