namespace Os.App.Base
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            tabControlRegister = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageRegister = new TabPage();
            panel1 = new Panel();
            btnConsult = new ReaLTaiizor.Controls.MaterialButton();
            btnConfirm = new ReaLTaiizor.Controls.MaterialButton();
            btnCancel = new ReaLTaiizor.Controls.MaterialButton();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnSave = new ReaLTaiizor.Controls.MaterialButton();
            btnEdit = new ReaLTaiizor.Controls.MaterialButton();
            btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Controls.Add(tabPageRegister);
            tabControlRegister.Controls.Add(tabPage2);
            tabControlRegister.Depth = 0;
            tabControlRegister.Dock = DockStyle.Fill;
            tabControlRegister.Location = new Point(2, 36);
            tabControlRegister.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlRegister.Multiline = true;
            tabControlRegister.Name = "tabControlRegister";
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.Size = new Size(853, 439);
            tabControlRegister.TabIndex = 0;
            // 
            // tabPageRegister
            // 
            tabPageRegister.BackColor = Color.Gray;
            tabPageRegister.Controls.Add(panel1);
            tabPageRegister.Location = new Point(4, 37);
            tabPageRegister.Name = "tabPageRegister";
            tabPageRegister.Padding = new Padding(3);
            tabPageRegister.Size = new Size(845, 398);
            tabPageRegister.TabIndex = 0;
            tabPageRegister.Text = "Register";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConsult);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(3, 322);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 73);
            panel1.TabIndex = 2;
            // 
            // btnConsult
            // 
            btnConsult.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConsult.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConsult.Depth = 0;
            btnConsult.HighEmphasis = true;
            btnConsult.Icon = null;
            btnConsult.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnConsult.Location = new Point(530, 16);
            btnConsult.Margin = new Padding(4, 6, 4, 6);
            btnConsult.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnConsult.Name = "btnConsult";
            btnConsult.NoAccentTextColor = Color.Empty;
            btnConsult.Size = new Size(87, 36);
            btnConsult.TabIndex = 2;
            btnConsult.Text = "Consult";
            btnConsult.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnConsult.UseAccentColor = false;
            btnConsult.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirm.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirm.Depth = 0;
            btnConfirm.HighEmphasis = true;
            btnConfirm.Icon = null;
            btnConfirm.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnConfirm.Location = new Point(738, 16);
            btnConfirm.Margin = new Padding(4, 6, 4, 6);
            btnConfirm.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnConfirm.Name = "btnConfirm";
            btnConfirm.NoAccentTextColor = Color.Empty;
            btnConfirm.Size = new Size(86, 36);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnConfirm.UseAccentColor = false;
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancel.Location = new Point(636, 16);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gray;
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(845, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(827, 307);
            dataGridView1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnDelete);
            panel2.Location = new Point(3, 326);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 73);
            panel2.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSave.Location = new Point(754, 18);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEdit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEdit.Depth = 0;
            btnEdit.HighEmphasis = true;
            btnEdit.Icon = null;
            btnEdit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEdit.Location = new Point(651, 18);
            btnEdit.Margin = new Padding(4, 6, 4, 6);
            btnEdit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEdit.Name = "btnEdit";
            btnEdit.NoAccentTextColor = Color.Empty;
            btnEdit.Size = new Size(64, 36);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnEdit.UseAccentColor = false;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnDelete.Location = new Point(532, 18);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(73, 36);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.LightSlateGray;
            ClientSize = new Size(857, 477);
            Controls.Add(tabControlRegister);
            Image = (Image)resources.GetObject("$this.Image");
            Name = "BaseForm";
            Text = "BaseForm";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        protected ReaLTaiizor.Controls.MaterialTabControl tabControlRegister;
        private Panel panel2;
        protected TabPage tabPageRegister;
        protected TabPage tabPage2;
        protected DataGridView dataGridView1;
        protected ReaLTaiizor.Controls.MaterialButton btnConfirm;
        protected ReaLTaiizor.Controls.MaterialButton btnCancel;
        protected ReaLTaiizor.Controls.MaterialButton btnConsult; // Variável do Botão
        protected ReaLTaiizor.Controls.MaterialButton btnSave;
        protected ReaLTaiizor.Controls.MaterialButton btnEdit;
        protected ReaLTaiizor.Controls.MaterialButton btnDelete;
    }
}