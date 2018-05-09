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
            this.listBoxMacro.AllowDrop = true;
            this.listBoxMacro.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMacro.FormattingEnabled = true;
            this.listBoxMacro.ItemHeight = 18;
            this.listBoxMacro.Location = new System.Drawing.Point(19, 53);
            this.listBoxMacro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxMacro.Name = "listBoxMacro";
            this.listBoxMacro.Size = new System.Drawing.Size(1205, 274);
            this.listBoxMacro.TabIndex = 0;
            this.listBoxMacro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMacro_MouseClick);
            this.listBoxMacro.SelectedIndexChanged += new System.EventHandler(this.listBoxMacro_SelectedIndexChanged);
            this.listBoxMacro.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxMacro_DragDrop);
            this.listBoxMacro.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxMacro_DragOver);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Macro List";
            // 
            // button_LMotion
            // 
            this.button_LMotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LMotion.Location = new System.Drawing.Point(19, 350);
            this.button_LMotion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_LMotion.Name = "button_LMotion";
            this.button_LMotion.Size = new System.Drawing.Size(103, 52);
            this.button_LMotion.TabIndex = 2;
            this.button_LMotion.Text = "Linear Motion";
            this.button_LMotion.UseVisualStyleBackColor = true;
            this.button_LMotion.Click += new System.EventHandler(this.button_LMotion_Click);
            // 
            // MacroGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 684);
            this.Controls.Add(this.button_LMotion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMacro);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

