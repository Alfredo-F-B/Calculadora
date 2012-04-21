using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Calculando.Models
{
    public class Div
    {
        public float num1 { set; get; }
        [Required(ErrorMessage="El numero no puede ser cero")]
        [RegularExpression ("^(1-9)")]
        public float num2 { set; get; }
    }
}