using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FighterLogic;

namespace FightersForm
{
    public partial class HeroInfo : UserControl
    {
        public HeroInfo()
        {
            InitializeComponent();
        }

        public string FighterHealthValue
        {
            set { textBoxHealthFighter.Text = value;  }
        }

        public string FighterDamageValue
        {
            set { textBoxDamageFighter.Text = value; }
        }

        public void SetValues(Fighter fighter)
        {
            textBoxNameFighter.Text = fighter.Name;
            textBoxHealthFighter.Text = fighter.Health.ToString();
            textBoxDamageFighter.Text = fighter.Damage.ToString();
        }
    }
}
