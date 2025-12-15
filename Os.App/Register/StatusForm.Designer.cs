namespace Os.App.Register
{
    partial class StatusForm
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
            txtDescription = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(857, 439);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtDescription);
            tabPageRegister.Controls.Add(txtName);
            tabPageRegister.Size = new Size(849, 398);
            tabPageRegister.Controls.SetChildIndex(txtName, 0);
            tabPageRegister.Controls.SetChildIndex(txtDescription, 0);
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Status Name";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(15, 45);
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
            txtName.Size = new Size(264, 48);
            txtName.TabIndex = 3;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.AutoCompleteMode = AutoCompleteMode.None;
            txtDescription.AutoCompleteSource = AutoCompleteSource.None;
            txtDescription.BackgroundImageLayout = ImageLayout.None;
            txtDescription.CharacterCasing = CharacterCasing.Normal;
            txtDescription.Depth = 0;
            txtDescription.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescription.HideSelection = true;
            txtDescription.Hint = "Description";
            txtDescription.LeadingIcon = null;
            txtDescription.Location = new Point(15, 112);
            txtDescription.MaxLength = 32767;
            txtDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.PrefixSuffixText = null;
            txtDescription.ReadOnly = false;
            txtDescription.RightToLeft = RightToLeft.No;
            txtDescription.SelectedText = "";
            txtDescription.SelectionLength = 0;
            txtDescription.SelectionStart = 0;
            txtDescription.ShortcutsEnabled = true;
            txtDescription.Size = new Size(264, 48);
            txtDescription.TabIndex = 4;
            txtDescription.TabStop = false;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.TrailingIcon = null;
            txtDescription.UseSystemPasswordChar = false;
            // 
            // StatusForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 477);
            Location = new Point(0, 0);
            Name = "StatusForm";
            Text = "StatusForm";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescription;
    }
}