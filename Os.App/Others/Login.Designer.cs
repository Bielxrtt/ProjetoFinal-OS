namespace Os.App.Others
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnCancel = new ReaLTaiizor.Controls.MaterialButton();
            btnOk = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
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
            txtLogin.Location = new Point(53, 121);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
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
            txtLogin.Size = new Size(286, 48);
            txtLogin.TabIndex = 0;
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
            txtPassword.Location = new Point(53, 211);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PrefixSuffixText = null;
            txtPassword.ReadOnly = false;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(286, 48);
            txtPassword.TabIndex = 1;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.BackColor = Color.Gray;
            btnCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.ForeColor = SystemColors.WindowFrame;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancel.Location = new Point(52, 366);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOk.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOk.Depth = 0;
            btnOk.HighEmphasis = true;
            btnOk.Icon = null;
            btnOk.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnOk.Location = new Point(275, 366);
            btnOk.Margin = new Padding(4, 6, 4, 6);
            btnOk.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnOk.Name = "btnOk";
            btnOk.NoAccentTextColor = Color.Empty;
            btnOk.Size = new Size(64, 36);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnOk.UseAccentColor = false;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderColor = Color.SlateGray;
            ClientSize = new Size(423, 450);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            HeaderColor = Color.Gray;
            Image = (Image)resources.GetObject("$this.Image");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Os Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPassword;
        private ReaLTaiizor.Controls.MaterialButton btnCancel;
        private ReaLTaiizor.Controls.MaterialButton btnOk;
    }
}