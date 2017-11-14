namespace ManageFighters
{
    partial class FighterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.labelDamage = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDownHealth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDamage = new System.Windows.Forms.NumericUpDown();
            this.labelNameFile = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNameFile);
            this.groupBox1.Controls.Add(this.numericUpDownDamage);
            this.groupBox1.Controls.Add(this.numericUpDownHealth);
            this.groupBox1.Controls.Add(this.buttonChooseFile);
            this.groupBox1.Controls.Add(this.labelFile);
            this.groupBox1.Controls.Add(this.labelDamage);
            this.groupBox1.Controls.Add(this.labelHealth);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fighter";
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Location = new System.Drawing.Point(89, 109);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseFile.TabIndex = 11;
            this.buttonChooseFile.Text = "ChooseFile";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(21, 114);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(38, 13);
            this.labelFile.TabIndex = 10;
            this.labelFile.Text = "Photo:";
            // 
            // labelDamage
            // 
            this.labelDamage.AutoSize = true;
            this.labelDamage.Location = new System.Drawing.Point(21, 78);
            this.labelDamage.Name = "labelDamage";
            this.labelDamage.Size = new System.Drawing.Size(50, 13);
            this.labelDamage.TabIndex = 9;
            this.labelDamage.Text = "Damage:";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.Location = new System.Drawing.Point(21, 52);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(41, 13);
            this.labelHealth.TabIndex = 8;
            this.labelHealth.Text = "Health:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(211, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(114, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(89, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(197, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // numericUpDownHealth
            // 
            this.numericUpDownHealth.Location = new System.Drawing.Point(89, 46);
            this.numericUpDownHealth.Name = "numericUpDownHealth";
            this.numericUpDownHealth.Size = new System.Drawing.Size(197, 20);
            this.numericUpDownHealth.TabIndex = 13;
            // 
            // numericUpDownDamage
            // 
            this.numericUpDownDamage.Location = new System.Drawing.Point(89, 72);
            this.numericUpDownDamage.Name = "numericUpDownDamage";
            this.numericUpDownDamage.Size = new System.Drawing.Size(197, 20);
            this.numericUpDownDamage.TabIndex = 14;
            // 
            // labelNameFile
            // 
            this.labelNameFile.AutoSize = true;
            this.labelNameFile.Location = new System.Drawing.Point(182, 119);
            this.labelNameFile.Name = "labelNameFile";
            this.labelNameFile.Size = new System.Drawing.Size(58, 13);
            this.labelNameFile.TabIndex = 15;
            this.labelNameFile.Text = "choose file";
            // 
            // FighterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 211);
            this.Controls.Add(this.groupBox1);
            this.Name = "FighterForm";
            this.Text = "FighterForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDamage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDamage;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.Label labelFile;
        protected internal System.Windows.Forms.OpenFileDialog openFileDialog1;
        protected internal System.Windows.Forms.NumericUpDown numericUpDownDamage;
        protected internal System.Windows.Forms.NumericUpDown numericUpDownHealth;
        private System.Windows.Forms.Label labelNameFile;
    }
}