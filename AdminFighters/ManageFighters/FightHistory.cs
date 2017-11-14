using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFighters
{
    class FightHistory
    {
        public string Bet { get; set; }
        public string FirstFighterId { get; set; }
        public string SecondFighterId { get; set; }
        public string WinnerId { get; set; }

        [Key]
        public int Id { get; set; }
    }
}
