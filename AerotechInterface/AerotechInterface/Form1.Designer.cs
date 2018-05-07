namespace AerotechInterface
{
    partial class MacroGenerator
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
            this.listBoxMacro = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_LMotion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMacro
            // 
            this.listBoxMacro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMacro.FormattingEnabled = true;
            this.listBoxMacro.ItemHeight = 29;
            this.listBoxMacro.Location = new System.Drawing.Point(28, 82);
            this.listBoxMacro.Name = "listBoxMacro";
            this.listBoxMacro.Size = new System.Drawing.Size(1805, 439);
            this.listBoxMacro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Macro List";
            // 
            // button_LMotion
            // 
            this.button_LMotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LMotion.Location = new System.Drawing.Point(896, 649);
            this.button_LMotion.Name = "button_LMotion";
            this.button_LMotion.Size = new System.Drawing.Size(155, 80);
            this.button_LMotion.TabIndex = 2;
            this.button_LMotion.Text = "Linear Motion";
            this.button_LMotion.UseVisualStyleBackColor = true;
            this.button_LMotion.Click += new System.EventHandler(this.button_LMotion_Click);
            // 
            // MacroGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1052);
            this.Controls.Add(this.button_LMotion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMacro);
            this.Name = "MacroGenerator";
            this.Text = "Macro Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_LMotion;
        public System.Windows.Forms.ListBox listBoxMacro;
    }
}

