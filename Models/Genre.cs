﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyLab2.Models
{
    public class Genre
    {
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Назва")]
        public string Name { get; set; }
    }
}
