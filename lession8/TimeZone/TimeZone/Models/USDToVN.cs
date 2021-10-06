using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeZone.Models
{
    public class USDToVN
    {
        [Required(ErrorMessage = "rate is not null")]
        public int rate { get; set; }

        [Required(ErrorMessage ="USD is not null")]
        public int USD { get; set; }
        public int VND { get; set; }
    }
}
