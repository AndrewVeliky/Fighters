using System.Drawing;
using System.Windows.Forms;

namespace FightersForm
{
    partial class FightersForms
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightersForms));
            this.buttonFight = new System.Windows.Forms.Button();
            this.radioButtonBetOnCaptain = new System.Windows.Forms.RadioButton();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonBetOnIronMan = new System.Windows.Forms.RadioButton();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.heroInfo1 = new FightersForm.HeroInfo();
            this.heroInfo2 = new FightersForm.HeroInfo();
            this.CaptainAmericaState = new System.Windows.Forms.Label();
            this.IronManState = new System.Windows.Forms.Label();
            this.buttonHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFight
            // 
            this.buttonFight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFight.Location = new System.Drawing.Point(286, 250);
            this.buttonFight.Name = "buttonFight";
            this.buttonFight.Size = new System.Drawing.Size(144, 81);
            this.buttonFight.TabIndex = 23;
            this.buttonFight.Text = "Fight";
            this.buttonFight.UseVisualStyleBackColor = true;
            this.buttonFight.Click += new System.EventHandler(this.buttonFight_Click);
            // 
            // radioButtonBetOnCaptain
            // 
            this.radioButtonBetOnCaptain.AutoSize = true;
            this.radioButtonBetOnCaptain.Location = new System.Drawing.Point(54, 8);
            this.radioButtonBetOnCaptain.Name = "radioButtonBetOnCaptain";
            this.radioButtonBetOnCaptain.Size = new System.Drawing.Size(82, 17);
            this.radioButtonBetOnCaptain.TabIndex = 27;
            this.radioButtonBetOnCaptain.TabStop = true;
            this.radioButtonBetOnCaptain.Text = "Make a bet ";
            this.radioButtonBetOnCaptain.UseVisualStyleBackColor = true;
            this.radioButtonBetOnCaptain.CheckedChanged += new System.EventHandler(this.radioButtonBetOnCaptain_CheckedChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxResult.Location = new System.Drawing.Point(241, 389);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(227, 20);
            this.textBoxResult.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(484, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 190);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Winner";
            // 
            // radioButtonBetOnIronMan
            // 
            this.radioButtonBetOnIronMan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonBetOnIronMan.AutoSize = true;
            this.radioButtonBetOnIronMan.Location = new System.Drawing.Point(553, 8);
            this.radioButtonBetOnIronMan.Name = "radioButtonBetOnIronMan";
            this.radioButtonBetOnIronMan.Size = new System.Drawing.Size(82, 17);
            this.radioButtonBetOnIronMan.TabIndex = 28;
            this.radioButtonBetOnIronMan.TabStop = true;
            this.radioButtonBetOnIronMan.Text = "Make a bet ";
            this.radioButtonBetOnIronMan.UseVisualStyleBackColor = true;
            this.radioButtonBetOnIronMan.CheckedChanged += new System.EventHandler(this.radioButtonBetOnIronMan_CheckedChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonReset.Location = new System.Drawing.Point(263, 428);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(93, 27);
            this.buttonReset.TabIndex = 26;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonbuttonReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonBetOnCaptain);
            this.panel1.Controls.Add(this.radioButtonBetOnIronMan);
            this.panel1.Location = new System.Drawing.Point(1, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 37);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 190);
            this.panel2.TabIndex = 30;
            // 
            // heroInfo1
            // 
            this.heroInfo1.Location = new System.Drawing.Point(1, 196);
            this.heroInfo1.Name = "heroInfo1";
            this.heroInfo1.Size = new System.Drawing.Size(258, 149);
            this.heroInfo1.TabIndex = 31;
            // 
            // heroInfo2
            // 
            this.heroInfo2.Location = new System.Drawing.Point(474, 196);
            this.heroInfo2.Name = "heroInfo2";
            this.heroInfo2.Size = new System.Drawing.Size(258, 149);
            this.heroInfo2.TabIndex = 32;
            // 
            // CaptainAmericaState
            // 
            this.CaptainAmericaState.AutoSize = true;
            this.CaptainAmericaState.Location = new System.Drawing.Point(124, 295);
            this.CaptainAmericaState.Name = "CaptainAmericaState";
            this.CaptainAmericaState.Size = new System.Drawing.Size(13, 13);
            this.CaptainAmericaState.TabIndex = 33;
            this.CaptainAmericaState.Text = "0";
            // 
            // IronManState
            // 
            this.IronManState.AutoSize = true;
            this.IronManState.Location = new System.Drawing.Point(601, 295);
            this.IronManState.Name = "IronManState";
            this.IronManState.Size = new System.Drawing.Size(13, 13);
            this.IronManState.TabIndex = 34;
            this.IronManState.Text = "0";
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(363, 428);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(88, 27);
            this.buttonHistory.TabIndex = 35;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // FightersForms
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(732, 467);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.IronManState);
            this.Controls.Add(this.CaptainAmericaState);
            this.Controls.Add(this.heroInfo2);
            this.Controls.Add(this.heroInfo1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonFight);
            this.MinimumSize = new System.Drawing.Size(748, 506);
            this.Name = "FightersForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fighters";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FightersForm_Closed);
            this.Load += new System.EventHandler(this.FightersForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonFight;
        private System.Windows.Forms.RadioButton radioButtonBetOnCaptain;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonBetOnIronMan;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private HeroInfo heroInfo1;
        private HeroInfo heroInfo2;
        private Label CaptainAmericaState;
        private Label IronManState;
        private Button buttonHistory;
    }
}

