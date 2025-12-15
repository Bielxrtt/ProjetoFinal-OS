namespace Os.App.Register
{
    partial class ProductForm
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
            txtNameProduct = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrice = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuantity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(856, 441);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtQuantity);
            tabPageRegister.Controls.Add(txtPrice);
            tabPageRegister.Controls.Add(txtNameProduct);
            tabPageRegister.Size = new Size(848, 400);
            tabPageRegister.Controls.SetChildIndex(txtNameProduct, 0);
            tabPageRegister.Controls.SetChildIndex(txtPrice, 0);
            tabPageRegister.Controls.SetChildIndex(txtQuantity, 0);
            // 
            // txtNameProduct
            // 
            txtNameProduct.AnimateReadOnly = false;
            txtNameProduct.AutoCompleteMode = AutoCompleteMode.None;
            txtNameProduct.AutoCompleteSource = AutoCompleteSource.None;
            txtNameProduct.BackgroundImageLayout = ImageLayout.None;
            txtNameProduct.CharacterCasing = CharacterCasing.Normal;
            txtNameProduct.Depth = 0;
            txtNameProduct.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNameProduct.HideSelection = true;
            txtNameProduct.Hint = "Product";
            txtNameProduct.LeadingIcon = null;
            txtNameProduct.Location = new Point(22, 24);
            txtNameProduct.MaxLength = 32767;
            txtNameProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.PasswordChar = '\0';
            txtNameProduct.PrefixSuffixText = null;
            txtNameProduct.ReadOnly = false;
            txtNameProduct.RightToLeft = RightToLeft.No;
            txtNameProduct.SelectedText = "";
            txtNameProduct.SelectionLength = 0;
            txtNameProduct.SelectionStart = 0;
            txtNameProduct.ShortcutsEnabled = true;
            txtNameProduct.Size = new Size(179, 48);
            txtNameProduct.TabIndex = 3;
            txtNameProduct.TabStop = false;
            txtNameProduct.TextAlign = HorizontalAlignment.Left;
            txtNameProduct.TrailingIcon = null;
            txtNameProduct.UseSystemPasswordChar = false;
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
            txtPrice.Location = new Point(19, 103);
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
            txtPrice.Size = new Size(184, 48);
            txtPrice.TabIndex = 4;
            txtPrice.TabStop = false;
            txtPrice.TextAlign = HorizontalAlignment.Left;
            txtPrice.TrailingIcon = null;
            txtPrice.UseSystemPasswordChar = false;
            // 
            // txtQuantity
            // 
            txtQuantity.AnimateReadOnly = false;
            txtQuantity.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantity.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantity.BackgroundImageLayout = ImageLayout.None;
            txtQuantity.CharacterCasing = CharacterCasing.Normal;
            txtQuantity.Depth = 0;
            txtQuantity.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantity.HideSelection = true;
            txtQuantity.Hint = "Quantity";
            txtQuantity.LeadingIcon = null;
            txtQuantity.Location = new Point(17, 178);
            txtQuantity.MaxLength = 32767;
            txtQuantity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PasswordChar = '\0';
            txtQuantity.PrefixSuffixText = null;
            txtQuantity.ReadOnly = false;
            txtQuantity.RightToLeft = RightToLeft.No;
            txtQuantity.SelectedText = "";
            txtQuantity.SelectionLength = 0;
            txtQuantity.SelectionStart = 0;
            txtQuantity.ShortcutsEnabled = true;
            txtQuantity.Size = new Size(186, 48);
            txtQuantity.TabIndex = 5;
            txtQuantity.TabStop = false;
            txtQuantity.TextAlign = HorizontalAlignment.Left;
            txtQuantity.TrailingIcon = null;
            txtQuantity.UseSystemPasswordChar = false;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 479);
            Location = new Point(0, 0);
            Name = "ProductForm";
            Text = "ProductForm";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantity;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrice;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNameProduct;
    }
}