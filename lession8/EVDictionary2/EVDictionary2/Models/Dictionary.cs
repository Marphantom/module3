using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EVDictionary2.Models
{
    public class Dictionary
    {
        [Required(ErrorMessage = "KeyWord is required")]
        public string KeyWord { get; set; }
        public string Result { get; set; }
    }
}
