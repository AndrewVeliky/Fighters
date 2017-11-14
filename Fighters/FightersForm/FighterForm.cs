using System;
using System.Windows.Forms;
using FighterLogic;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Data.Entity;

namespace FightersForm
{
    public partial class FightersForms : Form
    {
        private static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        FighterContext db;
        string Bet { get; set; }
        Fighter Fighter1 { get; set; }
        Fighter Fighter2 { get; set; }

        public FightersForms()
        {
            InitializeComponent();

            db = new FighterContext();
        }

        private void UpdateData()
        {
            var fighterList = db.Fighters.ToList();
            var historyList = db.FightHistories.ToList();
            Random rnd = new Random();
            var fighterInfo1 = fighterList[rnd.Next(fighterList.Count)];
            var fighterInfo2 = fighterList[rnd.Next(fighterList.Count)];

            Fighter1 = new Fighter(fighterInfo1.Name, fighterInfo1.Health, fighterInfo1.Damage, fighterInfo1.Photo);
            Fighter2 = new Fighter(fighterInfo2.Name, fighterInfo2.Health, fighterInfo2.Damage, fighterInfo2.Photo);

            Fighter1.HealthChanging += (Health) => heroInfo1.FighterHealthValue = Health.ToString();
            Fighter2.HealthChanging += (Health) => heroInfo2.FighterHealthValue = Health.ToString();
            Fighter1.StateChanging += (State) => CaptainAmericaState.Text = Fighter1.State;
            Fighter2.StateChanging += (State) => IronManState.Text = Fighter2.State;
            /*CaptainAmerica.HealthChanging += (Health) => textBoxHealthFighter.Text = Health.ToString();
            IronMan.HealthChanging += (Health) => textBoxHealthEnemy.Text = Health.ToString();
            textBoxNameFighter.Text = CaptainAmerica.Name.ToString();
            textBoxHealthFighter.Text = CaptainAmerica.Health.ToString();
            textBoxDamageFighter.Text = CaptainAmerica.Damage.ToString();
            textBoxNameEnemy.Text = IronMan.Name.ToString();
            textBoxHealthEnemy.Text = IronMan.Health.ToString();
            textBoxDamageEnemy.Text = IronMan.Damage.ToString();*/
            
            heroInfo1.SetValues(Fighter1);
            heroInfo2.SetValues(Fighter2);
            pictureBox1.Image = byteArrayToImage(fighterInfo1.Photo);
            pictureBox2.Image = byteArrayToImage(fighterInfo2.Photo);


            textBoxResult.Clear();
            
            radioButtonBetOnCaptain.Checked = false;
            radioButtonBetOnIronMan.Checked = false;
            buttonFight.Enabled = false;
            CaptainAmericaState.ResetText();
            IronManState.ResetText();
        }

        private void FightersForms_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private async void buttonFight_Click(object sender, EventArgs e)
        {
            buttonFight.Enabled = false;
            buttonReset.Enabled = false;
            var winner = "";
            switch (await Fighter1.FightAsync(Fighter2))
            {
                case -1:
                    winner = Fighter2.Name;
                    //textBoxHealthFighter.Text = "0";
                    heroInfo1.FighterHealthValue = "0";
                    //textBoxHealthEnemy.Text = IronMan.Health.ToString();
                    heroInfo2.FighterHealthValue = Fighter2.Health.ToString();
                    textBoxResult.Text = Fighter2.Name.ToString();
                    break;
                case 1:
                    winner = Fighter1.Name;
                    textBoxResult.Text = Fighter1.Name.ToString();
                    //textBoxHealthEnemy.Text = "0";
                    heroInfo2.FighterHealthValue = "0";
                    //textBoxHealthFighter.Text = CaptainAmerica.Health.ToString();
                    heroInfo1.FighterHealthValue = Fighter1.Health.ToString();
                    break;
                case 0:
                    textBoxResult.Text = "Draw";
                    break;
            }
            if (Bet == winner)
            {
                MessageBox.Show("You Win!");
                buttonReset.Enabled = true;
            }
            else
            {
                MessageBox.Show("You Lose!");
                buttonReset.Enabled = true;
            }

            FightHistories record = new FightHistories();
            record.Bet = Bet;
            record.FirstFighterId = Fighter1.Name;
            record.SecondFighterId = Fighter2.Name;
            record.WinnerId = winner;

            db.FightHistories.Add(record);
            db.SaveChanges();
        }

        private void radioButtonBetOnCaptain_CheckedChanged(object sender, EventArgs e)
        {
            Bet = Fighter1.Name;
            buttonFight.Enabled = true;
        }

        private void radioButtonBetOnIronMan_CheckedChanged(object sender, EventArgs e)
        {
            Bet = Fighter2.Name;
            buttonFight.Enabled = true;
        }

        private void buttonbuttonReset_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FightersForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            FightHistory historyForm = new FightHistory();
            historyForm.dataGridView1.DataSource = db.FightHistories.Local.ToBindingList();
            historyForm.Show();
        }
    }
}
