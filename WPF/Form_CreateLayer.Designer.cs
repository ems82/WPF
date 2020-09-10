namespace WPF
{
    partial class Form_CreateLayer
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
            this.textBox_layerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_isOn = new System.Windows.Forms.CheckBox();
            this.checkBox_isFrozen = new System.Windows.Forms.CheckBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_layerName
            // 
            this.textBox_layerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_layerName.Location = new System.Drawing.Point(22, 39);
            this.textBox_layerName.Name = "textBox_layerName";
            this.textBox_layerName.Size = new System.Drawing.Size(377, 20);
            this.textBox_layerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название слоя:";
            // 
            // checkBox_isOn
            // 
            this.checkBox_isOn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.checkBox_isOn.AutoSize = true;
            this.checkBox_isOn.Location = new System.Drawing.Point(22, 81);
            this.checkBox_isOn.Name = "checkBox_isOn";
            this.checkBox_isOn.Size = new System.Drawing.Size(70, 17);
            this.checkBox_isOn.TabIndex = 2;
            this.checkBox_isOn.Text = "Включен";
            this.checkBox_isOn.UseVisualStyleBackColor = true;
            // 
            // checkBox_isFrozen
            // 
            this.checkBox_isFrozen.AutoSize = true;
            this.checkBox_isFrozen.Location = new System.Drawing.Point(22, 104);
            this.checkBox_isFrozen.Name = "checkBox_isFrozen";
            this.checkBox_isFrozen.Size = new System.Drawing.Size(85, 17);
            this.checkBox_isFrozen.TabIndex = 3;
            this.checkBox_isFrozen.Text = "Заморожен";
            this.checkBox_isFrozen.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.Location = new System.Drawing.Point(264, 84);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(60, 25);
            this.button_ok.TabIndex = 4;
            this.button_ok.Text = "ОК";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(340, 84);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(59, 25);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_CreateLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(421, 141);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.checkBox_isFrozen);
            this.Controls.Add(this.checkBox_isOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_layerName);
            this.MaximumSize = new System.Drawing.Size(500, 180);
            this.MinimumSize = new System.Drawing.Size(300, 180);
            this.Name = "Form_CreateLayer";
            this.Text = "Создание слоя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_layerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_isOn;
        private System.Windows.Forms.CheckBox checkBox_isFrozen;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button1;
    }
}