namespace eMAG
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.usernameBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.currPassBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.newPassBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.confPassBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.ChangePass = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameBox.AnimateReadOnly = false;
            this.usernameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usernameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameBox.Depth = 0;
            this.usernameBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameBox.HideSelection = true;
            this.usernameBox.Hint = "Потребителско име";
            this.usernameBox.LeadingIcon = null;
            this.usernameBox.Location = new System.Drawing.Point(57, 118);
            this.usernameBox.MaxLength = 32767;
            this.usernameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.PrefixSuffixText = null;
            this.usernameBox.ReadOnly = true;
            this.usernameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameBox.SelectedText = "";
            this.usernameBox.SelectionLength = 0;
            this.usernameBox.SelectionStart = 0;
            this.usernameBox.ShortcutsEnabled = true;
            this.usernameBox.Size = new System.Drawing.Size(250, 48);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.TabStop = false;
            this.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameBox.TrailingIcon = null;
            this.usernameBox.UseSystemPasswordChar = false;
            // 
            // currPassBox
            // 
            this.currPassBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currPassBox.AnimateReadOnly = false;
            this.currPassBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.currPassBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.currPassBox.Depth = 0;
            this.currPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.currPassBox.HideSelection = true;
            this.currPassBox.Hint = "Настояща парола";
            this.currPassBox.LeadingIcon = null;
            this.currPassBox.Location = new System.Drawing.Point(57, 230);
            this.currPassBox.MaxLength = 32767;
            this.currPassBox.MouseState = MaterialSkin.MouseState.OUT;
            this.currPassBox.Name = "currPassBox";
            this.currPassBox.PasswordChar = '*';
            this.currPassBox.PrefixSuffixText = null;
            this.currPassBox.ReadOnly = false;
            this.currPassBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currPassBox.SelectedText = "";
            this.currPassBox.SelectionLength = 0;
            this.currPassBox.SelectionStart = 0;
            this.currPassBox.ShortcutsEnabled = true;
            this.currPassBox.Size = new System.Drawing.Size(250, 48);
            this.currPassBox.TabIndex = 1;
            this.currPassBox.TabStop = false;
            this.currPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.currPassBox.TrailingIcon = null;
            this.currPassBox.UseSystemPasswordChar = false;
            // 
            // newPassBox
            // 
            this.newPassBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPassBox.AnimateReadOnly = false;
            this.newPassBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newPassBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newPassBox.Depth = 0;
            this.newPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.newPassBox.HideSelection = true;
            this.newPassBox.Hint = "Нова парола";
            this.newPassBox.LeadingIcon = null;
            this.newPassBox.Location = new System.Drawing.Point(57, 284);
            this.newPassBox.MaxLength = 32767;
            this.newPassBox.MouseState = MaterialSkin.MouseState.OUT;
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.PasswordChar = '*';
            this.newPassBox.PrefixSuffixText = null;
            this.newPassBox.ReadOnly = false;
            this.newPassBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newPassBox.SelectedText = "";
            this.newPassBox.SelectionLength = 0;
            this.newPassBox.SelectionStart = 0;
            this.newPassBox.ShortcutsEnabled = true;
            this.newPassBox.Size = new System.Drawing.Size(250, 48);
            this.newPassBox.TabIndex = 2;
            this.newPassBox.TabStop = false;
            this.newPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.newPassBox.TrailingIcon = null;
            this.newPassBox.UseSystemPasswordChar = false;
            // 
            // confPassBox
            // 
            this.confPassBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confPassBox.AnimateReadOnly = false;
            this.confPassBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.confPassBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.confPassBox.Depth = 0;
            this.confPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.confPassBox.HideSelection = true;
            this.confPassBox.Hint = "Повторете паролата";
            this.confPassBox.LeadingIcon = null;
            this.confPassBox.Location = new System.Drawing.Point(57, 338);
            this.confPassBox.MaxLength = 32767;
            this.confPassBox.MouseState = MaterialSkin.MouseState.OUT;
            this.confPassBox.Name = "confPassBox";
            this.confPassBox.PasswordChar = '*';
            this.confPassBox.PrefixSuffixText = null;
            this.confPassBox.ReadOnly = false;
            this.confPassBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confPassBox.SelectedText = "";
            this.confPassBox.SelectionLength = 0;
            this.confPassBox.SelectionStart = 0;
            this.confPassBox.ShortcutsEnabled = true;
            this.confPassBox.Size = new System.Drawing.Size(250, 48);
            this.confPassBox.TabIndex = 3;
            this.confPassBox.TabStop = false;
            this.confPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.confPassBox.TrailingIcon = null;
            this.confPassBox.UseSystemPasswordChar = false;
            // 
            // ChangePass
            // 
            this.ChangePass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChangePass.AutoSize = false;
            this.ChangePass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangePass.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ChangePass.Depth = 0;
            this.ChangePass.HighEmphasis = true;
            this.ChangePass.Icon = null;
            this.ChangePass.Location = new System.Drawing.Point(98, 423);
            this.ChangePass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChangePass.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ChangePass.Size = new System.Drawing.Size(168, 36);
            this.ChangePass.TabIndex = 27;
            this.ChangePass.Text = "Сменя на парола";
            this.ChangePass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChangePass.UseAccentColor = false;
            this.ChangePass.UseVisualStyleBackColor = true;
            this.ChangePass.Click += new System.EventHandler(this.ChangePass_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 488);
            this.Controls.Add(this.ChangePass);
            this.Controls.Add(this.confPassBox);
            this.Controls.Add(this.newPassBox);
            this.Controls.Add(this.currPassBox);
            this.Controls.Add(this.usernameBox);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Text = "Смяна на парола";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 usernameBox;
        private MaterialSkin.Controls.MaterialTextBox2 currPassBox;
        private MaterialSkin.Controls.MaterialTextBox2 newPassBox;
        private MaterialSkin.Controls.MaterialTextBox2 confPassBox;
        private MaterialSkin.Controls.MaterialButton ChangePass;
    }
}