namespace Envire
{
    partial class CancelOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelOrder));
            this.saveStatus = new MaterialSkin.Controls.MaterialButton();
            this.closeBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.orderNumberCancel = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // saveStatus
            // 
            this.saveStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveStatus.AutoSize = false;
            this.saveStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveStatus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveStatus.Depth = 0;
            this.saveStatus.HighEmphasis = true;
            this.saveStatus.Icon = null;
            this.saveStatus.Location = new System.Drawing.Point(477, 204);
            this.saveStatus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveStatus.Name = "saveStatus";
            this.saveStatus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveStatus.Size = new System.Drawing.Size(114, 36);
            this.saveStatus.TabIndex = 49;
            this.saveStatus.Text = "Запиши";
            this.saveStatus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveStatus.UseAccentColor = false;
            this.saveStatus.UseVisualStyleBackColor = true;
            this.saveStatus.Click += new System.EventHandler(this.saveStatus_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.AutoSize = false;
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.closeBtn.Depth = 0;
            this.closeBtn.HighEmphasis = true;
            this.closeBtn.Icon = null;
            this.closeBtn.Location = new System.Drawing.Point(353, 204);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeBtn.Size = new System.Drawing.Size(114, 36);
            this.closeBtn.TabIndex = 46;
            this.closeBtn.Text = "Затвори";
            this.closeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeBtn.UseAccentColor = false;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(30, 50);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(420, 19);
            this.materialLabel3.TabIndex = 48;
            this.materialLabel3.Text = "Сигурни ли сте, че искате да откажете поръчка с номер";
            // 
            // orderNumberCancel
            // 
            this.orderNumberCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderNumberCancel.AnimateReadOnly = false;
            this.orderNumberCancel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderNumberCancel.Depth = 0;
            this.orderNumberCancel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.orderNumberCancel.Hint = "Номер на фактура";
            this.orderNumberCancel.LeadingIcon = null;
            this.orderNumberCancel.Location = new System.Drawing.Point(30, 83);
            this.orderNumberCancel.MaxLength = 50;
            this.orderNumberCancel.MouseState = MaterialSkin.MouseState.OUT;
            this.orderNumberCancel.Multiline = false;
            this.orderNumberCancel.Name = "orderNumberCancel";
            this.orderNumberCancel.Size = new System.Drawing.Size(364, 50);
            this.orderNumberCancel.TabIndex = 47;
            this.orderNumberCancel.Text = "";
            this.orderNumberCancel.TrailingIcon = null;
            // 
            // CancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 262);
            this.Controls.Add(this.saveStatus);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.orderNumberCancel);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CancelOrder";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Envire | Cancel order";
            this.Load += new System.EventHandler(this.CancelOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton saveStatus;
        private MaterialSkin.Controls.MaterialButton closeBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox orderNumberCancel;
    }
}