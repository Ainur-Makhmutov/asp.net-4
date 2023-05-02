using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Лабораторная_работа___4.Models
{
    public class CalculatorModel
    {
        [Required(ErrorMessage = "Поле пустое!")]
        [Range(-10000,10000, ErrorMessage = "Число должно быть от -10000 до 10000 символов")]
        public long First_Number { get; set; }

        [Required(ErrorMessage = "Поле пустое!")]
        [Range(-9999.9999, 9999.9999, ErrorMessage = "Число должно быть от -9999.9999 до 9999.9999 символов")]
        public float Second_Number { get; set; }
        public string Operation { get; set; }
        public float Result { get; set; }
    }
}