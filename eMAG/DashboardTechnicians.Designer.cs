namespace eMAG
{
    partial class DashboardTechnicians
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardTechnicians));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.advancedSearchPanel = new System.Windows.Forms.Panel();
            this.searchResult = new System.Windows.Forms.Panel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.countryClient = new MaterialSkin.Controls.MaterialTextBox();
            this.cityClient = new MaterialSkin.Controls.MaterialTextBox();
            this.addressClient = new MaterialSkin.Controls.MaterialTextBox();
            this.phoneClient = new MaterialSkin.Controls.MaterialTextBox();
            this.nameClient = new MaterialSkin.Controls.MaterialTextBox();
            this.resetBtn = new MaterialSkin.Controls.MaterialButton();
            this.searchBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.emailBox = new MaterialSkin.Controls.MaterialTextBox();
            this.orderIDBox = new MaterialSkin.Controls.MaterialTextBox();
            this.phoneBox = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DMS = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.userLoged = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.advancedSearchPanel.SuspendLayout();
            this.searchResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.DMS);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Controls.Add(this.userLoged);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.ItemSize = new System.Drawing.Size(90, 35);
            this.materialTabControl1.Location = new System.Drawing.Point(0, 88);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1233, 503);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.ImageKey = "combo_chart_32px.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1225, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Начало";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.advancedSearchPanel);
            this.tabPage5.ImageKey = "search_32px.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1225, 460);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Подробно търсене";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // advancedSearchPanel
            // 
            this.advancedSearchPanel.Controls.Add(this.searchResult);
            this.advancedSearchPanel.Controls.Add(this.resetBtn);
            this.advancedSearchPanel.Controls.Add(this.searchBtn);
            this.advancedSearchPanel.Controls.Add(this.materialLabel2);
            this.advancedSearchPanel.Controls.Add(this.materialLabel1);
            this.advancedSearchPanel.Controls.Add(this.dateTimePicker2);
            this.advancedSearchPanel.Controls.Add(this.dateTimePicker1);
            this.advancedSearchPanel.Controls.Add(this.emailBox);
            this.advancedSearchPanel.Controls.Add(this.orderIDBox);
            this.advancedSearchPanel.Controls.Add(this.phoneBox);
            this.advancedSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedSearchPanel.Location = new System.Drawing.Point(0, 0);
            this.advancedSearchPanel.Name = "advancedSearchPanel";
            this.advancedSearchPanel.Size = new System.Drawing.Size(1225, 460);
            this.advancedSearchPanel.TabIndex = 0;
            // 
            // searchResult
            // 
            this.searchResult.Controls.Add(this.materialButton1);
            this.searchResult.Controls.Add(this.countryClient);
            this.searchResult.Controls.Add(this.cityClient);
            this.searchResult.Controls.Add(this.addressClient);
            this.searchResult.Controls.Add(this.phoneClient);
            this.searchResult.Controls.Add(this.nameClient);
            this.searchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResult.Location = new System.Drawing.Point(0, 0);
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(1225, 460);
            this.searchResult.TabIndex = 34;
            this.searchResult.Visible = false;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1093, 20);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(114, 36);
            this.materialButton1.TabIndex = 25;
            this.materialButton1.Text = "Затвори";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // countryClient
            // 
            this.countryClient.AnimateReadOnly = false;
            this.countryClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countryClient.Depth = 0;
            this.countryClient.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.countryClient.Hint = "Държава";
            this.countryClient.LeadingIcon = null;
            this.countryClient.Location = new System.Drawing.Point(27, 250);
            this.countryClient.MaxLength = 50;
            this.countryClient.MouseState = MaterialSkin.MouseState.OUT;
            this.countryClient.Multiline = false;
            this.countryClient.Name = "countryClient";
            this.countryClient.Size = new System.Drawing.Size(248, 50);
            this.countryClient.TabIndex = 24;
            this.countryClient.Text = "";
            this.countryClient.TrailingIcon = null;
            // 
            // cityClient
            // 
            this.cityClient.AnimateReadOnly = false;
            this.cityClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityClient.Depth = 0;
            this.cityClient.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cityClient.Hint = "Град";
            this.cityClient.LeadingIcon = null;
            this.cityClient.Location = new System.Drawing.Point(27, 194);
            this.cityClient.MaxLength = 50;
            this.cityClient.MouseState = MaterialSkin.MouseState.OUT;
            this.cityClient.Multiline = false;
            this.cityClient.Name = "cityClient";
            this.cityClient.Size = new System.Drawing.Size(248, 50);
            this.cityClient.TabIndex = 23;
            this.cityClient.Text = "";
            this.cityClient.TrailingIcon = null;
            // 
            // addressClient
            // 
            this.addressClient.AnimateReadOnly = false;
            this.addressClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressClient.Depth = 0;
            this.addressClient.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressClient.Hint = "Адрес";
            this.addressClient.LeadingIcon = null;
            this.addressClient.Location = new System.Drawing.Point(27, 138);
            this.addressClient.MaxLength = 50;
            this.addressClient.MouseState = MaterialSkin.MouseState.OUT;
            this.addressClient.Multiline = false;
            this.addressClient.Name = "addressClient";
            this.addressClient.Size = new System.Drawing.Size(248, 50);
            this.addressClient.TabIndex = 22;
            this.addressClient.Text = "";
            this.addressClient.TrailingIcon = null;
            // 
            // phoneClient
            // 
            this.phoneClient.AnimateReadOnly = false;
            this.phoneClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneClient.Depth = 0;
            this.phoneClient.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneClient.Hint = "Телефонен номер";
            this.phoneClient.LeadingIcon = null;
            this.phoneClient.Location = new System.Drawing.Point(27, 82);
            this.phoneClient.MaxLength = 50;
            this.phoneClient.MouseState = MaterialSkin.MouseState.OUT;
            this.phoneClient.Multiline = false;
            this.phoneClient.Name = "phoneClient";
            this.phoneClient.Size = new System.Drawing.Size(248, 50);
            this.phoneClient.TabIndex = 21;
            this.phoneClient.Text = "";
            this.phoneClient.TrailingIcon = null;
            // 
            // nameClient
            // 
            this.nameClient.AnimateReadOnly = false;
            this.nameClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameClient.Depth = 0;
            this.nameClient.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameClient.Hint = "Име на клиент";
            this.nameClient.LeadingIcon = null;
            this.nameClient.Location = new System.Drawing.Point(27, 26);
            this.nameClient.MaxLength = 50;
            this.nameClient.MouseState = MaterialSkin.MouseState.OUT;
            this.nameClient.Multiline = false;
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(248, 50);
            this.nameClient.TabIndex = 20;
            this.nameClient.Text = "";
            this.nameClient.TrailingIcon = null;
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resetBtn.AutoSize = false;
            this.resetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resetBtn.Depth = 0;
            this.resetBtn.HighEmphasis = true;
            this.resetBtn.Icon = null;
            this.resetBtn.Location = new System.Drawing.Point(616, 403);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resetBtn.Size = new System.Drawing.Size(158, 36);
            this.resetBtn.TabIndex = 29;
            this.resetBtn.Text = "Изчисти";
            this.resetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resetBtn.UseAccentColor = false;
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchBtn.AutoSize = false;
            this.searchBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchBtn.Depth = 0;
            this.searchBtn.HighEmphasis = true;
            this.searchBtn.Icon = null;
            this.searchBtn.Location = new System.Drawing.Point(450, 403);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchBtn.Size = new System.Drawing.Size(158, 36);
            this.searchBtn.TabIndex = 28;
            this.searchBtn.Text = "Търси";
            this.searchBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchBtn.UseAccentColor = false;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.Black;
            this.materialLabel2.Location = new System.Drawing.Point(614, 30);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 19);
            this.materialLabel2.TabIndex = 21;
            this.materialLabel2.Text = "До дата";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.Black;
            this.materialLabel1.Location = new System.Drawing.Point(408, 30);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "От дата";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.Location = new System.Drawing.Point(617, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(411, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // emailBox
            // 
            this.emailBox.AnimateReadOnly = false;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Depth = 0;
            this.emailBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailBox.Hint = "Email";
            this.emailBox.LeadingIcon = null;
            this.emailBox.Location = new System.Drawing.Point(27, 209);
            this.emailBox.MaxLength = 50;
            this.emailBox.MouseState = MaterialSkin.MouseState.OUT;
            this.emailBox.Multiline = false;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(261, 50);
            this.emailBox.TabIndex = 14;
            this.emailBox.Text = "";
            this.emailBox.TrailingIcon = null;
            // 
            // orderIDBox
            // 
            this.orderIDBox.AnimateReadOnly = false;
            this.orderIDBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderIDBox.Depth = 0;
            this.orderIDBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.orderIDBox.Hint = "Номер на фактура";
            this.orderIDBox.LeadingIcon = null;
            this.orderIDBox.Location = new System.Drawing.Point(27, 153);
            this.orderIDBox.MaxLength = 50;
            this.orderIDBox.MouseState = MaterialSkin.MouseState.OUT;
            this.orderIDBox.Multiline = false;
            this.orderIDBox.Name = "orderIDBox";
            this.orderIDBox.Size = new System.Drawing.Size(261, 50);
            this.orderIDBox.TabIndex = 12;
            this.orderIDBox.Text = "";
            this.orderIDBox.TrailingIcon = null;
            // 
            // phoneBox
            // 
            this.phoneBox.AnimateReadOnly = false;
            this.phoneBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneBox.Depth = 0;
            this.phoneBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneBox.Hint = "Телефонен номер";
            this.phoneBox.LeadingIcon = null;
            this.phoneBox.Location = new System.Drawing.Point(27, 97);
            this.phoneBox.MaxLength = 50;
            this.phoneBox.MouseState = MaterialSkin.MouseState.OUT;
            this.phoneBox.Multiline = false;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(261, 50);
            this.phoneBox.TabIndex = 10;
            this.phoneBox.Text = "";
            this.phoneBox.TrailingIcon = null;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "warehouse_32px.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1225, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "WMS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DMS
            // 
            this.DMS.ImageKey = "shipped_32px.png";
            this.DMS.Location = new System.Drawing.Point(4, 39);
            this.DMS.Name = "DMS";
            this.DMS.Size = new System.Drawing.Size(1225, 460);
            this.DMS.TabIndex = 2;
            this.DMS.Text = "DMS";
            this.DMS.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.ImageKey = "return_merchandise_authorization_32px.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1225, 460);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "RTR";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "data_transfer_32px.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1225, 460);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "TRN";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.ImageKey = "settings_32px.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1225, 460);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Настройки";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // userLoged
            // 
            this.userLoged.ImageKey = "logout_32px.png";
            this.userLoged.Location = new System.Drawing.Point(4, 39);
            this.userLoged.Name = "userLoged";
            this.userLoged.Size = new System.Drawing.Size(1225, 460);
            this.userLoged.TabIndex = 7;
            this.userLoged.Text = "Изход";
            this.userLoged.UseVisualStyleBackColor = true;
            this.userLoged.Click += new System.EventHandler(this.userLoged_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "return_merchandise_authorization_32px.png");
            this.imageList1.Images.SetKeyName(1, "data_transfer_32px.png");
            this.imageList1.Images.SetKeyName(2, "shipped_32px.png");
            this.imageList1.Images.SetKeyName(3, "warehouse_32px.png");
            this.imageList1.Images.SetKeyName(4, "settings_32px.png");
            this.imageList1.Images.SetKeyName(5, "search_32px.png");
            this.imageList1.Images.SetKeyName(6, "combo_chart_32px.png");
            this.imageList1.Images.SetKeyName(7, "logout_32px.png");
            // 
            // DashboardTechnicians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 594);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardTechnicians";
            this.Padding = new System.Windows.Forms.Padding(0, 88, 3, 3);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardTechnicians_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.advancedSearchPanel.ResumeLayout(false);
            this.advancedSearchPanel.PerformLayout();
            this.searchResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage DMS;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage userLoged;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel advancedSearchPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialTextBox emailBox;
        private MaterialSkin.Controls.MaterialTextBox orderIDBox;
        private MaterialSkin.Controls.MaterialTextBox phoneBox;
        private MaterialSkin.Controls.MaterialButton resetBtn;
        private MaterialSkin.Controls.MaterialButton searchBtn;
        private System.Windows.Forms.Panel searchResult;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox countryClient;
        private MaterialSkin.Controls.MaterialTextBox cityClient;
        private MaterialSkin.Controls.MaterialTextBox addressClient;
        private MaterialSkin.Controls.MaterialTextBox phoneClient;
        private MaterialSkin.Controls.MaterialTextBox nameClient;
    }
}