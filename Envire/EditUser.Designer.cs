namespace Envire
{
    partial class EditUser
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
            this.clear = new MaterialSkin.Controls.MaterialButton();
            this.addUser = new MaterialSkin.Controls.MaterialButton();
            this.password = new MaterialSkin.Controls.MaterialTextBox();
            this.address = new MaterialSkin.Controls.MaterialTextBox();
            this.postcode = new MaterialSkin.Controls.MaterialTextBox();
            this.city = new MaterialSkin.Controls.MaterialTextBox();
            this.country = new MaterialSkin.Controls.MaterialTextBox();
            this.email = new MaterialSkin.Controls.MaterialTextBox();
            this.phone = new MaterialSkin.Controls.MaterialTextBox();
            this.lastname = new MaterialSkin.Controls.MaterialTextBox();
            this.middlename = new MaterialSkin.Controls.MaterialTextBox();
            this.firstname = new MaterialSkin.Controls.MaterialTextBox();
            this.username = new MaterialSkin.Controls.MaterialTextBox();
            this.role = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clear.AutoSize = false;
            this.clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clear.Depth = 0;
            this.clear.HighEmphasis = true;
            this.clear.Icon = global::Envire.Properties.Resources.eraser_24px;
            this.clear.Location = new System.Drawing.Point(488, 387);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.clear.Name = "clear";
            this.clear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.clear.Size = new System.Drawing.Size(207, 36);
            this.clear.TabIndex = 28;
            this.clear.Text = "Изчисти";
            this.clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clear.UseAccentColor = false;
            this.clear.UseVisualStyleBackColor = true;
            // 
            // addUser
            // 
            this.addUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addUser.AutoSize = false;
            this.addUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addUser.Depth = 0;
            this.addUser.HighEmphasis = true;
            this.addUser.Icon = global::Envire.Properties.Resources.add_user_male_24px1;
            this.addUser.Location = new System.Drawing.Point(243, 387);
            this.addUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.addUser.Name = "addUser";
            this.addUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addUser.Size = new System.Drawing.Size(237, 36);
            this.addUser.TabIndex = 27;
            this.addUser.Text = "Редактирай потребител";
            this.addUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addUser.UseAccentColor = false;
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // password
            // 
            this.password.AnimateReadOnly = false;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Depth = 0;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.password.Hint = "Парола";
            this.password.LeadingIcon = null;
            this.password.Location = new System.Drawing.Point(327, 306);
            this.password.MaxLength = 50;
            this.password.MouseState = MaterialSkin.MouseState.OUT;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Password = true;
            this.password.Size = new System.Drawing.Size(285, 50);
            this.password.TabIndex = 25;
            this.password.Text = "";
            this.password.TrailingIcon = null;
            // 
            // address
            // 
            this.address.AnimateReadOnly = false;
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address.Depth = 0;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.address.Hint = "Адрес";
            this.address.LeadingIcon = null;
            this.address.Location = new System.Drawing.Point(618, 227);
            this.address.MaxLength = 50;
            this.address.MouseState = MaterialSkin.MouseState.OUT;
            this.address.Multiline = false;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(285, 50);
            this.address.TabIndex = 23;
            this.address.Text = "";
            this.address.TrailingIcon = null;
            // 
            // postcode
            // 
            this.postcode.AnimateReadOnly = false;
            this.postcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postcode.Depth = 0;
            this.postcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.postcode.Hint = "Пощенски код";
            this.postcode.LeadingIcon = null;
            this.postcode.Location = new System.Drawing.Point(618, 171);
            this.postcode.MaxLength = 50;
            this.postcode.MouseState = MaterialSkin.MouseState.OUT;
            this.postcode.Multiline = false;
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(285, 50);
            this.postcode.TabIndex = 22;
            this.postcode.Text = "";
            this.postcode.TrailingIcon = null;
            // 
            // city
            // 
            this.city.AnimateReadOnly = false;
            this.city.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.city.Depth = 0;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.city.Hint = "Град";
            this.city.LeadingIcon = null;
            this.city.Location = new System.Drawing.Point(618, 115);
            this.city.MaxLength = 50;
            this.city.MouseState = MaterialSkin.MouseState.OUT;
            this.city.Multiline = false;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(285, 50);
            this.city.TabIndex = 21;
            this.city.Text = "";
            this.city.TrailingIcon = null;
            // 
            // country
            // 
            this.country.AnimateReadOnly = false;
            this.country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.country.Depth = 0;
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.country.Hint = "Държава";
            this.country.LeadingIcon = null;
            this.country.Location = new System.Drawing.Point(618, 59);
            this.country.MaxLength = 50;
            this.country.MouseState = MaterialSkin.MouseState.OUT;
            this.country.Multiline = false;
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(285, 50);
            this.country.TabIndex = 20;
            this.country.Text = "";
            this.country.TrailingIcon = null;
            // 
            // email
            // 
            this.email.AnimateReadOnly = false;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Depth = 0;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.email.Hint = "Имейл";
            this.email.LeadingIcon = null;
            this.email.Location = new System.Drawing.Point(327, 115);
            this.email.MaxLength = 50;
            this.email.MouseState = MaterialSkin.MouseState.OUT;
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(285, 50);
            this.email.TabIndex = 19;
            this.email.Text = "";
            this.email.TrailingIcon = null;
            // 
            // phone
            // 
            this.phone.AnimateReadOnly = false;
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Depth = 0;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phone.Hint = "Телефон";
            this.phone.LeadingIcon = null;
            this.phone.Location = new System.Drawing.Point(327, 59);
            this.phone.MaxLength = 50;
            this.phone.MouseState = MaterialSkin.MouseState.OUT;
            this.phone.Multiline = false;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(285, 50);
            this.phone.TabIndex = 18;
            this.phone.Text = "";
            this.phone.TrailingIcon = null;
            // 
            // lastname
            // 
            this.lastname.AnimateReadOnly = false;
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastname.Depth = 0;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lastname.Hint = "Фамилия";
            this.lastname.LeadingIcon = null;
            this.lastname.Location = new System.Drawing.Point(36, 171);
            this.lastname.MaxLength = 50;
            this.lastname.MouseState = MaterialSkin.MouseState.OUT;
            this.lastname.Multiline = false;
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(285, 50);
            this.lastname.TabIndex = 17;
            this.lastname.Text = "";
            this.lastname.TrailingIcon = null;
            // 
            // middlename
            // 
            this.middlename.AnimateReadOnly = false;
            this.middlename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middlename.Depth = 0;
            this.middlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.middlename.Hint = "Презиме";
            this.middlename.LeadingIcon = null;
            this.middlename.Location = new System.Drawing.Point(36, 115);
            this.middlename.MaxLength = 50;
            this.middlename.MouseState = MaterialSkin.MouseState.OUT;
            this.middlename.Multiline = false;
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(285, 50);
            this.middlename.TabIndex = 16;
            this.middlename.Text = "";
            this.middlename.TrailingIcon = null;
            // 
            // firstname
            // 
            this.firstname.AnimateReadOnly = false;
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstname.Depth = 0;
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.firstname.Hint = "Име";
            this.firstname.LeadingIcon = null;
            this.firstname.Location = new System.Drawing.Point(36, 59);
            this.firstname.MaxLength = 50;
            this.firstname.MouseState = MaterialSkin.MouseState.OUT;
            this.firstname.Multiline = false;
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(285, 50);
            this.firstname.TabIndex = 15;
            this.firstname.Text = "";
            this.firstname.TrailingIcon = null;
            // 
            // username
            // 
            this.username.AnimateReadOnly = false;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Depth = 0;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.username.Hint = "Потребителско име";
            this.username.LeadingIcon = null;
            this.username.Location = new System.Drawing.Point(36, 306);
            this.username.MaxLength = 50;
            this.username.MouseState = MaterialSkin.MouseState.OUT;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(285, 50);
            this.username.TabIndex = 24;
            this.username.Text = "";
            this.username.TrailingIcon = null;
            // 
            // role
            // 
            this.role.AnimateReadOnly = false;
            this.role.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.role.Depth = 0;
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.role.Hint = "Роля";
            this.role.LeadingIcon = null;
            this.role.Location = new System.Drawing.Point(618, 306);
            this.role.MaxLength = 50;
            this.role.MouseState = MaterialSkin.MouseState.OUT;
            this.role.Multiline = false;
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(285, 50);
            this.role.TabIndex = 29;
            this.role.Text = "";
            this.role.TrailingIcon = null;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.role);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.password);
            this.Controls.Add(this.address);
            this.Controls.Add(this.postcode);
            this.Controls.Add(this.city);
            this.Controls.Add(this.country);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.username);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "EditUser";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton clear;
        private MaterialSkin.Controls.MaterialButton addUser;
        private MaterialSkin.Controls.MaterialTextBox password;
        private MaterialSkin.Controls.MaterialTextBox address;
        private MaterialSkin.Controls.MaterialTextBox postcode;
        private MaterialSkin.Controls.MaterialTextBox city;
        private MaterialSkin.Controls.MaterialTextBox country;
        private MaterialSkin.Controls.MaterialTextBox email;
        private MaterialSkin.Controls.MaterialTextBox phone;
        private MaterialSkin.Controls.MaterialTextBox lastname;
        private MaterialSkin.Controls.MaterialTextBox middlename;
        private MaterialSkin.Controls.MaterialTextBox firstname;
        private MaterialSkin.Controls.MaterialTextBox username;
        private MaterialSkin.Controls.MaterialTextBox role;
    }
}