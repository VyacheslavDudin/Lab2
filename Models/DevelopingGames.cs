using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyLab2.Models
{
    public class DevelopingGames
    {
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public int ComputerGamesID { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public int DevelopmentStudioID { get; set; }

        public virtual ComputerGames ComputerGames { get; set; }
        public virtual DevelopmentStudio DevelopmentStudio { get; set; }
    }
}
