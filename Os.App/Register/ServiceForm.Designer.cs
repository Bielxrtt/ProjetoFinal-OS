namespace Os.App.Register
{
    partial class ServiceForm
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
            txtServiceName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrice = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDescription = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(857, 442);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtDescription);
            tabPageRegister.Controls.Add(txtPrice);
            tabPageRegister.Controls.Add(txtServiceName);
            tabPageRegister.Size = new Size(849, 401);
            tabPageRegister.Controls.SetChildIndex(txtServiceName, 0);
            tabPageRegister.Controls.SetChildIndex(txtPrice, 0);
            tabPageRegister.Controls.SetChildIndex(txtDescription, 0);
            // 
            // txtServiceName
            // 
            txtServiceName.AnimateReadOnly = false;
            txtServiceName.AutoCompleteMode = AutoCompleteMode.None;
            txtServiceName.AutoCompleteSource = AutoCompleteSource.None;
            txtServiceName.BackgroundImageLayout = ImageLayout.None;
            txtServiceName.CharacterCasing = CharacterCasing.Normal;
            txtServiceName.Depth = 0;
            txtServiceName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtServiceName.HideSelection = true;
            txtServiceName.Hint = "Service Name";
            txtServiceName.LeadingIcon = null;
            txtServiceName.Location = new Point(15, 25);
            txtServiceName.MaxLength = 32767;
            txtServiceName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtServiceName.Name = "txtServiceName";
            txtServiceName.PasswordChar = '\0';
            txtServiceName.PrefixSuffixText = null;
            txtServiceName.ReadOnly = false;
            txtServiceName.RightToLeft = RightToLeft.No;
            txtServiceName.SelectedText = "";
            txtServiceName.SelectionLength = 0;
            txtServiceName.SelectionStart = 0;
            txtServiceName.ShortcutsEnabled = true;
            txtServiceName.Size = new Size(193, 48);
            txtServiceName.TabIndex = 3;
            txtServiceName.TabStop = false;
            txtServiceName.TextAlign = HorizontalAlignment.Left;
            txtServiceName.TrailingIcon = null;
            txtServiceName.UseSystemPasswordChar = false;
            // 
            // txtPrice
            // 
            txtPrice.AnimateReadOnly = false;
            txtPrice.AutoCompleteMode = AutoCompleteMode.None;
            txtPrice.AutoCompleteSource = AutoCompleteSource.None;
            txtPrice.BackgroundImageLayout = ImageLayout.None;
            txtPrice.CharacterCasing = CharacterCasing.Normal;
            txtPrice.Depth = 0;
            txtPrice.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrice.HideSelection = true;
            txtPrice.Hint = "Price";
            txtPrice.LeadingIcon = null;
            txtPrice.Location = new Point(15, 89);
            txtPrice.MaxLength = 32767;
            txtPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PrefixSuffixText = null;
            txtPrice.ReadOnly = false;
            txtPrice.RightToLeft = RightToLeft.No;
            txtPrice.SelectedText = "";
            txtPrice.SelectionLength = 0;
            txtPrice.SelectionStart = 0;
            txtPrice.ShortcutsEnabled = true;
            txtPrice.Size = new Size(194, 48);
            txtPrice.TabIndex = 4;
            txtPrice.TabStop = false;
            txtPrice.TextAlign = HorizontalAlignment.Left;
            txtPrice.TrailingIcon = null;
            txtPrice.UseSystemPasswordChar = false;
            // 
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.BackgroundImageLayout = ImageLayout.None;
            txtDescription.CharacterCasing = CharacterCasing.Normal;
            txtDescription.Depth = 0;
            txtDescription.HideSelection = true;
            txtDescription.Hint = "Description";
            txtDescription.Location = new Point(17, 158);
            txtDescription.MaxLength = 32767;
            txtDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.ReadOnly = false;
            txtDescription.ScrollBars = ScrollBars.None;
            txtDescription.SelectedText = "";
            txtDescription.SelectionLength = 0;
            txtDescription.SelectionStart = 0;
            txtDescription.ShortcutsEnabled = true;
            txtDescription.Size = new Size(253, 49);
            txtDescription.TabIndex = 5;
            txtDescription.TabStop = false;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.UseSystemPasswordChar = false;
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 480);
            Location = new Point(0, 0);
            Name = "ServiceForm";
            Text = "ServiceForm";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtDescription;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrice;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtServiceName;
    }
}