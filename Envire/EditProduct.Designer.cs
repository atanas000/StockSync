namespace Envire
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.barcode = new MaterialSkin.Controls.MaterialTextBox();
            this.wholesalePrice = new MaterialSkin.Controls.MaterialTextBox();
            this.type = new MaterialSkin.Controls.MaterialComboBox();
            this.title = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(608, 198);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(186, 36);
            this.materialButton2.TabIndex = 93;
            this.materialButton2.Text = "Изчисти";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(414, 198);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(186, 36);
            this.materialButton1.TabIndex = 92;
            this.materialButton1.Text = "Редактирай продукт";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // barcode
            // 
            this.barcode.AnimateReadOnly = false;
            this.barcode.BackColor = System.Drawing.Color.White;
            this.barcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.barcode.Depth = 0;
            this.barcode.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.barcode.Hint = "Баркод";
            this.barcode.LeadingIcon = null;
            this.barcode.Location = new System.Drawing.Point(596, 122);
            this.barcode.MaxLength = 50;
            this.barcode.MouseState = MaterialSkin.MouseState.OUT;
            this.barcode.Multiline = false;
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(378, 50);
            this.barcode.TabIndex = 91;
            this.barcode.Text = "";
            this.barcode.TrailingIcon = null;
            // 
            // wholesalePrice
            // 
            this.wholesalePrice.AnimateReadOnly = false;
            this.wholesalePrice.BackColor = System.Drawing.Color.White;
            this.wholesalePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wholesalePrice.Depth = 0;
            this.wholesalePrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.wholesalePrice.Hint = "Цена на едро";
            this.wholesalePrice.LeadingIcon = null;
            this.wholesalePrice.Location = new System.Drawing.Point(980, 121);
            this.wholesalePrice.MaxLength = 50;
            this.wholesalePrice.MouseState = MaterialSkin.MouseState.OUT;
            this.wholesalePrice.Multiline = false;
            this.wholesalePrice.Name = "wholesalePrice";
            this.wholesalePrice.Size = new System.Drawing.Size(193, 50);
            this.wholesalePrice.TabIndex = 89;
            this.wholesalePrice.Text = "";
            this.wholesalePrice.TrailingIcon = null;
            // 
            // type
            // 
            this.type.AutoResize = false;
            this.type.BackColor = System.Drawing.Color.White;
            this.type.Depth = 0;
            this.type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.type.DropDownHeight = 174;
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.DropDownWidth = 121;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.type.FormattingEnabled = true;
            this.type.Hint = "Категория";
            this.type.IntegralHeight = false;
            this.type.ItemHeight = 43;
            this.type.Location = new System.Drawing.Point(326, 122);
            this.type.MaxDropDownItems = 4;
            this.type.MouseState = MaterialSkin.MouseState.OUT;
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(264, 49);
            this.type.StartIndex = 0;
            this.type.TabIndex = 88;
            // 
            // title
            // 
            this.title.AnimateReadOnly = false;
            this.title.BackColor = System.Drawing.Color.White;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Depth = 0;
            this.title.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.title.Hint = "Продукт";
            this.title.LeadingIcon = null;
            this.title.Location = new System.Drawing.Point(35, 122);
            this.title.MaxLength = 50;
            this.title.MouseState = MaterialSkin.MouseState.OUT;
            this.title.Multiline = false;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(285, 50);
            this.title.TabIndex = 87;
            this.title.Text = "";
            this.title.TrailingIcon = null;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 263);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.wholesalePrice);
            this.Controls.Add(this.type);
            this.Controls.Add(this.title);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProduct";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Text = "Редактиране на продукт";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox barcode;
        private MaterialSkin.Controls.MaterialTextBox wholesalePrice;
        private MaterialSkin.Controls.MaterialComboBox type;
        private MaterialSkin.Controls.MaterialTextBox title;
    }
}