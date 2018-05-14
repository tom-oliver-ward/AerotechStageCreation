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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonMUp = new System.Windows.Forms.Button();
            this.buttonMDown = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxArrayPos = new System.Windows.Forms.TextBox();
            this.button_AMotion = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonConvertA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMacro
            // 
            this.listBoxMacro.AllowDrop = true;
            this.listBoxMacro.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMacro.FormattingEnabled = true;
            this.listBoxMacro.ItemHeight = 18;
            this.listBoxMacro.Location = new System.Drawing.Point(19, 53);
            this.listBoxMacro.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMacro.Name = "listBoxMacro";
            this.listBoxMacro.Size = new System.Drawing.Size(1130, 274);
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
            this.button_LMotion.Margin = new System.Windows.Forms.Padding(2);
            this.button_LMotion.Name = "button_LMotion";
            this.button_LMotion.Size = new System.Drawing.Size(103, 52);
            this.button_LMotion.TabIndex = 2;
            this.button_LMotion.Text = "Linear Motion";
            this.button_LMotion.UseVisualStyleBackColor = true;
            this.button_LMotion.Click += new System.EventHandler(this.button_LMotion_Click);
            // 
            // buttonMUp
            // 
            this.buttonMUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMUp.Location = new System.Drawing.Point(1153, 53);
            this.buttonMUp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMUp.Name = "buttonMUp";
            this.buttonMUp.Size = new System.Drawing.Size(69, 52);
            this.buttonMUp.TabIndex = 3;
            this.buttonMUp.Text = "Move Up";
            this.buttonMUp.UseVisualStyleBackColor = true;
            this.buttonMUp.Click += new System.EventHandler(this.buttonMUp_Click);
            // 
            // buttonMDown
            // 
            this.buttonMDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMDown.Location = new System.Drawing.Point(1153, 275);
            this.buttonMDown.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMDown.Name = "buttonMDown";
            this.buttonMDown.Size = new System.Drawing.Size(69, 52);
            this.buttonMDown.TabIndex = 4;
            this.buttonMDown.Text = "Move Down";
            this.buttonMDown.UseVisualStyleBackColor = true;
            this.buttonMDown.Click += new System.EventHandler(this.buttonMDown_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1157, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.MaximumSize = new System.Drawing.Size(100, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 40);
            this.label7.TabIndex = 29;
            this.label7.Text = "Array Position";
            // 
            // textBoxArrayPos
            // 
            this.textBoxArrayPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArrayPos.Location = new System.Drawing.Point(1161, 190);
            this.textBoxArrayPos.Name = "textBoxArrayPos";
            this.textBoxArrayPos.ReadOnly = true;
            this.textBoxArrayPos.Size = new System.Drawing.Size(53, 26);
            this.textBoxArrayPos.TabIndex = 30;
            // 
            // button_AMotion
            // 
            this.button_AMotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AMotion.Location = new System.Drawing.Point(1046, 354);
            this.button_AMotion.Margin = new System.Windows.Forms.Padding(2);
            this.button_AMotion.Name = "button_AMotion";
            this.button_AMotion.Size = new System.Drawing.Size(103, 52);
            this.button_AMotion.TabIndex = 31;
            this.button_AMotion.Text = "Angular Motion";
            this.button_AMotion.UseVisualStyleBackColor = true;
            this.button_AMotion.Click += new System.EventHandler(this.button_AMotion_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(316, 350);
            this.labelSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(168, 20);
            this.labelSpeed.TabIndex = 56;
            this.labelSpeed.Text = "Free Run Acceleration";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSpeed.Location = new System.Drawing.Point(493, 350);
            this.numericUpDownSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(188, 26);
            this.numericUpDownSpeed.TabIndex = 55;
            this.numericUpDownSpeed.ThousandsSeparator = true;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Laser Fire Acceleration";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(493, 380);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(188, 26);
            this.numericUpDown1.TabIndex = 58;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(688, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "µm/s²";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(685, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "µm/s²";
            // 
            // buttonConvertA
            // 
            this.buttonConvertA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvertA.Location = new System.Drawing.Point(528, 433);
            this.buttonConvertA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConvertA.Name = "buttonConvertA";
            this.buttonConvertA.Size = new System.Drawing.Size(103, 52);
            this.buttonConvertA.TabIndex = 61;
            this.buttonConvertA.Text = "Convert To Aerotech";
            this.buttonConvertA.UseVisualStyleBackColor = true;
            this.buttonConvertA.Click += new System.EventHandler(this.buttonConvertA_Click);
            // 
            // MacroGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 496);
            this.Controls.Add(this.buttonConvertA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.numericUpDownSpeed);
            this.Controls.Add(this.button_AMotion);
            this.Controls.Add(this.textBoxArrayPos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonMDown);
            this.Controls.Add(this.buttonMUp);
            this.Controls.Add(this.button_LMotion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMacro);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MacroGenerator";
            this.Text = "Macro Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_LMotion;
        public System.Windows.Forms.ListBox listBoxMacro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonMUp;
        private System.Windows.Forms.Button buttonMDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxArrayPos;
        private System.Windows.Forms.Button button_AMotion;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonConvertA;
    }
}

