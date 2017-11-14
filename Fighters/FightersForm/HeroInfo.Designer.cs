namespace FightersForm
{
    partial class HeroInfo
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNameFighter = new System.Windows.Forms.TextBox();
            this.textBoxHealthFighter = new System.Windows.Forms.TextBox();
            this.textBoxDamageFighter = new System.Windows.Forms.TextBox();
            this.FighterName = new System.Windows.Forms.Label();
            this.FighterHealth = new System.Windows.Forms.Label();
            this.FighterDamage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNameFighter
            // 
            this.textBoxNameFighter.Location = new System.Drawing.Point(100, 6);
            this.textBoxNameFighter.Name = "textBoxNameFighter";
            this.textBoxNameFighter.ReadOnly = true;
            this.textBoxNameFighter.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameFighter.TabIndex = 0;
            // 
            // textBoxHealthFighter
            // 
            this.textBoxHealthFighter.Location = new System.Drawing.Point(100, 32);
            this.textBoxHealthFighter.Name = "textBoxHealthFighter";
            this.textBoxHealthFighter.ReadOnly = true;
            this.textBoxHealthFighter.Size = new System.Drawing.Size(100, 20);
            this.textBoxHealthFighter.TabIndex = 1;
            // 
            // textBoxDamageFighter
            // 
            this.textBoxDamageFighter.Location = new System.Drawing.Point(100, 58);
            this.textBoxDamageFighter.Name = "textBoxDamageFighter";
            this.textBoxDamageFighter.ReadOnly = true;
            this.textBoxDamageFighter.Size = new System.Drawing.Size(100, 20);
            this.textBoxDamageFighter.TabIndex = 2;
            // 
            // FighterName
            // 
            this.FighterName.AutoSize = true;
            this.FighterName.Location = new System.Drawing.Point(3, 13);
            this.FighterName.Name = "FighterName";
            this.FighterName.Size = new System.Drawing.Size(35, 13);
            this.FighterName.TabIndex = 3;
            this.FighterName.Text = "Name";
            // 
            // FighterHealth
            // 
            this.FighterHealth.AutoSize = true;
            this.FighterHealth.Location = new System.Drawing.Point(3, 39);
            this.FighterHealth.Name = "FighterHealth";
            this.FighterHealth.Size = new System.Drawing.Size(38, 13);
            this.FighterHealth.TabIndex = 4;
            this.FighterHealth.Text = "Health";
            // 
            // FighterDamage
            // 
            this.FighterDamage.AutoSize = true;
            this.FighterDamage.Location = new System.Drawing.Point(3, 65);
            this.FighterDamage.Name = "FighterDamage";
            this.FighterDamage.Size = new System.Drawing.Size(47, 13);
            this.FighterDamage.TabIndex = 5;
            this.FighterDamage.Text = "Damage";
            // 
            // HeroInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FighterDamage);
            this.Controls.Add(this.FighterHealth);
            this.Controls.Add(this.FighterName);
            this.Controls.Add(this.textBoxDamageFighter);
            this.Controls.Add(this.textBoxHealthFighter);
            this.Controls.Add(this.textBoxNameFighter);
            this.Name = "HeroInfo";
            this.Size = new System.Drawing.Size(209, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameFighter;
        private System.Windows.Forms.TextBox textBoxHealthFighter;
        private System.Windows.Forms.TextBox textBoxDamageFighter;
        private System.Windows.Forms.Label FighterName;
        private System.Windows.Forms.Label FighterHealth;
        private System.Windows.Forms.Label FighterDamage;
    }
}
