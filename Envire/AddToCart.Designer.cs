namespace Envire
{
    partial class AddToCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToCart));
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.sum = new MaterialSkin.Controls.MaterialTextBox();
            this.quantity = new MaterialSkin.Controls.MaterialTextBox();
            this.searchBtn = new MaterialSkin.Controls.MaterialButton();
            this.productSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = global::Envire.Properties.Resources.close_32px;
            this.materialButton1.Image = global::Envire.Properties.Resources.Plus_32px;
            this.materialButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialButton1.Location = new System.Drawing.Point(571, 6);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(39, 36);
            this.materialButton1.TabIndex = 98;
            this.materialButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // sum
            // 
            this.sum.AnimateReadOnly = false;
            this.sum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sum.Depth = 0;
            this.sum.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sum.Hint = "Обща сума";
            this.sum.LeadingIcon = null;
            this.sum.Location = new System.Drawing.Point(223, 139);
            this.sum.MaxLength = 50;
            this.sum.MouseState = MaterialSkin.MouseState.OUT;
            this.sum.Multiline = false;
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(184, 50);
            this.sum.TabIndex = 97;
            this.sum.Text = "";
            this.sum.TrailingIcon = global::Envire.Properties.Resources.Average_Price_32px;
            // 
            // quantity
            // 
            this.quantity.AnimateReadOnly = false;
            this.quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantity.Depth = 0;
            this.quantity.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.quantity.Hint = "Количество";
            this.quantity.LeadingIcon = null;
            this.quantity.Location = new System.Drawing.Point(33, 139);
            this.quantity.MaxLength = 50;
            this.quantity.MouseState = MaterialSkin.MouseState.OUT;
            this.quantity.Multiline = false;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(184, 50);
            this.quantity.TabIndex = 96;
            this.quantity.Text = "";
            this.quantity.TrailingIcon = global::Envire.Properties.Resources.approximately_equal_32px;
            // 
            // searchBtn
            // 
            this.searchBtn.AutoSize = false;
            this.searchBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchBtn.Depth = 0;
            this.searchBtn.HighEmphasis = true;
            this.searchBtn.Icon = global::Envire.Properties.Resources.search_32px;
            this.searchBtn.Image = global::Envire.Properties.Resources.Plus_32px;
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchBtn.Location = new System.Drawing.Point(416, 34);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchBtn.Size = new System.Drawing.Size(39, 36);
            this.searchBtn.TabIndex = 95;
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchBtn.UseAccentColor = false;
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // productSearch
            // 
            this.productSearch.AnimateReadOnly = false;
            this.productSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productSearch.Depth = 0;
            this.productSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productSearch.Hint = "Part Number";
            this.productSearch.LeadingIcon = null;
            this.productSearch.Location = new System.Drawing.Point(33, 28);
            this.productSearch.MaxLength = 50;
            this.productSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.productSearch.Multiline = false;
            this.productSearch.Name = "productSearch";
            this.productSearch.Size = new System.Drawing.Size(374, 50);
            this.productSearch.TabIndex = 94;
            this.productSearch.Text = "";
            this.productSearch.TrailingIcon = global::Envire.Properties.Resources.search_32px;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = global::Envire.Properties.Resources.add_32px;
            this.materialButton2.Image = global::Envire.Properties.Resources.Plus_32px;
            this.materialButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialButton2.Location = new System.Drawing.Point(416, 146);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(125, 36);
            this.materialButton2.TabIndex = 100;
            this.materialButton2.Text = "Добави";
            this.materialButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // AddToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 217);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.productSearch);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddToCart";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox sum;
        private MaterialSkin.Controls.MaterialTextBox quantity;
        private MaterialSkin.Controls.MaterialButton searchBtn;
        private MaterialSkin.Controls.MaterialTextBox productSearch;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}