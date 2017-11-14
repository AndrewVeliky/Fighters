using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageFighters
{

    public partial class FighterAdmin : Form
    {
        ManageFightersContext db;

        public FighterAdmin()
        {
            InitializeComponent();

            db = new ManageFightersContext();
            db.Fighters.Load();

            dataGridView1.DataSource = db.Fighters.Local.ToBindingList();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FighterForm frForm = new FighterForm();
            DialogResult result = frForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Fighters fighter = new Fighters();
          
            fighter.Name = frForm.textBoxName.Text;
            fighter.Health = (int)frForm.numericUpDownHealth.Value;
            fighter.Damage = (int)frForm.numericUpDownDamage.Value;
            fighter.Photo = System.IO.File.ReadAllBytes(frForm.openFileDialog1.FileName);
            Image img = new Bitmap(frForm.openFileDialog1.FileName);
            photoDataGridViewImageColumn.Image = img;
            
            db.Fighters.Add(fighter);
            db.SaveChanges();

            MessageBox.Show("New object added");
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Fighters fighter = db.Fighters.Find(id);

                FighterForm frForm = new FighterForm();

                frForm.textBoxName.Text = fighter.Name;
                frForm.numericUpDownHealth.Value = fighter.Health;
                frForm.numericUpDownDamage.Value = fighter.Damage;

                DialogResult result = frForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                fighter.Name = frForm.textBoxName.Text;
                fighter.Health = (int)frForm.numericUpDownHealth.Value;
                fighter.Damage = (int)frForm.numericUpDownDamage.Value;

                db.SaveChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Object refreshed");

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Fighters fighter = db.Fighters.Find(id);
                db.Fighters.Remove(fighter);
                db.SaveChanges();

                MessageBox.Show("Object deleted");
            }
        }

        private void buttonClearHistory_Click(object sender, EventArgs e)
        {
           var fightHistory = db.FightHistory.ToList();

           db.FightHistory.RemoveRange(fightHistory);
           db.SaveChanges();

           MessageBox.Show("History cleared!");
        
        }
    }
}
