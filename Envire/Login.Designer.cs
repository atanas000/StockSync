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
            this.signinBtn = new MaterialSkin.Controls.MaterialButton();
            this.passBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.userBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signinBtn
            // 
            this.signinBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.signinBtn.AutoSize = false;
            this.signinBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signinBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signinBtn.Depth = 0;
            this.signinBtn.HighEmphasis = true;
            this.signinBtn.Icon = global::Envire.Properties.Resources.login_32px;
            this.signinBtn.Location = new System.Drawing.Point(113, 425);
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
            this.passBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passBox.AnimateReadOnly = false;
            this.passBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passBox.Depth = 0;
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passBox.HideSelection = true;
            this.passBox.Hint = "Парола";
            this.passBox.LeadingIcon = null;
            this.passBox.Location = new System.Drawing.Point(57, 353);
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
            this.passBox.Size = new System.Drawing.Size(227, 48);
            this.passBox.TabIndex = 17;
            this.passBox.TabStop = false;
            this.passBox.Text = "admin";
            this.passBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passBox.TrailingIcon = global::Envire.Properties.Resources.password_32px3;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // userBox
            // 
            this.userBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userBox.AnimateReadOnly = false;
            this.userBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userBox.Depth = 0;
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userBox.HideSelection = true;
            this.userBox.Hint = "Потребителско име";
            this.userBox.LeadingIcon = null;
            this.userBox.Location = new System.Drawing.Point(57, 299);
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
            this.userBox.Size = new System.Drawing.Size(227, 48);
            this.userBox.TabIndex = 16;
            this.userBox.TabStop = false;
            this.userBox.Text = "admin";
            this.userBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userBox.TrailingIcon = global::Envire.Properties.Resources.user_32px;
            this.userBox.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Envire.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(20, 212);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(300, 64);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Warehouse Management System";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(341, 486);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.signinBtn);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("SF Pro Rounded", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envire by VivaSoft";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox2 userBox;
        private MaterialSkin.Controls.MaterialTextBox2 passBox;
        private MaterialSkin.Controls.MaterialButton signinBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

