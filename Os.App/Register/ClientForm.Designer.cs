namespace Os.App.Register
{
    partial class ClientForm
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
            txtClientName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtClientPhone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAdress = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(854, 436);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtAdress);
            tabPageRegister.Controls.Add(txtEmail);
            tabPageRegister.Controls.Add(txtClientPhone);
            tabPageRegister.Controls.Add(txtClientName);
            tabPageRegister.Size = new Size(846, 395);
            tabPageRegister.Controls.SetChildIndex(txtClientName, 0);
            tabPageRegister.Controls.SetChildIndex(txtClientPhone, 0);
            tabPageRegister.Controls.SetChildIndex(txtEmail, 0);
            tabPageRegister.Controls.SetChildIndex(txtAdress, 0);
            // 
            // tabPage2
            // 
            tabPage2.Size = new Size(846, 395);
            // 
            // txtClientName
            // 
            txtClientName.AnimateReadOnly = false;
            txtClientName.AutoCompleteMode = AutoCompleteMode.None;
            txtClientName.AutoCompleteSource = AutoCompleteSource.None;
            txtClientName.BackgroundImageLayout = ImageLayout.None;
            txtClientName.CharacterCasing = CharacterCasing.Normal;
            txtClientName.Depth = 0;
            txtClientName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtClientName.HideSelection = true;
            txtClientName.Hint = "Client Name";
            txtClientName.LeadingIcon = null;
            txtClientName.Location = new Point(23, 26);
            txtClientName.MaxLength = 32767;
            txtClientName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtClientName.Name = "txtClientName";
            txtClientName.PasswordChar = '\0';
            txtClientName.PrefixSuffixText = null;
            txtClientName.ReadOnly = false;
            txtClientName.RightToLeft = RightToLeft.No;
            txtClientName.SelectedText = "";
            txtClientName.SelectionLength = 0;
            txtClientName.SelectionStart = 0;
            txtClientName.ShortcutsEnabled = true;
            txtClientName.Size = new Size(226, 48);
            txtClientName.TabIndex = 3;
            txtClientName.TabStop = false;
            txtClientName.TextAlign = HorizontalAlignment.Left;
            txtClientName.TrailingIcon = null;
            txtClientName.UseSystemPasswordChar = false;
            // 
            // txtClientPhone
            // 
            txtClientPhone.AllowPromptAsInput = true;
            txtClientPhone.AnimateReadOnly = false;
            txtClientPhone.AsciiOnly = false;
            txtClientPhone.BackgroundImageLayout = ImageLayout.None;
            txtClientPhone.BeepOnError = false;
            txtClientPhone.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtClientPhone.Depth = 0;
            txtClientPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtClientPhone.HidePromptOnLeave = false;
            txtClientPhone.HideSelection = true;
            txtClientPhone.Hint = "Phone Number";
            txtClientPhone.InsertKeyMode = InsertKeyMode.Default;
            txtClientPhone.LeadingIcon = null;
            txtClientPhone.Location = new Point(23, 90);
            txtClientPhone.Mask = "";
            txtClientPhone.MaxLength = 32767;
            txtClientPhone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtClientPhone.Name = "txtClientPhone";
            txtClientPhone.PasswordChar = '\0';
            txtClientPhone.PrefixSuffixText = null;
            txtClientPhone.PromptChar = '_';
            txtClientPhone.ReadOnly = false;
            txtClientPhone.RejectInputOnFirstFailure = false;
            txtClientPhone.ResetOnPrompt = true;
            txtClientPhone.ResetOnSpace = true;
            txtClientPhone.RightToLeft = RightToLeft.No;
            txtClientPhone.SelectedText = "";
            txtClientPhone.SelectionLength = 0;
            txtClientPhone.SelectionStart = 0;
            txtClientPhone.ShortcutsEnabled = true;
            txtClientPhone.Size = new Size(227, 48);
            txtClientPhone.SkipLiterals = true;
            txtClientPhone.TabIndex = 4;
            txtClientPhone.TabStop = false;
            txtClientPhone.TextAlign = HorizontalAlignment.Left;
            txtClientPhone.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtClientPhone.TrailingIcon = null;
            txtClientPhone.UseSystemPasswordChar = false;
            txtClientPhone.ValidatingType = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "E-Mail";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(20, 155);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(229, 48);
            txtEmail.TabIndex = 5;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtAdress
            // 
            txtAdress.AnimateReadOnly = false;
            txtAdress.BackgroundImageLayout = ImageLayout.None;
            txtAdress.CharacterCasing = CharacterCasing.Normal;
            txtAdress.Depth = 0;
            txtAdress.HideSelection = true;
            txtAdress.Hint = "Adress";
            txtAdress.Location = new Point(297, 26);
            txtAdress.MaxLength = 32767;
            txtAdress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAdress.Name = "txtAdress";
            txtAdress.PasswordChar = '\0';
            txtAdress.ReadOnly = false;
            txtAdress.ScrollBars = ScrollBars.None;
            txtAdress.SelectedText = "";
            txtAdress.SelectionLength = 0;
            txtAdress.SelectionStart = 0;
            txtAdress.ShortcutsEnabled = true;
            txtAdress.Size = new Size(307, 47);
            txtAdress.TabIndex = 6;
            txtAdress.TabStop = false;
            txtAdress.TextAlign = HorizontalAlignment.Left;
            txtAdress.UseSystemPasswordChar = false;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 474);
            Location = new Point(0, 0);
            Name = "ClientForm";
            Text = "ClientForm";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtClientName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtClientPhone;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtAdress;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
    }
}