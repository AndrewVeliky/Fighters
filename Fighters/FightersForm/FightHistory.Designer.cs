namespace FightersForm
{
    partial class FightHistory
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.betDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstFighterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondFighterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winnerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fightHistoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fightHistoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.betDataGridViewTextBoxColumn,
            this.firstFighterIdDataGridViewTextBoxColumn,
            this.secondFighterIdDataGridViewTextBoxColumn,
            this.winnerIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fightHistoriesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(685, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // betDataGridViewTextBoxColumn
            // 
            this.betDataGridViewTextBoxColumn.DataPropertyName = "Bet";
            this.betDataGridViewTextBoxColumn.HeaderText = "Bet";
            this.betDataGridViewTextBoxColumn.Name = "betDataGridViewTextBoxColumn";
            // 
            // firstFighterIdDataGridViewTextBoxColumn
            // 
            this.firstFighterIdDataGridViewTextBoxColumn.DataPropertyName = "FirstFighterId";
            this.firstFighterIdDataGridViewTextBoxColumn.HeaderText = "First Fighter";
            this.firstFighterIdDataGridViewTextBoxColumn.Name = "firstFighterIdDataGridViewTextBoxColumn";
            // 
            // secondFighterIdDataGridViewTextBoxColumn
            // 
            this.secondFighterIdDataGridViewTextBoxColumn.DataPropertyName = "SecondFighterId";
            this.secondFighterIdDataGridViewTextBoxColumn.HeaderText = "Second Fighter";
            this.secondFighterIdDataGridViewTextBoxColumn.Name = "secondFighterIdDataGridViewTextBoxColumn";
            // 
            // winnerIdDataGridViewTextBoxColumn
            // 
            this.winnerIdDataGridViewTextBoxColumn.DataPropertyName = "WinnerId";
            this.winnerIdDataGridViewTextBoxColumn.HeaderText = "Winner";
            this.winnerIdDataGridViewTextBoxColumn.Name = "winnerIdDataGridViewTextBoxColumn";
            // 
            // fightHistoriesBindingSource
            // 
            this.fightHistoriesBindingSource.DataSource = typeof(FightersForm.FightHistories);
            // 
            // FightHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FightHistory";
            this.Text = "FightHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fightHistoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fightHistoriesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn betDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstFighterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondFighterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winnerIdDataGridViewTextBoxColumn;
    }
}