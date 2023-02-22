namespace Envire
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
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.signinBtn = new MaterialSkin.Controls.MaterialButton();
            this.passBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.userBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Платформа";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "WMS",
            "RMA",
            "TRN"});
            this.materialComboBox1.Location = new System.Drawing.Point(120, 246);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(303, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 22;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = global::Envire.Properties.Resources.microsoft_24px;
            this.materialButton2.Location = new System.Drawing.Point(275, 458);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(186, 36);
            this.materialButton2.TabIndex = 21;
            this.materialButton2.Text = "Вход с Microsoft";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = global::Envire.Properties.Resources.google_24px;
            this.materialButton1.Location = new System.Drawing.Point(81, 458);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(186, 36);
            this.materialButton1.TabIndex = 20;
            this.materialButton1.Text = "Вход с Google";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // signinBtn
            // 
            this.signinBtn.AutoSize = false;
            this.signinBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signinBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signinBtn.Depth = 0;
            this.signinBtn.HighEmphasis = true;
            this.signinBtn.Icon = global::Envire.Properties.Resources.login_32px;
            this.signinBtn.Location = new System.Drawing.Point(214, 511);
            this.signinBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signinBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signinBtn.Size = new System.Drawing.Size(115, 36);
            this.signinBtn.TabIndex = 18;
            this.signinBtn.Text = "Вход";
            this.signinBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.signinBtn.UseAccentColor = false;
            this.signinBtn.UseVisualStyleBackColor = true;
            this.signinBtn.Click += new System.EventHandler(this.signinBtn_Click);
            // 
            // passBox
            // 
            this.passBox.AnimateReadOnly = false;
            this.passBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passBox.Depth = 0;
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passBox.HideSelection = true;
            this.passBox.Hint = "Парола";
            this.passBox.LeadingIcon = null;
            this.passBox.Location = new System.Drawing.Point(120, 355);
            this.passBox.MaxLength = 32767;
            this.passBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '●';
            this.passBox.PrefixSuffixText = null;
            this.passBox.ReadOnly = false;
            this.passBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passBox.SelectedText = "";
            this.passBox.SelectionLength = 0;
            this.passBox.SelectionStart = 0;
            this.passBox.ShortcutsEnabled = true;
            this.passBox.Size = new System.Drawing.Size(303, 48);
            this.passBox.TabIndex = 17;
            this.passBox.TabStop = false;
            this.passBox.Text = "admin";
            this.passBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passBox.TrailingIcon = global::Envire.Properties.Resources.password_32px3;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // userBox
            // 
            this.userBox.AnimateReadOnly = false;
            this.userBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userBox.Depth = 0;
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userBox.HideSelection = true;
            this.userBox.Hint = "Потребителско име";
            this.userBox.LeadingIcon = null;
            this.userBox.Location = new System.Drawing.Point(120, 301);
            this.userBox.MaxLength = 32767;
            this.userBox.MouseState = MaterialSkin.MouseState.OUT;
            this.userBox.Name = "userBox";
            this.userBox.PasswordChar = '\0';
            this.userBox.PrefixSuffixText = null;
            this.userBox.ReadOnly = false;
            this.userBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userBox.SelectedText = "";
            this.userBox.SelectionLength = 0;
            this.userBox.SelectionStart = 0;
            this.userBox.ShortcutsEnabled = true;
            this.userBox.Size = new System.Drawing.Size(303, 48);
            this.userBox.TabIndex = 16;
            this.userBox.TabStop = false;
            this.userBox.Text = "admin";
            this.userBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userBox.TrailingIcon = global::Envire.Properties.Resources.user_32px;
            this.userBox.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Envire.Properties.Resources._1656831886_47_illustration_png;
            this.pictureBox1.Location = new System.Drawing.Point(3, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 578);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.materialComboBox1);
            this.panel2.Controls.Add(this.userBox);
            this.panel2.Controls.Add(this.materialButton2);
            this.panel2.Controls.Add(this.passBox);
            this.panel2.Controls.Add(this.materialButton1);
            this.panel2.Controls.Add(this.signinBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(539, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 578);
            this.panel2.TabIndex = 24;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(148, 99);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(240, 41);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Sign in to Envire";
            // 
            // Login
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("SF Pro Rounded", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envire by VivaSoft";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox2 userBox;
        private MaterialSkin.Controls.MaterialTextBox2 passBox;
        private MaterialSkin.Controls.MaterialButton signinBtn;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

