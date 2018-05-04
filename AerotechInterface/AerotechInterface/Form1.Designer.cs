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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_LAxesLaser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(28, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(699, 464);
            this.listBox1.TabIndex = 0;
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
            // button_LAxesLaser
            // 
            this.button_LAxesLaser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LAxesLaser.Location = new System.Drawing.Point(904, 97);
            this.button_LAxesLaser.Name = "button_LAxesLaser";
            this.button_LAxesLaser.Size = new System.Drawing.Size(155, 80);
            this.button_LAxesLaser.TabIndex = 2;
            this.button_LAxesLaser.Text = "Linear Axes With Laser";
            this.button_LAxesLaser.UseVisualStyleBackColor = true;
            this.button_LAxesLaser.Click += new System.EventHandler(this.button_LAxesLaser_Click);
            // 
            // MacroGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1052);
            this.Controls.Add(this.button_LAxesLaser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "MacroGenerator";
            this.Text = "Macro Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_LAxesLaser;
    }
}

