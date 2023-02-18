namespace Envire
{
    partial class ResendLoginDetails
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
            this.users = new MaterialSkin.Controls.MaterialComboBox();
            this.addUser = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // users
            // 
            this.users.AutoResize = false;
            this.users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.users.Depth = 0;
            this.users.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.users.DropDownHeight = 174;
            this.users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.users.DropDownWidth = 121;
            this.users.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.users.FormattingEnabled = true;
            this.users.Hint = "Потребител";
            this.users.IntegralHeight = false;
            this.users.ItemHeight = 43;
            this.users.Location = new System.Drawing.Point(51, 56);
            this.users.MaxDropDownItems = 4;
            this.users.MouseState = MaterialSkin.MouseState.OUT;
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(250, 49);
            this.users.StartIndex = 0;
            this.users.TabIndex = 0;
            // 
            // addUser
            // 
            this.addUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addUser.AutoSize = false;
            this.addUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addUser.Depth = 0;
            this.addUser.HighEmphasis = true;
            this.addUser.Icon = global::Envire.Properties.Resources.sync_24px1;
            this.addUser.Location = new System.Drawing.Point(94, 125);
            this.addUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.addUser.Name = "addUser";
            this.addUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addUser.Size = new System.Drawing.Size(165, 36);
            this.addUser.TabIndex = 88;
            this.addUser.Text = "Изпращане";
            this.addUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addUser.UseAccentColor = false;
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // ResendLoginDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 179);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.users);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "ResendLoginDetails";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResendLoginDetails";
            this.Load += new System.EventHandler(this.ResendLoginDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox users;
        private MaterialSkin.Controls.MaterialButton addUser;
    }
}